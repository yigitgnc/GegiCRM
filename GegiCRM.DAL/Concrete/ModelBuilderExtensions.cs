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
                AddedById = 1,
                ModifiedBy = null,
                IsDeleted = false,
                UserName = "YG",
                NormalizedUserName = "YG",
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
                AddedById = 1,
                ModifiedById = 1,
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
                AddedById = 1,
                Name = "Admin Role Grubu",
                Description = "Admin Rollerinin Bulunduğu Grup"

            };

            var roleRelation = new AppRolesOfUsers()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(10),
                UserId = 1,
                RoleId = 1,
                AddedById = 1,
            };

            Sector sector = new Sector()
            {
                Id = 1,
                AddedById = 1,
                Name = "Test Sektörü",
                Description = "Test Sektör Açıklaması",
            };

            List<CustomerType> customerTypes = new List<CustomerType>()
            {
                new CustomerType
                {
                Id = 1,
                AddedById = 1,
                Name = "Standart",
                Description = "Standart Müşteri Tipi",
                },
                new CustomerType
                {
                Id = 2,
                AddedById = 1,
                Name = "Potansiyel Bayi",
                Description = "Potansiyel Bayi Müşteri Tipi",
                },
                new CustomerType
                {
                Id = 3,
                AddedById = 1,
                Name = "Potansiyel Son Kullanıcı",
                Description = "Potansiyel Son Kullanıcı Müşteri Tipi",
                },
            };

            List<Currency> currencies = new List<Currency>()
            {
              new Currency()
              {
                  Id = 1,
                  AddedById = 1,
                  Code = "TRY",
                  Name = "Türk Lirası",
                  CreatedDate = DateTime.Now,
                  CurrentValue = 1
              },
              new Currency()
              {
                  Id = 2,
                  AddedById = 1,
                  Code = "USD",
                  Name = "Amerikan Doları",
                  CreatedDate = DateTime.Now,
                  CurrentValue = 16
              },
              new Currency()
              {
                  Id = 3,
                  AddedById = 1,
                  Code = "EUR",
                  Name = "EURO",
                  CreatedDate = DateTime.Now,
                  CurrentValue = 17
              }
            };

            List<Segment> segments = new List<Segment>();
            for (int i = 1; i <= 10; i++)
            {
                segments.Add(new Segment()
                {
                    AddedById = 1,
                    Id = i,
                    Name = $"Segment {i}",
                    Description = $"Segment {i} Açıklaması",
                    CreatedDate = DateTime.Now,
                });
            };

            List<SegmentOran> segmentOrans = new List<SegmentOran>()
            {
                #region TL(CurrencyID = 1)
                new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 22.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 13.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 11m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 7.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 6m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 5.25m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 4.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 4m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 3.38m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 3m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 3m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 2m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.88m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 27m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 16.2m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 126.6m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 9m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 7.2m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 6.3m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 5.85m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 5.4m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 4.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 4.05m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 3.78m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 3.6m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 2.7m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 2.25m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.98m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.8m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 32.4m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 19.44m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 15.12m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 10.8m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 8.64m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 7.56m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 7.02m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 6.48m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 5.4m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 4.86m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 4.54m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 4.32m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 3.24m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 2.7m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.38m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.16m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 38.88m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 23.33m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 18.14m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 12.96m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 10.37m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 9.07m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 8.42m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 7.78m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 6.48m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 5.83m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 5.44m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 5.18m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 3.89m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 3.24m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.85m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.59m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 46.66m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 27.99m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 21.77m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 15.55m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 12.44m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 10.89m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 10.11m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 9.33m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 7.78m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 7m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 6.53m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 6.22m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 4.67m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 3.89m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 3.42m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 3.11m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 55.99m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 33.59m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 26.13m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 18.66m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 14.93m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 13.06m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 12.13m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 11.2m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 9.33m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 8.4m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 7.84m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 7.46m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 5.6m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 4.67m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 4.11m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 3.73m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 67.18m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 40.31m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 31.35m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 22.39m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 17.92m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 15.68m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 14.56m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 13.44m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 11.2m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 10.08m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 9.41m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 8.96m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 6.72m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 5.6m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 4.93m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 4.48m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 80.62m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 48.37m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 37.62m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 26.87m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 21.5m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 18.81m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 17.47m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 16.12m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 13.44m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 12.09m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 11.29m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 10.75m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 8.06m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 6.72m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 5.91m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 5.37m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 96.75m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 58.05m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 45.15m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 32.25m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 25.8m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 22.57m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 20.96m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 19.35m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 16.12m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 14.51m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 13.54m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 12.9m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 9.67m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 8.06m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 7m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 6.45m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 116.1m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 72.56m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 58.69m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 43.54m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 36.12m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 32.73m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 31.44m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 29.99m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 25.8m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 23.94m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 23.03m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 22.57m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 17.41m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 14.91m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 13.48m, CurrencyID = 1 },
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 12.58m, CurrencyID = 1 },
                #endregion
                #region USD(CurencyID = 2)

