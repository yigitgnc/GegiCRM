using System;
using System.Collections.Generic;
using GegiCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GegiCRM.DAL.Concrete
{
    public partial class GegiCRM_DBContext : DbContext
    {
        public GegiCRM_DBContext()
        {
        }

        public GegiCRM_DBContext(DbContextOptions<GegiCRM_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthorizationsRole> AuthorizationsRoles { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BankInformation> BankInformations { get; set; } = null!;
        public virtual DbSet<Birim> Birims { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<CollectionReceipt> CollectionReceipts { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; } = null!;
        public virtual DbSet<CustomerBillingAddress> CustomerBillingAddresses { get; set; } = null!;
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; } = null!;
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
        public virtual DbSet<OrderAndProductState> OrderAndProductStates { get; set; } = null!;
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
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserCompany> UserCompanies { get; set; } = null!;
        public virtual DbSet<UsersAuthorizationRole> UsersAuthorizationRoles { get; set; } = null!;
        public virtual DbSet<VehicleInformation> VehicleInformations { get; set; } = null!;
        public virtual DbSet<WarrantyTracking> WarrantyTrackings { get; set; } = null!;
        public virtual DbSet<WorkStandart> WorkStandarts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=GegiCRM_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorizationsRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.AuthorizationsRoleAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authorizations_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AuthorizationsRoleModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authorizations_Users1");
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.BankAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banks_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BankModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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
            });

            modelBuilder.Entity<Birim>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Short).HasMaxLength(50);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.BirimAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Birims_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BirimModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.BrandAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brands_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BrandModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);
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

                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.TicariUnvan).HasMaxLength(250);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.CustomerAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.CustomerAddressAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDeliveryAddresses_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerAddresses_Customers");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerAddressModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.CustomerContactAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContacts_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerContacts_Customers");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerContactModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContacts_Users1");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CustomerDetails)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDetails_Currencies");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDetails_Customers");
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
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DepartmentAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departments_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepartmentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Departments_Users1");
            });

            modelBuilder.Entity<DepartmentsOfUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DepartmentId });

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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DepositAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
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

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepositModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DepositRelationAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositRelations_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepositRelationModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DepositTypeAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositTypes_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepositTypeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DiscountCuponAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCupons_Users");

                entity.HasOne(d => d.CuponCurrency)
                    .WithMany(p => p.DiscountCupons)
                    .HasForeignKey(d => d.CuponCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCupons_Currencies");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DiscountCuponModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCupons_Users1");
            });

            modelBuilder.Entity<DiscountCuponsOfCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.DiscountCuponId });

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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DiscountCuponsOfCustomerAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
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

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DiscountCuponsOfCustomerModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.DocumentAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocumentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.EmailTemplateAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplates_Users2");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmailTemplates)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_EmailTemplates_Departments");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmailTemplateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ExpansionAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Acilimlar_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ExpansionModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.MaintenanceBillAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
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

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MaintenanceBillModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.MaintenencePeriodAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenencePeriods_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MaintenencePeriodModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_MaintenencePeriods_Users1");
            });

            modelBuilder.Entity<MarketPlace>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketPlaceName).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.MarketPlaceAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketPlaces_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MarketPlaceModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketPlaces_Users1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.OrderAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrderModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Users1");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_OrderStates");
            });

            modelBuilder.Entity<OrderAndProductState>(entity =>
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.OrderAndProductStateAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStates_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrderAndProductStateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStates_Users1");
            });

            modelBuilder.Entity<OrdersCurrency>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.CurrencyId });

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

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
                entity.HasKey(e => new { e.OrderId, e.ProductId });

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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.OrdersProductAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
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

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrdersProductModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.ProductState)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.ProductStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersProducts_OrderAndProductStates");

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
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.PaymentTypeAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentTypes_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PaymentTypeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ProductAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OurServices_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductCategoryName).HasMaxLength(250);

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ProductCategoryAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSubCategories_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductCategoryModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ProductGroupAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategories_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductGroupModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ProductGroupsFaqAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategoriesFAQs_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductGroupsFaqModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ReturnAndFaultAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnAndFaults_Users");

                entity.HasOne(d => d.CurrentState)
                    .WithMany(p => p.ReturnAndFaults)
                    .HasForeignKey(d => d.CurrentStateId)
                    .HasConstraintName("FK_ReturnAndFaults_ReturnAndFaultStates");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ReturnAndFaultModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ReturnAndFaultStateAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnAndFaultStates_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ReturnAndFaultStateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.RuleAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rules_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RuleModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SegmentAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Segments_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SegmentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Segments_Users1");
            });

            modelBuilder.Entity<SegmentOran>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EuroOran).HasColumnName("EURO_ORAN");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.StartPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TlOran).HasColumnName("TL_ORAN");

                entity.Property(e => e.UsdOran).HasColumnName("USD_ORAN");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SegmentOranAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegmentOrans_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SegmentOranModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SellsAndBuysAssetAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysAssets_Users");

                entity.HasOne(d => d.CurrentStep)
                    .WithMany(p => p.SellsAndBuysAssets)
                    .HasForeignKey(d => d.CurrentStepId)
                    .HasConstraintName("FK_SellsAndBuysAssets_SellsAndBuysGuideSteps");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SellsAndBuysAssetModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SellsAndBuysCategoryAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysCategories_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SellsAndBuysCategoryModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SellsAndBuysGuideStepAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellsAndBuysGuideSteps_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SellsAndBuysGuideStepModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ServicePlaceAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicePlaces_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ServicePlaceModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ServiceReasonAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceReasons_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ServiceReasonModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ServiceRecordAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_Users");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ServiceRecords)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecords_Customers");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ServiceRecordModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.ServiceTypeAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTypes_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ServiceTypeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OncelikSirasi).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SupplierAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suppliers_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SupplierModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SupplierPaymentStateAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierPaymentStates_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SupplierPaymentStateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.SuppliersPaymentAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliersPayments_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SuppliersPaymentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliersPayments_Users1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SuppliersPayments)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuppliersPayments_SupplierPaymentStatuses");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PassHash).HasMaxLength(250);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UserCompanyId).HasColumnName("UserCompanyID");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.InverseAddedByNavigation)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.UserCompanyAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCompanies_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.UserCompanyModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_UserCompanies_Users1");
            });

            modelBuilder.Entity<UsersAuthorizationRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AuthorizationRoleId })
                    .HasName("PK_UsersAuthorizations");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AuthorizationRoleId).HasColumnName("AuthorizationRoleID");

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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.UsersAuthorizationRoleAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAuthorizations_Users1");

                entity.HasOne(d => d.AuthorizationRole)
                    .WithMany(p => p.UsersAuthorizationRoles)
                    .HasForeignKey(d => d.AuthorizationRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAuthorizations_Authorizations");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.UsersAuthorizationRoleModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAuthorizations_Users2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersAuthorizationRoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAuthorizations_Users");
            });

            modelBuilder.Entity<VehicleInformation>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.VehicleInformationAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleInformations_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.VehicleInformationModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.WarrantyTrackingAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarrantyTrackings_Users");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.WarrantyTrackings)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarrantyTrackings_Brands");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WarrantyTrackingModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
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

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.WorkStandartAddedByNavigations)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkStandarts_Users");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.WorkStandarts)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkStandarts_Departments");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WorkStandartModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_WorkStandarts_Users1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
