using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GegiCRM.DAL.Concrete
{
    public static class ModelBuilderExtensions
    {
        //public static 



        public static void Seed(this ModelBuilder modelBuilder)
        {
            IPasswordHasher<IdentityUser> _passwordHasher = new PasswordHasher<IdentityUser>();

            var roleRelation = new UsersAuthorizationRole()
            {
                AddedBy = 1,
                ModifiedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                StartDate = DateTime.Now,
                EndDate = DateTime.MaxValue,
                UserId = 1,
                RoleId = 1,
            };

            var admin = new User
            {
                Id = 1,
                PasswordHash = _passwordHasher.HashPassword(null, "123321"),
                Name = "Yigit",
                Surname = "Genc",
                AddedBy = 1,
                ModifiedBy = 1,
                Email = "yigit.genc@gegi.com.tr",
                PassHash = "hash1",
                UserCompanyId = 1,
                //UsersAuthorizationRoleUsers = new List<UsersAuthorizationRole>()
                //{
                  
                //},
                //UserCompany = new UserCompany
                //{
                //    Id = 1,
                //    CompanyName = "AdminCompany",
                //    AddedBy = 1,
                //    ModifiedBy = 1
                //}

            };

            UserCompany userCompany = new UserCompany
            {
                Id = 1,
                CompanyName = "AdminCompany"
            };



            AuthorizationsRole sysAdminRole = new AuthorizationsRole()
            {
                Id = 1,
                AddedBy = 1,
                ModifiedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "SysAdmin",
                Description = "Sistem Admini Full Yetki",
                NormalizedName = "Sistem Admini",

            };

            modelBuilder.Entity<UserCompany>().HasData(userCompany);




            using (var ts = new TransactionScope())
            {


                modelBuilder.Entity<User>().HasData(admin);
                // do the stuff
                ts.Complete();

                modelBuilder.Entity<AuthorizationsRole>().HasData(sysAdminRole);

                //modelBuilder.Entity<UsersAuthorizationRole>().HasData(roleRelation);
            }

        }
    }

}
