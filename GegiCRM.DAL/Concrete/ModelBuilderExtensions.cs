using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Concrete
{
    public static class ModelBuilderExtensions
    {
        //public static 

        public static void Seed(this ModelBuilder modelBuilder)
        {
            IPasswordHasher<IdentityUser> _passwordHasher = new PasswordHasher<IdentityUser>();

            //User
            modelBuilder.Entity<User>()
                .HasData(
                   new User
                   {
                       Id = 1,
                       PasswordHash = _passwordHasher.HashPassword(null, "123321"),
                       Name = "Yigit",
                       Surname = "Genc",
                       AddedBy = 1,
                       ModifiedBy = 1,
                       Email = "yigit.genc@gegi.com.tr",
                       PassHash = "hash1",
                   }
            );
            //AuthRole
            modelBuilder.Entity<AuthorizationsRole>()
                .HasData(
                   new AuthorizationsRole()
                   {
                       Id = 1,
                       AddedBy = 1,
                       ModifiedBy = 1,
                       CreatedDate = DateTime.Now,
                       ModifiedDate = DateTime.Now,
                       Name = "SysAdmin",
                       Description = "Sistem Admini Full Yetki",
                       NormalizedName = "Sistem Admini",
                       
                   }
            );
            //roleRelations
            modelBuilder.Entity<UsersAuthorizationRole>()
                .HasData(
                   new UsersAuthorizationRole()
                   {
                       AddedBy = 1,
                       ModifiedBy = 1,
                       CreatedDate = DateTime.Now,
                       ModifiedDate = DateTime.Now,
                       StartDate = DateTime.Now,
                       EndDate = DateTime.MaxValue,
                       UserId = 1,
                       RoleId = 1,

                   }
            );
        }
    }

}
