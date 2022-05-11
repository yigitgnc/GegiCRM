using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

            UserCompany userCompany = new UserCompany
            {
                Id = 1,
                CompanyName = "AdminCompany"
            };

            var admin = new AppUser
            {
                Id = 1,
                UserCompanyId = 1,
                Name = "Yiğit",
                Surname = "Genç",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                AddedBy = 1,
                ModifiedBy = null,
                IsDeleted = false,
                UserName = "AdminYigit",
                NormalizedUserName = "ADMINYGT",
                NormalizedEmail = "YIGIT.GENC@GEGI.COM.TR",
                Email = "yigit.genc@gegi.com.tr",
                EmailConfirmed = true,
                //PasswordHash = "AQAAAAEAACcQAAAAECfiMoHhbnI/neKUjyDEx6fu+DLj1u3PlUAOSXrNffogmOGDopoGhxMzQMqIM0j76g==",
                SecurityStamp = "VNB3UOQL5J2LFDAPPGL77YP643TINIZA",
                ConcurrencyStamp = "fb0be773-2b9d-4ad3-93a7-30a8fdf00c8a",
                PhoneNumber = "+905382630008",
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                ProfilePictureUrl = null,

            };

            IPasswordHasher<AppUser> _passwordHasher = new PasswordHasher<AppUser>();

            admin.PasswordHash = _passwordHasher.HashPassword(admin, "123321");

            //_passwordHasher.VerifyHashedPassword()    
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


            var roleRelation = new UsersAuthorizationRole()
            {

                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(10),
                UserId = 1,
                RoleId = 1,
                //AddedBy = 1,
            };




            using (var ts = new TransactionScope())
            {


                modelBuilder.Entity<UserCompany>().HasData(userCompany);

                modelBuilder.Entity<AppUser>().HasData(admin);
                // do the stuff
                ts.Complete();

                modelBuilder.Entity<AuthorizationsRole>().HasData(sysAdminRole);

                modelBuilder.Entity<UsersAuthorizationRole>().HasData(roleRelation);
            }

        }
    }

}
