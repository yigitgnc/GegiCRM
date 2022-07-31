using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Utils.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Repositories;
using GegiCRM.WebUI.Models;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    [ActivityLogger]
    public class AppUsersController : Controller
    {
        private readonly CrmDbContext _context;
        private readonly GenericManager<UserMessage> _mesageManager = new GenericManager<UserMessage>(new GenericRepository<UserMessage>());
        public AppUsersController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: AppUsers
        public async Task<IActionResult> Index()
        {
            var context = _context.Users.Include(a => a.AddedBy).Include(a => a.ModifiedBy).Include(a => a.UserCompany);
            return View(await context.ToListAsync());
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .Include(a => a.AddedBy)
                .Include(a => a.ModifiedBy)
                .Include(a => a.UserCompany)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // GET: AppUsers/Create
        public IActionResult Create()
        {
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["UserCompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName");
            return View();
        }

        // POST: AppUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserCompanyId,Name,Surname,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted,ProfilePictureUrl,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", appUser.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", appUser.ModifiedById);
            ViewData["UserCompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName", appUser.UserCompanyId);
            return View(appUser);
        }

        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", appUser.AddedById);
            ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", appUser.ModifiedById);
            ViewData["UserCompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName", appUser.UserCompanyId);
            return View(appUser);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserCompanyId,Name,Surname,CreatedDate,ModifiedDate,AddedById,ModifiedById,IsDeleted,ProfilePictureUrl,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            try
            {
                try
                {
                    _context.Update(appUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserExists(appUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["AddedById"] = new SelectList(_context.Users, "Id", "Name", appUser.AddedById);
                ViewData["ModifiedById"] = new SelectList(_context.Users, "Id", "Name", appUser.ModifiedById);
                ViewData["UserCompanyId"] = new SelectList(_context.UserCompanies, "Id", "CompanyName", appUser.UserCompanyId);
                return View(appUser);
            }
               
            //}
           
        }

        // GET: AppUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .Include(a => a.AddedBy)
                .Include(a => a.ModifiedBy)
                .Include(a => a.UserCompany)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // POST: AppUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'Context.Users'  is null.");
            }
            var appUser = await _context.Users.FindAsync(id);
            if (appUser != null)
            {
                _context.Users.Remove(appUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserExists(int id)
        {
          return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> _GetUserMessages()
        {
            AppUser user = await _mesageManager.GetCurrentUserAsync();
            CrmDbContext dbContext = new CrmDbContext();
            List<UserMessagesViewModel> data = new List<UserMessagesViewModel>();

            ViewBag.UserId = user.Id;
            ViewBag.TotalMessageCount = dbContext.UserMessages.Where(x => x.RecieverUserId == user.Id && x.ReadDate == null).Count();

            foreach (var item in dbContext.Users.Where(x => x.Id != user.Id).ToList())
            {
                UserMessagesViewModel newVm = new UserMessagesViewModel()
                {
                    User = item,
                    LastMessage = dbContext.UserMessages.Where(x => (x.SenderUserId == user.Id && x.RecieverUserId == item.Id) || (x.SenderUserId == item.Id && x.RecieverUserId == user.Id)).OrderByDescending(x=>x.SendDate).FirstOrDefault(),
                };
                data.Add(newVm);
            }

            return View(data.OrderByDescending(x => x.LastMessage?.SendDate));
        }

        public async Task<IActionResult> _GetChatMessages(int id)
        {
            AppUser user = await _mesageManager.GetCurrentUserAsync();
            AppUser reciever = _context.Users.FirstOrDefault(x => x.Id == id);
            ViewBag.User = user;
            ViewBag.Reciever = reciever;
            var data = _context.UserMessages.Where(x=> (x.SenderUserId == user.Id && x.RecieverUserId == reciever.Id) || (x.SenderUserId == reciever.Id && x.RecieverUserId == user.Id)).ToList();

            foreach (UserMessage? item in data.Where(x=>x.ReadDate == null && x.SenderUserId != user.Id))
            {
                item.ReadDate = DateTime.Now;
                _mesageManager.Update(item);
            }


            return View(data);
        }


    }
}
