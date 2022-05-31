using System;
using System.Collections.Generic;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GegiCRM.DAL.Concrete
{
    public partial class Context : IdentityDbContext<AppUser, AppIdentityRole, int>
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        #region DBSets
        public virtual DbSet<AppRolesOfUsers> AppRolesOfUsers { get; set; } = null!;
        public virtual DbSet<Announcement> Announcements { get; set; } = null!;
        public virtual DbSet<AppIdentityRole> AppIdentityRoles { get; set; } = null!;
        public virtual DbSet<AppIdentityRoleGroup> AppAuthorizationsRoleGroups { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BankInformation> BankInformations { get; set; } = null!;
        public virtual DbSet<Birim> Birims { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<CollectionReceipt> CollectionReceipts { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerMainCompany> CustomerMainCompanies { get; set; } = null!;
        public virtual DbSet<CustomerActivityLog> CustomerActivityLogs { get; set; } = null!;
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; } = null!;
        public virtual DbSet<CustomerBillingAddress> CustomerBillingAddresses { get; set; } = null!;
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
        //public virtual DbSet<CustomerDetail> CustomerDetails { get; set; } = null!;
        public virtual DbSet<CustomerRepresentetiveUser> CustomerRepresentetiveUsers { get; set; } = null!;
        public virtual DbSet<CustomerType> CustomerTypes { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentsOfUser> DepartmentsOfUsers { get; set; } = null!;
        public virtual DbSet<Deposit> Deposits { get; set; } = null!;
        public virtual DbSet<DepositRelation> DepositRelations { get; set; } = null!;
        public virtual DbSet<DepositType> DepositTypes { get; set; } = null!;
        public virtual DbSet<DiscountCupon> DiscountCupons { get; set; } = null!;
        public virtual DbSet<DiscountCuponsOfCustomer> DiscountCuponsOfCustomers { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; } = null!;
        public virtual DbSet<Expansion> Expansions { get; set; } = null!;
        public virtual DbSet<MaintenanceBill> MaintenanceBills { get; set; } = null!;
        public virtual DbSet<MaintenencePeriod> MaintenencePeriods { get; set; } = null!;
        public virtual DbSet<MarketPlace> MarketPlaces { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderState> OrderStates { get; set; } = null!;
        public virtual DbSet<OrdersCurrency> OrdersCurrencies { get; set; } = null!;
        public virtual DbSet<OrdersProduct> OrdersProducts { get; set; } = null!;
        public virtual DbSet<PaymentType> PaymentTypes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductGroup> ProductGroups { get; set; } = null!;
        public virtual DbSet<ProductGroupsFaq> ProductGroupsFaqs { get; set; } = null!;
        public virtual DbSet<ReturnAndFault> ReturnAndFaults { get; set; } = null!;
        public virtual DbSet<ReturnAndFaultState> ReturnAndFaultStates { get; set; } = null!;
        public virtual DbSet<Rule> Rules { get; set; } = null!;
        public virtual DbSet<Sector> Sectors { get; set; } = null!;
        public virtual DbSet<Segment> Segments { get; set; } = null!;
        public virtual DbSet<SegmentOran> SegmentOrans { get; set; } = null!;
        public virtual DbSet<SellsAndBuysAsset> SellsAndBuysAssets { get; set; } = null!;
        public virtual DbSet<SellsAndBuysCategory> SellsAndBuysCategories { get; set; } = null!;
        public virtual DbSet<SellsAndBuysGuideStep> SellsAndBuysGuideSteps { get; set; } = null!;
        public virtual DbSet<ServicePlace> ServicePlaces { get; set; } = null!;
        public virtual DbSet<ServiceReason> ServiceReasons { get; set; } = null!;
        public virtual DbSet<ServiceRecord> ServiceRecords { get; set; } = null!;
        public virtual DbSet<ServiceType> ServiceTypes { get; set; } = null!;
        public virtual DbSet<ShippingDeal> ShippingDeals { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SupplierDetail> SupplierDetails { get; set; } = null!;
        public virtual DbSet<SupplierPaymentState> SupplierPaymentStates { get; set; } = null!;
        public virtual DbSet<SuppliersPayment> SuppliersPayments { get; set; } = null!;
        //public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserCompany> UserCompanies { get; set; } = null!;
        public virtual DbSet<VehicleInformation> VehicleInformations { get; set; } = null!;
        public virtual DbSet<WarrantyTracking> WarrantyTrackings { get; set; } = null!;
        public virtual DbSet<WorkStandart> WorkStandarts { get; set; } = null!;
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=GegiCRM_DB;Trusted_Connection=True;");
                optionsBuilder.UseLazyLoadingProxies();
            }
            optionsBuilder.UseTriggers(triggerOptions =>
            {
                triggerOptions.AddAssemblyTriggers();
            });
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.AnnouncementsAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Announcements_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AnnouncementsModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Announcements_Users1");
            });

            modelBuilder.Entity<AppIdentityRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.AuthorizationsRoleAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authorizations_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AuthorizationsRoleModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authorizations_Users1");
            });
            modelBuilder.Entity<AppIdentityRoleGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.AppAuthorizationRoleGroupAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorizationRoleGroups_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AppAuthorizationRoleGroupModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorizationRoleGroup_ModifiedBy");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankName).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.BankAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banks_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.BankModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_Banks_Users1");
            });

            modelBuilder.Entity<BankInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.HesapNo).HasMaxLength(150);

                entity.Property(e => e.Iban)
                    .HasMaxLength(150)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Sube).HasMaxLength(250);

                entity.Property(e => e.Ttile).HasMaxLength(250);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankInformations)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankInformations_Banks");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.BankInformations)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankInformations_UserCompanies");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.BankInformationAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankInformations_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.BankInformationModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_BankInformations_Users1");
            });

            modelBuilder.Entity<Birim>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Short).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.BirimAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Birims_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.BirimModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Birims_Users1");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.BrandAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brands_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.BrandModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brands_Users1");

                entity.HasMany(d => d.Suppliers)
                    .WithMany(p => p.Brands)
                    .UsingEntity<Dictionary<string, object>>(
                        "SuppliersBrand",
                        l => l.HasOne<Supplier>().WithMany().HasForeignKey("SupplierId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SuppliersBrands_Suppliers"),
                        r => r.HasOne<Brand>().WithMany().HasForeignKey("BrandId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SuppliersBrands_Brands"),
                        j =>
                        {
                            j.HasKey("BrandId", "SupplierId");

                            j.ToTable("SuppliersBrands");

                            j.IndexerProperty<int>("BrandId").HasColumnName("BrandID");

                            j.IndexerProperty<int>("SupplierId").HasColumnName("SupplierID");
                        });
            });

            modelBuilder.Entity<CollectionReceipt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyExchange).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.KartinUstundekiIsım).HasMaxLength(150);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NameSurname).HasMaxLength(150);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CollectionReceipts)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionReceipts_Currencies");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CollectionReceipts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionReceipts_Customers");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.CollectionReceipts)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionReceipts_PaymentTypes");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CollectionReceipts)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionReceipts_Suppliers");

                entity.HasOne(d => d.AddedBy)
                  .WithMany(p => p.CollectionReceiptAddedBy)
                  .HasForeignKey(d => d.AddedById)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_CollectionReceipts_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CollectionReceiptModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_CollectionReceipts_Users1");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.CurrencyAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionReceipts_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CurrencyModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_CollectionReceipts_ModifiedBy");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CariKodu).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");


                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.TicariUnvan).HasMaxLength(250);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.CustomerAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Users1");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_Customers_Sectors");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SegmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Segments");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_CustomerTypes");

            });

            modelBuilder.Entity<CustomerMainCompany>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(250);


                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.CustomerMainCompanyAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerMainCompany_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerMainCompanyModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerMainCompany_ModifiedBy");

            });

            modelBuilder.Entity<CustomerActivityLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.CustomerActivityLogAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomersActivityLog_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerActivityLogModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomersActivityLog_ModifiedBy");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Il).HasMaxLength(50);

                entity.Property(e => e.Ilce).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.CustomerAddressAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDeliveryAddresses_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerAddresses_Customers");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerAddressModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_CustomerDeliveryAddresses_Users1");
            });

            modelBuilder.Entity<CustomerBillingAddress>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressName).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.VergiDairesi).HasMaxLength(50);

                entity.Property(e => e.VergiNo).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerBillingAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerBillingAddresses_Customers");

                entity.HasOne(d => d.AddedBy)
                  .WithMany(p => p.CustomerBillingAddressAddedBy)
                  .HasForeignKey(d => d.AddedById)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_CustomerBillingAddresses_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerBillingAddressModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_CustomerBillingAddresses_ModifiedBy");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactSurname).HasMaxLength(50);

                entity.Property(e => e.ContactTitle).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Gsm)
                    .HasMaxLength(50)
                    .HasColumnName("GSM");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.CustomerContactAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContacts_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerContacts_Customers");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerContactModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContacts_Users1");
            });


            modelBuilder.Entity<CustomerRepresentetiveUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerRepresentetiveUsers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerRepresentetiveUsers_Customers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerRepresentetiveUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerRepresentetiveUsers_Users");

                entity.HasOne(d => d.AddedBy)
                  .WithMany(p => p.CustomerRepresentetiveUserAddedBy)
                  .HasForeignKey(d => d.AddedById)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_CustomerRepresentetiveUsers_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerRepresentetiveUserModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_CustomerRepresentetiveUsers_ModifiedBy");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);


                entity.HasOne(d => d.AddedBy)
                  .WithMany(p => p.CustomerTypeAddedBy)
                  .HasForeignKey(d => d.AddedById)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_CustomerType_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.CustomerTypeModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_CustomerType_ModifiedBy");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentName).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DepartmentAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departments_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DepartmentModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_Departments_Users1");
            });

            modelBuilder.Entity<DepartmentsOfUser>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.UserId, e.DepartmentId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentsOfUsers)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentsOfUsers_Departments");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DepartmentsOfUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentsOfUsers_Users");

                entity.HasOne(d => d.AddedBy)
                  .WithMany(p => p.DepartmentsOfUsersAddedBy)
                  .HasForeignKey(d => d.AddedById)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_DepartmentsOfUsers_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DepartmentsOfUsersModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_DepartmentsOfUsers_ModifiedBy");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BitisSuresi).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DepositRelationId).HasColumnName("DepositRelationID");

                entity.Property(e => e.DepositTypeId).HasColumnName("DepositTypeID");

                entity.Property(e => e.IlgiliKisi).HasMaxLength(50);

                entity.Property(e => e.KurumAdi).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VerilisTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DepositAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deposits_Users");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deposits_Currencies");

                entity.HasOne(d => d.DepositRelation)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.DepositRelationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deposits_DepositRelations");

                entity.HasOne(d => d.DepositType)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.DepositTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deposits_DepositTypes");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DepositModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deposits_Users1");
            });

            modelBuilder.Entity<DepositRelation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DepositRelationAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositRelations_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DepositRelationModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositRelations_Users1");
            });

            modelBuilder.Entity<DepositType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DepositTypeAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositTypes_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DepositTypeModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositTypes_Users1");
            });

            modelBuilder.Entity<DiscountCupon>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CuponCode).HasMaxLength(50);

                entity.Property(e => e.CuponCurrencyId).HasColumnName("CuponCurrencyID");

                entity.Property(e => e.CuponName).HasMaxLength(50);

                entity.Property(e => e.DiscountAmountMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DiscountCuponAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCupons_Users");

                entity.HasOne(d => d.CuponCurrency)
                    .WithMany(p => p.DiscountCupons)
                    .HasForeignKey(d => d.CuponCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCupons_Currencies");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DiscountCuponModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCupons_Users1");
            });

            modelBuilder.Entity<DiscountCuponsOfCustomer>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CustomerId, e.DiscountCuponId });

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DiscountCuponId).HasColumnName("DiscountCuponID");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DiscountCuponsOfCustomerAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCuponsOfCustomers_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DiscountCuponsOfCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCuponsOfCustomers_Customers");

                entity.HasOne(d => d.DiscountCupon)
                    .WithMany(p => p.DiscountCuponsOfCustomers)
                    .HasForeignKey(d => d.DiscountCuponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCuponsOfCustomers_DiscountCupons");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DiscountCuponsOfCustomerModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCuponsOfCustomers_Users1");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.DocumentAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.DocumentModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Users1");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Documents_DocumentTypes");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.EmailTemplateAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplates_Users2");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmailTemplates)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_EmailTemplates_Departments");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.EmailTemplateModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplates_Users3");
            });

            modelBuilder.Entity<Expansion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ShortCode).HasMaxLength(10);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ExpansionAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Acilimlar_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ExpansionModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_Acilimlar_Users1");
            });

            modelBuilder.Entity<MaintenanceBill>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRepresentetiveUserId).HasColumnName("CustomerRepresentetiveUserID");

                entity.Property(e => e.MaintenencePeriodId).HasColumnName("MaintenencePeriodID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.SellingRepresentetiveUserId).HasColumnName("SellingRepresentetiveUserID");

                entity.Property(e => e.SozlesmeBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.SozlesmeBedeli).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SozlesmeBitisTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.MaintenanceBillAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceBills_Users");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MaintenanceBills)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceBills_Currencies");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MaintenanceBills)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_MaintenanceBills_Customers");

                entity.HasOne(d => d.CustomerRepresentetiveUser)
                    .WithMany(p => p.MaintenanceBillCustomerRepresentetiveUsers)
                    .HasForeignKey(d => d.CustomerRepresentetiveUserId)
                    .HasConstraintName("FK_MaintenanceBills_Users3");

                entity.HasOne(d => d.MaintenencePeriod)
                    .WithMany(p => p.MaintenanceBills)
                    .HasForeignKey(d => d.MaintenencePeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceBills_MaintenencePeriods");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MaintenanceBillModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_MaintenanceBills_Users1");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.MaintenanceBills)
                    .HasForeignKey(d => d.ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceBills_ProductCategories");

                entity.HasOne(d => d.SellingRepresentetiveUser)
                    .WithMany(p => p.MaintenanceBillSellingRepresentetiveUsers)
                    .HasForeignKey(d => d.SellingRepresentetiveUserId)
                    .HasConstraintName("FK_MaintenanceBills_Users2");
            });

            modelBuilder.Entity<MaintenencePeriod>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.MaintenencePeriodAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenencePeriods_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MaintenencePeriodModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_MaintenencePeriods_Users1");
            });

            modelBuilder.Entity<MarketPlace>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");


                entity.Property(e => e.MarketPlaceName).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.MarketPlaceAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketPlaces_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MarketPlaceModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketPlaces_Users1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OfferApprovedDate).HasColumnType("datetime");
                entity.Property(e => e.OrderApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.OrderAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.OrderModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Users1");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_OrderStates");

                entity.HasOne(d => d.RepresentetiveUser)
                    .WithMany(p => p.OrderRepresentetiveUserNavigations)
                    .HasForeignKey(d => d.RepresentetiveUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersRepresentetiveUsers");
            });

            modelBuilder.Entity<OrderState>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.OrderAndProductStateAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStates_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.OrderAndProductStateModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStates_Users1");
            });

            modelBuilder.Entity<OrdersCurrency>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrderId, e.CurrencyId });

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.OrdersCurrencies)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersCurrencies_Currencies");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersCurrencies)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersCurrencies_Orders");
            });

            modelBuilder.Entity<OrdersProduct>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrderId, e.ProductId });

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.AbonelikBaslangic).HasColumnType("datetime");

                entity.Property(e => e.AbonelikBitis).HasColumnType("datetime");

                entity.Property(e => e.Adet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BirimFiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KesinCurrencyId).HasColumnName("KesinCurrencyID");

                entity.Property(e => e.KesinFiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KesinSevkTarihi).HasColumnType("datetime");

                entity.Property(e => e.KesinSupplierId).HasColumnName("KesinSupplierID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductStateId).HasColumnName("ProductStateID");

                entity.Property(e => e.ReferanceCode).HasMaxLength(50);

                entity.Property(e => e.ReferansBirimFiyat)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ReferansCurrencyId).HasColumnName("ReferansCurrencyID");

                entity.Property(e => e.ReferansSupplierId).HasColumnName("ReferansSupplierID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.OrdersProductAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_Users");

                entity.HasOne(d => d.Birim)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.BirimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_Birims");

                entity.HasOne(d => d.KesinCurrency)
                    .WithMany(p => p.OrdersProductKesinCurrencies)
                    .HasForeignKey(d => d.KesinCurrencyId)
                    .HasConstraintName("FK_OrdersProducts_Currencies");

                entity.HasOne(d => d.KesinSupplier)
                    .WithMany(p => p.OrdersProductKesinSuppliers)
                    .HasForeignKey(d => d.KesinSupplierId)
                    .HasConstraintName("FK_OrdersProducts_Suppliers");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.OrdersProductModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_Users1");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_Products");

                entity.HasOne(d => d.ReferansCurrency)
                    .WithMany(p => p.OrdersProductReferansCurrencies)
                    .HasForeignKey(d => d.ReferansCurrencyId)
                    .HasConstraintName("FK_OrdersProducts_Currencies1");

                entity.HasOne(d => d.ReferansSupplier)
                    .WithMany(p => p.OrdersProductReferansSuppliers)
                    .HasForeignKey(d => d.ReferansSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_Suppliers1");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.PaymentTypeAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentTypes_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.PaymentTypeModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_PaymentTypes_Users1");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KdvOrani).HasDefaultValueSql("((18))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PorductBrandId).HasColumnName("PorductBrandID");

                entity.Property(e => e.ProductDescription).HasMaxLength(50);

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ProductAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OurServices_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ProductModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OurServices_Users1");

                entity.HasOne(d => d.PorductBrand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PorductBrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Brands");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductGroupId)
                    .HasConstraintName("FK_OurServices_ServiceCategories");

                entity.HasMany(d => d.Suppliers)
                    .WithMany(p => p.Products)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductsOfSupplier",
                        l => l.HasOne<Supplier>().WithMany().HasForeignKey("SupplierId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductsOfSuppliers_Suppliers"),
                        r => r.HasOne<Product>().WithMany().HasForeignKey("ProductId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductsOfSuppliers_Products"),
                        j =>
                        {
                            j.HasKey("ProductId", "SupplierId");

                            j.ToTable("ProductsOfSuppliers");

                            j.IndexerProperty<int>("ProductId").HasColumnName("ProductID");

                            j.IndexerProperty<int>("SupplierId").HasColumnName("SupplierID");
                        });
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");


                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductCategoryName).HasMaxLength(250);

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ProductCategoryAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSubCategories_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ProductCategoryModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSubCategories_Users1");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSubCategories_ProductCategories");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupName).HasMaxLength(150);


                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ProductGroupAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategories_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ProductGroupModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategories_Users1");
            });

            modelBuilder.Entity<ProductGroupsFaq>(entity =>
            {
                entity.ToTable("ProductGroupsFAQs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ProductGroupsFaqAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategoriesFAQs_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ProductGroupsFaqModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ProductCategoriesFAQs_Users1");

                entity.HasOne(d => d.ProductGroup)
                    .WithMany(p => p.ProductGroupsFaqs)
                    .HasForeignKey(d => d.ProductGroupId)
                    .HasConstraintName("FK_ProductCategoriesFAQs_ProductCategories");
            });

            modelBuilder.Entity<ReturnAndFault>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlannedDeadline).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ReturnAndFaultAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnAndFaults_Users");

                entity.HasOne(d => d.CurrentState)
                    .WithMany(p => p.ReturnAndFaults)
                    .HasForeignKey(d => d.CurrentStateId)
                    .HasConstraintName("FK_ReturnAndFaults_ReturnAndFaultStates");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ReturnAndFaultModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ReturnAndFaults_Users1");

                entity.HasOne(d => d.RepresentitveUserNavigation)
                    .WithMany(p => p.ReturnAndFaultRepresentitveUserNavigations)
                    .HasForeignKey(d => d.RepresentitveUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnAndFaults_Users2");
            });

            modelBuilder.Entity<ReturnAndFaultState>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatDescription).HasMaxLength(50);

                entity.Property(e => e.StatName).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ReturnAndFaultStateAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnAndFaultStates_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ReturnAndFaultStateModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ReturnAndFaultStates_Users1");
            });

            modelBuilder.Entity<Rule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RuleName).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.RuleAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rules_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.RuleModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rules_Users1");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(250);


                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SectorAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sector_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SectorModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sector_ModidfiedBy");
            });

            modelBuilder.Entity<Segment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SegmentAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Segments_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SegmentModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Segments_Users1");
            });

            modelBuilder.Entity<SegmentOran>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Oran, e.CurrencyID });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oran).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.StartPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SegmentOranAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegmentOrans_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SegmentOranModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegmentOrans_Users1");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.SegmentOrans)
                    .HasForeignKey(d => d.SegmentId)
                    .HasConstraintName("FK_SegmentOrans_Segments");
            });

            modelBuilder.Entity<SellsAndBuysAsset>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentStepId).HasColumnName("CurrentStepID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SabcategoryId).HasColumnName("SABCategoryID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SellsAndBuysAssetAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysAssets_Users");

                entity.HasOne(d => d.CurrentStep)
                    .WithMany(p => p.SellsAndBuysAssets)
                    .HasForeignKey(d => d.CurrentStepId)
                    .HasConstraintName("FK_SellsAndBuysAssets_SellsAndBuysGuideSteps");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SellsAndBuysAssetModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysAssets_Users1");

                entity.HasOne(d => d.Sabcategory)
                    .WithMany(p => p.SellsAndBuysAssets)
                    .HasForeignKey(d => d.SabcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysAssets_SellsAndBuysCategories");
            });

            modelBuilder.Entity<SellsAndBuysCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SellsAndBuysCategoryAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysCategories_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SellsAndBuysCategoryModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysCategories_Users1");
            });

            modelBuilder.Entity<SellsAndBuysGuideStep>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SabcategoryId).HasColumnName("SABCategoryID");

                entity.Property(e => e.StepName).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SellsAndBuysGuideStepAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysGuideSteps_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SellsAndBuysGuideStepModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysGuideSteps_Users1");

                entity.HasOne(d => d.Sabcategory)
                    .WithMany(p => p.SellsAndBuysGuideSteps)
                    .HasForeignKey(d => d.SabcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysGuideSteps_SellsAndBuysCategories");
            });

            modelBuilder.Entity<ServicePlace>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ServicePlaceAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicePlaces_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ServicePlaceModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ServicePlaces_Users1");
            });

            modelBuilder.Entity<ServiceReason>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ServiceReasonAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceReasons_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ServiceReasonModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ServiceReasons_Users1");
            });

            modelBuilder.Entity<ServiceRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceBeginDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceEndDate).HasColumnType("datetime");

                entity.Property(e => e.ServicePlaceId).HasColumnName("ServicePlaceID");

                entity.Property(e => e.ServiceReasonId).HasColumnName("ServiceReasonID");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ServiceRecordAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ServiceRecords)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_Customers");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ServiceRecordModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ServiceRecords_Users1");

                entity.HasOne(d => d.ServicePersonalUserNavigation)
                    .WithMany(p => p.ServiceRecordServicePersonalUserNavigations)
                    .HasForeignKey(d => d.ServicePersonalUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_Users2");

                entity.HasOne(d => d.ServicePlace)
                    .WithMany(p => p.ServiceRecords)
                    .HasForeignKey(d => d.ServicePlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_ServicePlaces");

                entity.HasOne(d => d.ServiceReason)
                    .WithMany(p => p.ServiceRecords)
                    .HasForeignKey(d => d.ServiceReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_ServiceReasons");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.ServiceRecords)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_ServiceTypes");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ServiceTypeAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTypes_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ServiceTypeModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_ServiceTypes_Users1");
            });

            modelBuilder.Entity<ShippingDeal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ShippingDeals)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShippingDeals_UserCompanies");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealerCode).HasMaxLength(50);


                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OncelikSirasi).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SupplierAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suppliers_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SupplierModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suppliers_Users1");

                entity.HasMany(d => d.MarketPlaces)
                    .WithMany(p => p.Suppliers)
                    .UsingEntity<Dictionary<string, object>>(
                        "MarketPlacesOfSupplier",
                        l => l.HasOne<MarketPlace>().WithMany().HasForeignKey("MarketPlaceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MarketPlacesOfSuppliers_MarketPlaces"),
                        r => r.HasOne<Supplier>().WithMany().HasForeignKey("SupplierId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MarketPlacesOfSuppliers_Suppliers"),
                        j =>
                        {
                            j.HasKey("SupplierId", "MarketPlaceId");

                            j.ToTable("MarketPlacesOfSuppliers");

                            j.IndexerProperty<int>("SupplierId").HasColumnName("SupplierID");

                            j.IndexerProperty<int>("MarketPlaceId").HasColumnName("MarketPlaceID");
                        });

                entity.HasMany(d => d.ProductGroups)
                    .WithMany(p => p.Suppliers)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductGroupsOfSupplier",
                        l => l.HasOne<ProductGroup>().WithMany().HasForeignKey("ProductGroupId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductCategoriesSuppliers_ProductCategories"),
                        r => r.HasOne<Supplier>().WithMany().HasForeignKey("SupplierId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductCategoriesSuppliers_Suppliers"),
                        j =>
                        {
                            j.HasKey("SupplierId", "ProductGroupId").HasName("PK_ProductCategoriesSuppliers");

                            j.ToTable("ProductGroupsOfSuppliers");

                            j.IndexerProperty<int>("SupplierId").HasColumnName("SupplierID");

                            j.IndexerProperty<int>("ProductGroupId").HasColumnName("ProductGroupID");
                        });
            });

            modelBuilder.Entity<SupplierDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArizaKargoUcreti).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Dahili).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.GonderiTuru).HasMaxLength(50);

                entity.Property(e => e.Gsm)
                    .HasMaxLength(50)
                    .HasColumnName("GSM");

                entity.Property(e => e.IadeKargoUcreti).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsTel).HasMaxLength(50);

                entity.Property(e => e.KargoBedeli).HasMaxLength(50);

                entity.Property(e => e.KargoBedeliSatisSiniri).HasMaxLength(50);

                entity.Property(e => e.MusteriTemsilcisi).HasMaxLength(50);

                entity.Property(e => e.OdemeSekli).HasMaxLength(50);

                entity.Property(e => e.Sevkiyat).HasMaxLength(50);

                entity.Property(e => e.SiparisSiniri).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SıparisSaati).HasColumnType("datetime");

                entity.Property(e => e.Vade).HasMaxLength(50);

                entity.Property(e => e.YetkiliKisi).HasMaxLength(50);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SupplierDetails)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierDetails_Currencies");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierDetails_Suppliers1");
            });

            modelBuilder.Entity<SupplierPaymentState>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(250);


                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SupplierPaymentStateAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierPaymentStates_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SupplierPaymentStateModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierPaymentStates_Users1");
            });

            modelBuilder.Entity<SuppliersPayment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OdemeTutari).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentOfficerUserId).HasColumnName("PaymentOfficerUserID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.SuppliersPaymentAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliersPayments_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.SuppliersPaymentModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliersPayments_Users1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SuppliersPayments)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliersPayments_SupplierPaymentStatuses");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UserCompanyId).HasColumnName("UserCompanyID");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.InverseAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.InverseModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_Users_Users1");

                entity.HasOne(d => d.UserCompany)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserCompanies");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FaliyetKodu).HasMaxLength(150);

                entity.Property(e => e.Fatura).HasMaxLength(250);

                entity.Property(e => e.KepAdresi).HasMaxLength(150);

                entity.Property(e => e.MersisNo).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.TicaretSicilNo).HasMaxLength(250);

                //entity.HasOne(d => d.AddedBy)
                //    .WithMany(p => p.AppRolesOfUsersAddedBy)
                //    .HasForeignKey(d => d.AddedById)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_UsersAuthorizations_AddedBy");

                //entity.HasOne(d => d.ModifiedBy)
                //    .WithMany(p => p.AppRolesOfUsersModifiedBy)
                //    .HasForeignKey(d => d.ModifiedById)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_UsersAuthorizations_ModifiedBy");


                entity.HasOne(a => a.AddedBy)
                    .WithMany(a => a.UserCompanyAddedBy)
                    .HasForeignKey(k => k.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanies_AddedBy");

                entity.HasOne(a => a.ModifiedBy)
                    .WithMany(a => a.UserCompanyModifiedBy)
                    .HasForeignKey(k => k.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanies_ModifiedBy");

            });

            modelBuilder.Entity<AppRolesOfUsers>(entity =>
            {

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.AppRolesOfUsersAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAuthorizations_AddedBy");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AppRolesOfUsersModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAuthorizations_ModifiedBy");
            });

            modelBuilder.Entity<VehicleInformation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.BakimKmperiod).HasColumnName("BakimKMPeriod");

                entity.Property(e => e.BazKm).HasColumnName("BazKM");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GelecekMuayeneTarihi).HasColumnType("datetime");

                entity.Property(e => e.K2belgesiBitisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("K2BelgesiBitisTarihi");

                entity.Property(e => e.KaskoPoliceBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.KiraBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.KiraToplamKmtaahhut).HasColumnName("KiraToplamKMTaahhut");

                entity.Property(e => e.KisLastigiDegisimTarihi).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Plaka).HasMaxLength(50);

                entity.Property(e => e.SonBakimKm).HasColumnName("SonBakimKM");

                entity.Property(e => e.SonBakimTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonOkunanKm).HasColumnName("SonOkunanKM");

                entity.Property(e => e.SonOkunanKmtarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("SonOkunanKMTarihi");

                entity.Property(e => e.SonrakiBakimTarihi).HasColumnType("datetime");

                entity.Property(e => e.TakipCihaziYenilemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.TescilTarihi).HasColumnType("datetime");

                entity.Property(e => e.TrafikSigPoliceBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.UserCompanyId).HasColumnName("UserCompanyID");

                entity.Property(e => e.YazLastigiDegisimTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.VehicleInformationAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleInformations_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.VehicleInformationModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleInformations_Users1");

                entity.HasOne(d => d.UserCompany)
                    .WithMany(p => p.VehicleInformations)
                    .HasForeignKey(d => d.UserCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleInformations_UserCompanies");
            });

            modelBuilder.Entity<WarrantyTracking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.WarrantyTrackingAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarrantyTrackings_Users");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.WarrantyTrackings)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarrantyTrackings_Brands");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.WarrantyTrackingModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_WarrantyTrackings_Users1");
            });

            modelBuilder.Entity<WorkStandart>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationCalendar).HasColumnType("datetime");

                entity.Property(e => e.AvalibleHours).HasMaxLength(150);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Period).HasMaxLength(250);

                entity.Property(e => e.WorkTime).HasMaxLength(150);

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.WorkStandartAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkStandarts_Users");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.WorkStandarts)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkStandarts_Departments");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.WorkStandartModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("FK_WorkStandarts_Users1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.EnableAutoHistory();
        }
    }
}
