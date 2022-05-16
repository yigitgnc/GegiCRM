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
                //SecurityStamp = "VNB3UOQL5J2LFDAPPGL77YP643TINIZA",
                SecurityStamp = Guid.NewGuid().ToString(),
                //ConcurrencyStamp = "fb0be773-2b9d-4ad3-93a7-30a8fdf00c8a",
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
            AppIdentityRole sysAdminRole = new AppIdentityRole()
            {
                Id = 1,
                AddedBy = 1,
                ModifiedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Name = "SysAdmin",
                Description = "Sistem Admini Full Yetki",
                NormalizedName = "Sistem Admini",
                RoleGroupId = 1,
            };

            AppIdentityRoleGroup sysAuthorizationRoleGroup = new AppIdentityRoleGroup()
            {
                Id = 1,
                AddedBy = 1,
                Name = "Admin Role Grubu",
                Description = "Admin Rollerinin Bulunduğu Grup"

            };

            var roleRelation = new AppRolesOfUsers()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(10),
                UserId = 1,
                RoleId = 1,
                AddedBy = 1,
            };

            Sector sector = new Sector()
            {
                Id = 1,
                AddedBy = 1,
                Name = "Test Sektörü",
                Description = "Test Sektör Açıklaması",
            };

            CustomerType customerType = new CustomerType()
            {
                Id = 1,
                AddedBy = 1,
                Name = "Test Müşteri Tipi",
                Description = "Bu Müşteri Tipi Tesat Amaçlı Eklenmiştir",
            };

            List<Currency> currencies = new List<Currency>() 
            { 
              new Currency()
              {
                  Id = 1,
                  AddedBy = 1,
                  Code = "TRY",
                  Name = "Türk Lirası",
                  CreatedDate = DateTime.Now,
              },
              new Currency()
              {
                  Id = 2,
                  AddedBy = 1,
                  Code = "USD",
                  Name = "Amerikan Doları",
                  CreatedDate = DateTime.Now,
              },
              new Currency()
              {
                  Id = 3,
                  AddedBy = 1,
                  Code = "EUR",
                  Name = "EURO",
                  CreatedDate = DateTime.Now,
              }
            };

            List<Segment> segments = new List<Segment>();
            for (int i = 1; i <= 10; i++)
            {
                segments.Add(new Segment()
                {
                    AddedBy = 1,
                    Id = i,
                    Name = $"Segment {i}",
                    Description = $"Segment {i} Açıklaması",
                    CreatedDate = DateTime.Now,
                });
            };




            Customer customer = new Customer()
            {
                Id = 1,
                AddedBy = 1,
                TypeId = 1,
                Name = "Test Müşterisi",
                Surname = "Soyad",
                TicariUnvan = "Test Ticari Ünvanı",
                CariKodu = "123",
                IsActive = true,
                SectorId = 1,
                SegmentId = 1,
            };




            //add entities
            modelBuilder.Entity<UserCompany>().HasData(userCompany);
            modelBuilder.Entity<AppUser>().HasData(admin);
            modelBuilder.Entity<AppIdentityRole>().HasData(sysAdminRole);
            modelBuilder.Entity<AppIdentityRoleGroup>().HasData(sysAuthorizationRoleGroup);
            modelBuilder.Entity<AppRolesOfUsers>().HasData(roleRelation);
            modelBuilder.Entity<Sector>().HasData(sector);
            modelBuilder.Entity<CustomerType>().HasData(customerType);
            modelBuilder.Entity<Segment>().HasData(segments);
            modelBuilder.Entity<Currency>().HasData(currencies);
            modelBuilder.Entity<Customer>().HasData(customer);


        }
    }

}