new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 15m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 9m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 7m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 4m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 3.5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 3.25m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 3m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 2.5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 2.25m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 2.1m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 2m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 1.5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.25m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.1m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 18m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 10.8m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 8.4m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 6m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 4.8m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 4.2m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 3.9m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 3.6m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 3m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 2.7m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 2.52m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 2.4m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 1.8m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.32m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.2m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 21.6m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 12.96m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 10.08m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 7.2m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 5.76m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 5.04m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 4.68m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 4.32m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 3.6m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 3.24m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 3.02m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 2.88m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 2.16m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.8m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.58m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.44m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 25.92m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 15.55m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 12.1m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 8.64m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 6.91m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 6.05m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 5.62m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 5.18m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 4.32m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 3.89m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 3.63m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 3.46m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 2.59m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 2.16m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.9m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.73m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 31.1m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 18.66m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 14.52m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 10.37m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 8.29m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 7.26m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 6.74m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 6.22m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 5.18m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 4.67m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 4.35m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 4.15m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 3.11m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 2.59m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.28m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.07m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 37.32m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 22.39m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 17.42m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 12.44m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 9.95m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 8.71m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 8.09m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 7.46m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 6.22m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 5.6m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 5.23m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 4.98m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 3.73m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 3.11m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.74m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.49m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 44.79m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 26.87m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 20.9m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 14.93m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 11.94m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 10.45m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 9.7m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 8.96m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 7.46m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 6.72m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 6.27m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 5.97m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 4.48m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 3.73m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 3.28m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.99m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 53.75m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 32.25m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 25.08m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 17.92m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 14.33m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 12.54m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 11.65m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 10.75m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 8.96m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 8.06m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 7.52m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 7.17m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 5.37m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 4.48m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 3.94m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 3.58m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 64.5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 38.7m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 30.1m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 21.5m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 17.2m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 15.05m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 13.97m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 12.9m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 10.75m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 9.67m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 9.03m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 8.6m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 6.45m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 5.37m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 4.73m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 4.3m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 77.4m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 48.37m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 39.13m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 29.02m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 24.08m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 21.82m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 20.96m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 19.99m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 17.2m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 15.96m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 15.35m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 15.05m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 11.61m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 9.94m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 8.99m, CurrencyID = 2},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 5.96m, CurrencyID = 2}, 

                #endregion
                #region EUR(CurencyID = 3)
                
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 13.5m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 8.1m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 6.3m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 4.5m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 3.6m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 3.15m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 2.93m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 2.7m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 2.25m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 2.03m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 1.89m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 1.8m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 1.35m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.13m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 0.99m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 1, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 0.9m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 16.2m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 9.72m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 7.56m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 5.4m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 4.32m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 3.78m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 3.51m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 3.24m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 2.7m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 2.43m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 2.27m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 2.16m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 1.62m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.35m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.19m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 2, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.08m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 19.44m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 11.66m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 9.07m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 6.48m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 5.18m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 4.54m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 4.21m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 3.89m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 3.24m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 2.92m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 2.72m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 2.59m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 1.94m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.62m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.43m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 3, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.3m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 23.33m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 14m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 10.89m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 7.78m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 6.22m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 5.44m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 5.05m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 4.67m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 3.89m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 3.5m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 3.27m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 3.11m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 2.33m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 1.9m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 1.71m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 4, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.56m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 27.99m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 16.8m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 13.06m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 9.33m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 7.46m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 6.53m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 6.07m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 5.6m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 4.67m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 4.2m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 3.92m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 3.73m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 2.8m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 2.33m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.05m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 5, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 1.87m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 33.59m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 20.16m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 15.68m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 11.2m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 8.96m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 7.84m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 7.28m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 6.72m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 5.6m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 5.04m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 4.7m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 4.48m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 3.36m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 2.8m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.46m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 6, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.24m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 40.31m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 24.19m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 18.81m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 13.44m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 10.75m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 9.41m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 8.73m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 8.06m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 6.72m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 6.05m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 5.64m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 5.37m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 4.03m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 3.36m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 2.96m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 7, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 2.69m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 48.37m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 29.02m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 22.57m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 16.12m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 12.9m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 11.29m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 10.48m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 9.67m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 8.06m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 7.26m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 6.77m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 6.45m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 4.84m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 4.03m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 3.55m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 8, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 3.22m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 58.05m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 34.83m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 27.09m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 19.35m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 15.48m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 13.54m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 12.58m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 11.61m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 9.67m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 8.71m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 8.13m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 7.74m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 5.8m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 4.84m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 4.26m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 9, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 3.87m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 0.00m, EndPrice = 49.99m, Oran = 69.66m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 50.00m, EndPrice = 199.99m, Oran = 43.54m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 200.00m, EndPrice = 499.99m, Oran = 35.22m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 500.00m, EndPrice = 999.99m, Oran = 26.12m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 1000.00m, EndPrice = 2499.99m, Oran = 21.67m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 2500.00m, EndPrice = 4999.99m, Oran = 19.64m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 5000.00m, EndPrice = 9999.99m, Oran = 18.87m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 10000.00m, EndPrice = 19999.99m, Oran = 17.99m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 20000.00m, EndPrice = 39999.99m, Oran = 15.48m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 40000.00m, EndPrice = 74999.99m, Oran = 14.37m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 75000.00m, EndPrice = 99999.99m, Oran = 13.82m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 100000.00m, EndPrice = 149999.99m, Oran = 13.54m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 150000.00m, EndPrice = 249999.99m, Oran = 10.45m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 250000.00m, EndPrice = 499999.99m, Oran = 8.05m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 500000.00m, EndPrice = 999999.99m, Oran = 8.09m, CurrencyID = 3},
new SegmentOran{ AddedById = 1, SegmentId = 10, StartPrice = 1000000.00m, EndPrice = 99999999.99m, Oran = 7.55m, CurrencyID = 3}, 

                #endregion
            };
            for (int i = 0; i < segmentOrans.Count; i++)
            {
                segmentOrans[i].Id = i + 1;
            }

            CustomerMainCompany mainCompany = new CustomerMainCompany()
            {
                Id = 1,
                AddedById = 1,
                Name = "Test Ana Müşterisi",
                Description = "Test Müşterisinin Ana Müşterisi (çatı firma)",
            };

            Customer customer = new Customer()
            {
                Id = 1,
                AddedById = 1,
                TypeId = 1,
                Name = "Test Müşterisi",
                Surname = "Soyad",
                TicariUnvan = "Test Ticari Ünvanı",
                CariKodu = "123",
                IsActive = true,
                SectorId = 1,
                SegmentId = 1,
                CustomerMainCompanyId = 1,
            };


            List<OrderState> orderStates = new List<OrderState>()
            {
                new OrderState
                {
                   Id = 1,
                   Description = "Test Açıklama",
                   Name = "Dönüş Bekleniyor ( Satın Alma )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 2,
                   Description = "Test Açıklama",
                   Name = "Olumsuz ( Satış )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 3,
                   Description = "Test Açıklama",
                   Name = "İptal / İade",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 4,
                   Description = "Test Açıklama",
                   Name = "Onaylandı ( Teknik )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 5,
                   Description = "Test Açıklama",
                   Name = "Teklif Verildi ( Satışçı )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 6,
                   Description = "Test Açıklama",
                   Name = "Sipariş Verildi ( Satın Alma )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 7,
                   Description = "Test Açıklama",
                   Name = "Fatura Düzenlendi ( Muhasebe )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 8,
                   Description = "Test Açıklama",
                   Name = "Kargo / Sevkiyatta ( Depo )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 9,
                   Description = "Test Açıklama",
                   Name = "Onaylandı ( Satış )",
                   AddedById = 1,
                },
                new OrderState
                {
                   Id = 10,
                   Description = "Test Açıklama",
                   Name = "Fiyat Araştırılıyor ( Satın Alma )",
                   AddedById = 1,
                },
            };



            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier
                {
                    Id=1,
                    SupplierName = "Penta",
                    DealerCode = "123",
                    AddedById = 1,
                },
                new Supplier
                {
                    Id=2,
                    SupplierName = "APC",
                    DealerCode = "1234",
                    AddedById = 1,
                },
                new Supplier
                {
                    Id=3,
                    SupplierName = "12M",
                    DealerCode = "1235",
                    AddedById = 1,
                }


            };

            List<KesinSevkiyatDurumu>? SevkiyatDurumlari = new List<KesinSevkiyatDurumu>()
            {
                new KesinSevkiyatDurumu()
                {
                    Id = 1,
                    AddedById = 1,
                    Name = "Sevkiyat",                    
                },
                new KesinSevkiyatDurumu()
                {
                    Id = 2,
                    AddedById = 1,
                    Name = "Kargo",                    
                },
                new KesinSevkiyatDurumu()
                {
                    Id = 3,
                    AddedById = 1,
                    Name = "Email",                    
                },
                new KesinSevkiyatDurumu()
                {
                    Id = 4,
                    AddedById = 1,
                    Name = "Depo",                    
                },
                new KesinSevkiyatDurumu()
                {
                    Id = 5,
                    AddedById = 1,
                    Name = "Depo Teslim",                    
                },
                new KesinSevkiyatDurumu()
                {
                    Id = 6,
                    AddedById = 1,
                    Name = "Depo Teslim",                    
                },
            };

            List<Order> orders = new List<Order>()
            {

            };




            //add entities
            modelBuilder.Entity<UserCompany>().HasData(userCompany);
            modelBuilder.Entity<AppUser>().HasData(admin);
            modelBuilder.Entity<AppIdentityRole>().HasData(sysAdminRole);
            modelBuilder.Entity<AppIdentityRoleGroup>().HasData(sysAuthorizationRoleGroup);
            modelBuilder.Entity<AppRolesOfUsers>().HasData(roleRelation);
            modelBuilder.Entity<Sector>().HasData(sector);
            modelBuilder.Entity<CustomerType>().HasData(customerTypes);
            modelBuilder.Entity<Segment>().HasData(segments);
            modelBuilder.Entity<SegmentOran>().HasData(segmentOrans);
            modelBuilder.Entity<Currency>().HasData(currencies);
            modelBuilder.Entity<CustomerMainCompany>().HasData(mainCompany);
            modelBuilder.Entity<Customer>().HasData(customer);
            modelBuilder.Entity<OrderState>().HasData(orderStates);
            modelBuilder.Entity<Supplier>().HasData(suppliers);
            modelBuilder.Entity<KesinSevkiyatDurumu>().HasData(SevkiyatDurumlari);


        }
    }

}
