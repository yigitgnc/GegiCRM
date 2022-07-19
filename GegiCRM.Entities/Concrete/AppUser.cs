using GegiCRM.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GegiCRM.Entities.Concrete
{
    public partial class AppUser : IdentityUser<int>, IBaseEntity<int>
    {
        public AppUser()
        {
            AppRolesOfUsersAddedBy = new HashSet<AppRolesOfUsers>();
            AppRolesOfUsersModifiedBy = new HashSet<AppRolesOfUsers>();
            AppAuthorizationRoleGroupAddedBy = new HashSet<AppIdentityRoleGroup>();
            AppAuthorizationRoleGroupModifiedBy = new HashSet<AppIdentityRoleGroup>();
            //AppUsersAuthorizationRoleUsers = new HashSet<AppUsersAuthorizationRole>();
            AuthorizationsRoleAddedBy = new HashSet<AppIdentityRole>();
            AuthorizationsRoleModifiedBy = new HashSet<AppIdentityRole>();
            BankAddedBy = new HashSet<Bank>();
            BankModifiedBy = new HashSet<Bank>();
            BankInformationAddedBy = new HashSet<BankInformation>();
            BankInformationModifiedBy = new HashSet<BankInformation>();
            BirimAddedBy = new HashSet<Birim>();
            BirimModifiedBy = new HashSet<Birim>();
            BrandAddedBy = new HashSet<Brand>();
            BrandModifiedBy = new HashSet<Brand>();
            CustomerTypeAddedBy = new HashSet<CustomerType>();
            CustomerTypeModifiedBy = new HashSet<CustomerType>();
            CustomerAddedBy = new HashSet<Customer>();
            CustomerModifiedBy = new HashSet<Customer>();
            CustomerMainCompanyAddedBy = new HashSet<CustomerMainCompany>();
            CustomerMainCompanyModifiedBy = new HashSet<CustomerMainCompany>();
            OrderRepresentetiveUserNavigations = new HashSet<Order>();
            CustomerActivityLogAddedBy = new HashSet<CustomerActivityLog>();
            CustomerActivityLogModifiedBy = new HashSet<CustomerActivityLog>();
            CustomerAddressAddedBy = new HashSet<CustomerAddress>();
            CustomerAddressModifiedBy = new HashSet<CustomerAddress>();
            CustomerContactAddedBy = new HashSet<CustomerContact>();
            CustomerContactModifiedBy = new HashSet<CustomerContact>();
            CustomerRepresentetiveUsers = new HashSet<CustomerRepresentetiveUser>();
            DepartmentAddedBy = new HashSet<Department>();
            DepartmentModifiedBy = new HashSet<Department>();
            DepartmentsOfUsers = new HashSet<DepartmentsOfUser>();
            DepositAddedBy = new HashSet<Deposit>();
            DepositModifiedBy = new HashSet<Deposit>();
            DepositRelationAddedBy = new HashSet<DepositRelation>();
            DepositRelationModifiedBy = new HashSet<DepositRelation>();
            DepositTypeAddedBy = new HashSet<DepositType>();
            DepositTypeModifiedBy = new HashSet<DepositType>();
            DiscountCuponAddedBy = new HashSet<DiscountCupon>();
            DiscountCuponModifiedBy = new HashSet<DiscountCupon>();
            DiscountCuponsOfCustomerAddedBy = new HashSet<DiscountCuponsOfCustomer>();
            DiscountCuponsOfCustomerModifiedBy = new HashSet<DiscountCuponsOfCustomer>();
            DocumentAddedBy = new HashSet<Document>();
            DocumentModifiedBy = new HashSet<Document>();
            EmailTemplateAddedBy = new HashSet<EmailTemplate>();
            EmailTemplateModifiedBy = new HashSet<EmailTemplate>();
            ExpansionAddedBy = new HashSet<Expansion>();
            ExpansionModifiedBy = new HashSet<Expansion>();
            InverseAddedBy = new HashSet<AppUser>();
            InverseModifiedBy = new HashSet<AppUser>();
            MaintenanceBillAddedBy = new HashSet<MaintenanceBill>();
            MaintenanceBillCustomerRepresentetiveUsers = new HashSet<MaintenanceBill>();
            MaintenanceBillModifiedBy = new HashSet<MaintenanceBill>();
            MaintenanceBillSellingRepresentetiveUsers = new HashSet<MaintenanceBill>();
            MaintenencePeriodAddedBy = new HashSet<MaintenencePeriod>();
            MaintenencePeriodModifiedBy = new HashSet<MaintenencePeriod>();
            MarketPlaceAddedBy = new HashSet<MarketPlace>();
            MarketPlaceModifiedBy = new HashSet<MarketPlace>();
            OrderAddedBy = new HashSet<Order>();
            OrderAndProductStateAddedBy = new HashSet<OrderState>();
            OrderAndProductStateModifiedBy = new HashSet<OrderState>();
            OrderModifiedBy = new HashSet<Order>();
            OrdersProductAddedBy = new HashSet<OrdersProduct>();
            OrdersProductModifiedBy = new HashSet<OrdersProduct>();
            PaymentTypeAddedBy = new HashSet<PaymentType>();
            PaymentTypeModifiedBy = new HashSet<PaymentType>();
            ProductAddedBy = new HashSet<Product>();
            ProductCategoryAddedBy = new HashSet<ProductCategory>();
            ProductCategoryModifiedBy = new HashSet<ProductCategory>();
            ProductGroupAddedBy = new HashSet<ProductGroup>();
            ProductGroupModifiedBy = new HashSet<ProductGroup>();
            ProductGroupsFaqAddedBy = new HashSet<ProductGroupsFaq>();
            ProductGroupsFaqModifiedBy = new HashSet<ProductGroupsFaq>();
            ProductModifiedBy = new HashSet<Product>();
            ReturnAndFaultAddedBy = new HashSet<ReturnAndFault>();
            ReturnAndFaultModifiedBy = new HashSet<ReturnAndFault>();
            ReturnAndFaultRepresentitveUserNavigations = new HashSet<ReturnAndFault>();
            ReturnAndFaultStateAddedBy = new HashSet<ReturnAndFaultState>();
            ReturnAndFaultStateModifiedBy = new HashSet<ReturnAndFaultState>();
            RuleAddedBy = new HashSet<Rule>();
            RuleModifiedBy = new HashSet<Rule>();
            SegmentAddedBy = new HashSet<Segment>();
            SegmentModifiedBy = new HashSet<Segment>();
            SectorAddedBy = new HashSet<Sector>();
            SectorModifiedBy = new HashSet<Sector>();
            SegmentOranAddedBy = new HashSet<SegmentOran>();
            SegmentOranModifiedBy = new HashSet<SegmentOran>();
            SellsAndBuysAssetAddedBy = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysAssetModifiedBy = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysCategoryAddedBy = new HashSet<SellsAndBuysCategory>();
            SellsAndBuysCategoryModifiedBy = new HashSet<SellsAndBuysCategory>();
            SellsAndBuysGuideStepAddedBy = new HashSet<SellsAndBuysGuideStep>();
            SellsAndBuysGuideStepModifiedBy = new HashSet<SellsAndBuysGuideStep>();
            ServicePlaceAddedBy = new HashSet<ServicePlace>();
            ServicePlaceModifiedBy = new HashSet<ServicePlace>();
            ServiceReasonAddedBy = new HashSet<ServiceReason>();
            ServiceReasonModifiedBy = new HashSet<ServiceReason>();
            ServiceRecordAddedBy = new HashSet<ServiceRecord>();
            ServiceRecordModifiedBy = new HashSet<ServiceRecord>();
            ServiceRecordServicePersonalUserNavigations = new HashSet<ServiceRecord>();
            ServiceTypeAddedBy = new HashSet<ServiceType>();
            ServiceTypeModifiedBy = new HashSet<ServiceType>();
            SupplierAddedBy = new HashSet<Supplier>();
            SupplierModifiedBy = new HashSet<Supplier>();
            SupplierPaymentStateAddedBy = new HashSet<SupplierPaymentState>();
            SupplierPaymentStateModifiedBy = new HashSet<SupplierPaymentState>();
            SuppliersPaymentAddedBy = new HashSet<SuppliersPayment>();
            SuppliersPaymentModifiedBy = new HashSet<SuppliersPayment>();
            UserCompanyAddedBy = new HashSet<UserCompany>();
            UserCompanyModifiedBy = new HashSet<UserCompany>();
            VehicleInformationAddedBy = new HashSet<VehicleInformation>();
            VehicleInformationModifiedBy = new HashSet<VehicleInformation>();
            WarrantyTrackingAddedBy = new HashSet<WarrantyTracking>();
            WarrantyTrackingModifiedBy = new HashSet<WarrantyTracking>();
            WorkStandartAddedBy = new HashSet<WorkStandart>();
            WorkStandartModifiedBy = new HashSet<WorkStandart>();
            UserActivityLogs = new HashSet<UserDailyActivityLog>();
            UsersSendedMessages = new HashSet<UserMessage>();
            UsersRecievedMessages = new HashSet<UserMessage>();
        }


        public int UserCompanyId { get; set; }
        //public string Email { get; set; } = null!;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedById { get; set; }
        public int? ModifiedById { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsOnline { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? SignalrConnectionId { get; set; }

        #region virtuals
        public virtual UserCompany UserCompany { get; set; } = null!;
        public virtual ICollection<Announcement> AnnouncementsAddedBy { get; set; }
        public virtual ICollection<Announcement> AnnouncementsModifiedBy { get; set; }
        public virtual ICollection<AppRolesOfUsers>? AppRolesOfUsersAddedBy { get; set; }
        public virtual ICollection<AppRolesOfUsers> AppRolesOfUsersModifiedBy { get; set; }
        public virtual ICollection<AppIdentityRoleGroup>? AppAuthorizationRoleGroupAddedBy { get; set; }
        public virtual ICollection<AppIdentityRoleGroup> AppAuthorizationRoleGroupModifiedBy { get; set; }
        //public virtual ICollection<AppAppUsersAuthorizationRole> AppUsersAuthorizationRoleUsers { get; set; } 
        public virtual ICollection<AppIdentityRole> AuthorizationsRoleAddedBy { get; set; }
        public virtual ICollection<AppIdentityRole> AuthorizationsRoleModifiedBy { get; set; }
        public virtual ICollection<Bank> BankAddedBy { get; set; }
        public virtual ICollection<Bank> BankModifiedBy { get; set; }
        public virtual ICollection<BankInformation> BankInformationAddedBy { get; set; }
        public virtual ICollection<BankInformation> BankInformationModifiedBy { get; set; }
        public virtual ICollection<Birim> BirimAddedBy { get; set; }
        public virtual ICollection<Birim> BirimModifiedBy { get; set; }
        public virtual ICollection<Brand> BrandAddedBy { get; set; }
        public virtual ICollection<Brand> BrandModifiedBy { get; set; }
        public virtual ICollection<CollectionReceipt> CollectionReceiptAddedBy { get; set; }
        public virtual ICollection<CollectionReceipt> CollectionReceiptModifiedBy { get; set; }
        public virtual ICollection<Currency> CurrencyAddedBy { get; set; }
        public virtual ICollection<Currency> CurrencyModifiedBy { get; set; }
        public virtual ICollection<CustomerType> CustomerTypeAddedBy { get; set; }
        public virtual ICollection<CustomerType> CustomerTypeModifiedBy { get; set; }
        public virtual ICollection<Customer> CustomerAddedBy { get; set; }
        public virtual ICollection<Customer> CustomerModifiedBy { get; set; }
        public virtual ICollection<CustomerMainCompany> CustomerMainCompanyAddedBy { get; set; }
        public virtual ICollection<CustomerMainCompany> CustomerMainCompanyModifiedBy { get; set; }
        public virtual ICollection<Order> OrderRepresentetiveUserNavigations { get; set; }
        public virtual ICollection<CustomerActivityLog> CustomerActivityLogAddedBy { get; set; }
        public virtual ICollection<CustomerActivityLog> CustomerActivityLogModifiedBy { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressAddedBy { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressModifiedBy { get; set; }
        public virtual ICollection<CustomerBillingAddress> CustomerBillingAddressAddedBy { get; set; }
        public virtual ICollection<CustomerBillingAddress> CustomerBillingAddressModifiedBy { get; set; }
        public virtual ICollection<CustomerContact> CustomerContactAddedBy { get; set; }
        public virtual ICollection<CustomerContact> CustomerContactModifiedBy { get; set; }
        //public virtual ICollection<CustomerDetail> CustomerDetailAddedBy { get; set; }
        //public virtual ICollection<CustomerDetail> CustomerDetailModifiedBy { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUserAddedBy { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUserModifiedBy { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUsers { get; set; }
        public virtual ICollection<Department> DepartmentAddedBy { get; set; }
        public virtual ICollection<Department> DepartmentModifiedBy { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsers { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsersAddedBy { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsersModifiedBy { get; set; }
        public virtual ICollection<Deposit> DepositAddedBy { get; set; }
        public virtual ICollection<Deposit> DepositModifiedBy { get; set; }
        public virtual ICollection<DepositRelation> DepositRelationAddedBy { get; set; }
        public virtual ICollection<DepositRelation> DepositRelationModifiedBy { get; set; }
        public virtual ICollection<DepositType> DepositTypeAddedBy { get; set; }
        public virtual ICollection<DepositType> DepositTypeModifiedBy { get; set; }
        public virtual ICollection<DiscountCupon> DiscountCuponAddedBy { get; set; }
        public virtual ICollection<DiscountCupon> DiscountCuponModifiedBy { get; set; }
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomerAddedBy { get; set; }
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomerModifiedBy { get; set; }
        public virtual ICollection<Document> DocumentAddedBy { get; set; }
        public virtual ICollection<Document> DocumentModifiedBy { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplateAddedBy { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplateModifiedBy { get; set; }
        public virtual ICollection<Expansion> ExpansionAddedBy { get; set; }
        public virtual ICollection<Expansion> ExpansionModifiedBy { get; set; }
        public virtual ICollection<AppUser> InverseAddedBy { get; set; }
        public virtual ICollection<AppUser> InverseModifiedBy { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillAddedBy { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillCustomerRepresentetiveUsers { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillModifiedBy { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillSellingRepresentetiveUsers { get; set; }
        public virtual ICollection<MaintenencePeriod> MaintenencePeriodAddedBy { get; set; }
        public virtual ICollection<MaintenencePeriod> MaintenencePeriodModifiedBy { get; set; }
        public virtual ICollection<MarketPlace> MarketPlaceAddedBy { get; set; }
        public virtual ICollection<MarketPlace> MarketPlaceModifiedBy { get; set; }
        public virtual ICollection<Order> OrderAddedBy { get; set; }
        public virtual ICollection<OrderState> OrderAndProductStateAddedBy { get; set; }
        public virtual ICollection<OrderState> OrderAndProductStateModifiedBy { get; set; }
        public virtual ICollection<Order> OrderModifiedBy { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductAddedBy { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductModifiedBy { get; set; }
        public virtual ICollection<PaymentType> PaymentTypeAddedBy { get; set; }
        public virtual ICollection<PaymentType> PaymentTypeModifiedBy { get; set; }
        public virtual ICollection<Product> ProductAddedBy { get; set; }
        public virtual ICollection<ProductCategory> ProductCategoryAddedBy { get; set; }
        public virtual ICollection<ProductCategory> ProductCategoryModifiedBy { get; set; }
        public virtual ICollection<ProductGroup> ProductGroupAddedBy { get; set; }
        public virtual ICollection<ProductGroup> ProductGroupModifiedBy { get; set; }
        public virtual ICollection<ProductGroupsFaq> ProductGroupsFaqAddedBy { get; set; }
        public virtual ICollection<ProductGroupsFaq> ProductGroupsFaqModifiedBy { get; set; }
        public virtual ICollection<Product> ProductModifiedBy { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaultAddedBy { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaultModifiedBy { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaultRepresentitveUserNavigations { get; set; }
        public virtual ICollection<ReturnAndFaultState> ReturnAndFaultStateAddedBy { get; set; }
        public virtual ICollection<ReturnAndFaultState> ReturnAndFaultStateModifiedBy { get; set; }
        public virtual ICollection<Rule> RuleAddedBy { get; set; }
        public virtual ICollection<Rule> RuleModifiedBy { get; set; }
        public virtual ICollection<Segment> SegmentAddedBy { get; set; }
        public virtual ICollection<Segment> SegmentModifiedBy { get; set; }
        public virtual ICollection<Sector> SectorAddedBy { get; set; }
        public virtual ICollection<Sector> SectorModifiedBy { get; set; }
        public virtual ICollection<SegmentOran> SegmentOranAddedBy { get; set; }
        public virtual ICollection<SegmentOran> SegmentOranModifiedBy { get; set; }
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssetAddedBy { get; set; }
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssetModifiedBy { get; set; }
        public virtual ICollection<SellsAndBuysCategory> SellsAndBuysCategoryAddedBy { get; set; }
        public virtual ICollection<SellsAndBuysCategory> SellsAndBuysCategoryModifiedBy { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideStepAddedBy { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideStepModifiedBy { get; set; }
        public virtual ICollection<ServicePlace> ServicePlaceAddedBy { get; set; }
        public virtual ICollection<ServicePlace> ServicePlaceModifiedBy { get; set; }
        public virtual ICollection<ServiceReason> ServiceReasonAddedBy { get; set; }
        public virtual ICollection<ServiceReason> ServiceReasonModifiedBy { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordAddedBy { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordModifiedBy { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordServicePersonalUserNavigations { get; set; }
        public virtual ICollection<ServiceType> ServiceTypeAddedBy { get; set; }
        public virtual ICollection<ServiceType> ServiceTypeModifiedBy { get; set; }
        public virtual ICollection<Supplier> SupplierAddedBy { get; set; }
        public virtual ICollection<Supplier> SupplierModifiedBy { get; set; }
        public virtual ICollection<SupplierPaymentState> SupplierPaymentStateAddedBy { get; set; }
        public virtual ICollection<SupplierPaymentState> SupplierPaymentStateModifiedBy { get; set; }
        public virtual ICollection<SuppliersPayment> SuppliersPaymentAddedBy { get; set; }
        public virtual ICollection<SuppliersPayment> SuppliersPaymentModifiedBy { get; set; }
        public virtual ICollection<UserCompany> UserCompanyAddedBy { get; set; }
        public virtual ICollection<UserCompany> UserCompanyModifiedBy { get; set; }
        public virtual ICollection<VehicleInformation> VehicleInformationAddedBy { get; set; }
        public virtual ICollection<VehicleInformation> VehicleInformationModifiedBy { get; set; }
        public virtual ICollection<WarrantyTracking> WarrantyTrackingAddedBy { get; set; }
        public virtual ICollection<WarrantyTracking> WarrantyTrackingModifiedBy { get; set; }
        public virtual ICollection<WorkStandart> WorkStandartAddedBy { get; set; }
        public virtual ICollection<WorkStandart> WorkStandartModifiedBy { get; set; }
        public virtual ICollection<UserDailyActivityLog> UserActivityLogs { get; set; }
        public virtual ICollection<UserMessage> UsersSendedMessages { get; set; }
        public virtual ICollection<UserMessage> UsersRecievedMessages { get; set; }
        public virtual AppUser AddedBy { get; set; }
        public virtual AppUser? ModifiedBy { get; set; }

        [NotMapped]
        public string NameSurname
        {
            get
            {
                return $"{Name.ToUpper()} {Surname.ToUpper()}";
            }
        }
        #endregion

        public override string ToString()
        {
            return $"({NameSurname} <{Email}>)";
        }
    }
}
