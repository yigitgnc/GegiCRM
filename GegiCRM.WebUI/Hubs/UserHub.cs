using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace GegiCRM.WebUI.Hubs
{
    public class UserHub : Hub
    {
        public static List<AppUser> _connectedUsers = new List<AppUser>();


        private readonly GenericManager<UserDailyActivityLog> _genericUserActivityLogManager = new GenericManager<UserDailyActivityLog>(new GenericRepository<UserDailyActivityLog>());
        private readonly GenericManager<AppUser> _appUserManager = new GenericManager<AppUser>(new EfAppUserRepository());
        private readonly GenericManager<UserMessage> _userMessageManager = new GenericManager<UserMessage>(new GenericRepository<UserMessage>());
        public override async Task<Task> OnConnectedAsync()
        {

            AppUser user = await _genericUserActivityLogManager.GetCurrentUserAsync();

            var connectionId = Context.ConnectionId;
            if (user.SignalrConnectionId == null || user.SignalrConnectionId != connectionId)
            {
                user.SignalrConnectionId = connectionId;
                _appUserManager.Update(user);
            }


            //bu gün için aktivite kaydı varmı bakalım
            var lastActivty = _genericUserActivityLogManager.ListByFilter(x => x.CreatedDate.Date == DateTime.Now.Date && x.AppUserId == user.Id, false).FirstOrDefault();
            if (lastActivty == null)
            {
                UserDailyActivityLog newActivtyLog = new UserDailyActivityLog()
                {
                    AppUserId = user.Id,
                    CreatedDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                };

                _genericUserActivityLogManager.Create(newActivtyLog);
            }
            else
            {
                lastActivty.LastLoginDate = DateTime.Now;
                _genericUserActivityLogManager.Update(lastActivty);
            }

            if (!_connectedUsers.Any(x => x.Id == user.Id))
            {
                _connectedUsers.Add(user);
                user.IsOnline = true;
                _appUserManager.Update(user);
                await Clients.Others.SendAsync("UserConnected", user.Id, Context.ConnectionId);
                await Clients.All.SendAsync("UpdateUserCount", _connectedUsers.Count - 1);
            }

            return base.OnConnectedAsync();
        }

        public override async Task<Task> OnDisconnectedAsync(Exception? exception)
        {
            AppUser user = await _genericUserActivityLogManager.GetCurrentUserAsync();

            //bu gün için aktivite kaydı varmı bakalım
            var lastActivty = _genericUserActivityLogManager.ListByFilter(x => x.CreatedDate.Date == DateTime.Now.Date && x.AppUserId == user.Id, false).FirstOrDefault();
            if (lastActivty == null)
            {
                UserDailyActivityLog newActivtyLog = new UserDailyActivityLog()
                {
                    AppUserId = user.Id,
                    CreatedDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                    LastLogoutDate = DateTime.Now,
                };

                _genericUserActivityLogManager.Create(newActivtyLog);
            }
            else
            {
                lastActivty.LastLogoutDate = DateTime.Now;
                lastActivty.TotalActiveTime += lastActivty.LastLogoutDate - lastActivty.LastLoginDate;
                _genericUserActivityLogManager.Update(lastActivty);
            }

            //3.5 sn bekle eğer 3.5 saniyede user geri huba girmemişse sil bu agayı;
            await Task.Delay(2500);
            lastActivty = _genericUserActivityLogManager.ListByFilter(x => x.CreatedDate.Date == DateTime.Now.Date && x.AppUserId == user.Id, false).FirstOrDefault();
            if (lastActivty.LastLoginDate < lastActivty.LastLogoutDate)
            {
                _connectedUsers.Remove(user);

                user.IsOnline = false;
                _appUserManager.Update(user);

                await Clients.Others.SendAsync("UserDisconnected", user.Id, lastActivty.LastLogoutDate.ToString());
                await Clients.Others.SendAsync("UpdateUserCount", _connectedUsers.Count - 1);
            }


            return base.OnDisconnectedAsync(exception);
        }


        public async Task WhereAmI(string title)
        {
            AppUser user = await _genericUserActivityLogManager.GetCurrentUserAsync();

            var lastActivty = _genericUserActivityLogManager.ListByFilter(x => x.CreatedDate.Date == DateTime.Now.Date && x.AppUserId == user.Id, false).FirstOrDefault();
            lastActivty.LastVisitedPageTitle = title;
            _genericUserActivityLogManager.Update(lastActivty);
            await Clients.Others.SendAsync("WhereIsUser", user.Id, title);

        }

        public async Task SendMessage(int reciverId, string message)
        {
            AppUser? reciver = _appUserManager.GetById(reciverId, false);

            if (reciver != null && !string.IsNullOrWhiteSpace(message))
            {
                AppUser user = await _genericUserActivityLogManager.GetCurrentUserAsync();

                UserMessage newMessage = new UserMessage()
                {
                    SenderUserId = user.Id,
                    RecieverUserId = reciver.Id,
                    Message = message,
                    SendDate = DateTime.Now,
                };
                _userMessageManager.Create(newMessage);
                await Clients.User(reciver.SignalrConnectionId).SendAsync("GotNewMessage", user.Id, message);

            }

        }
    }
}
