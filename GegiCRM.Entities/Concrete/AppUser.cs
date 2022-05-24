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
            AppRolesOfUsersAddedByNavigations = new HashSet<AppRolesOfUsers>();
            AppRolesOfUsersModifiedByNavigations = new HashSet<AppRolesOfUsers>();
            AppAuthorizationRoleGroupAddedByNavigations = new HashSet<AppIdentityRoleGroup>();
            AppAuthorizationRoleGroupModifiedByNavigations = new HashSet<AppIdentityRoleGroup>();
            //AppUsersAuthorizationRoleUsers = new HashSet<AppUsersAuthorizationRole>();
            AuthorizationsRoleAddedByNavigations = new HashSet<AppIdentityRole>();
            AuthorizationsRoleModifiedByNavigations = new HashSet<AppIdentityRole>();
            BankAddedByNavigations = new HashSet<Bank>();
            BankModifiedByNavigations = new HashSet<Bank>();
            BankInformationAddedByNavigations = new HashSet<BankInformation>();
            BankInformationModifiedByNavigations = new HashSet<BankInformation>();
            BirimAddedByNavigations = new HashSet<Birim>();
            BirimModifiedByNavigations = new HashSet<Birim>();
            BrandAddedByNavigations = new HashSet<Brand>();
            BrandModifiedByNavigations = new HashSet<Brand>();
            CustomerTypeAddedByNavigations = new HashSet<CustomerType>();
            CustomerTypeModifiedByNavigations = new HashSet<CustomerType>();
            CustomerAddedByNavigations = new HashSet<Customer>();
            CustomerModifiedByNavigations = new HashSet<Customer>();
            OrderRepresentetiveUserNavigations = new HashSet<Order>();
            CustomerActivityLogAddedByNavigations = new HashSet<CustomerActivityLog>();
            CustomerActivityLogModifiedByNavigations = new HashSet<CustomerActivityLog>();
            CustomerAddressAddedByNavigations = new HashSet<CustomerAddress>();
            CustomerAddressModifiedByNavigations = new HashSet<CustomerAddress>();
            CustomerContactAddedByNavigations = new HashSet<CustomerContact>();
            CustomerContactModifiedByNavigations = new HashSet<CustomerContact>();
            CustomerRepresentetiveUsers = new HashSet<CustomerRepresentetiveUser>();
            DepartmentAddedByNavigations = new HashSet<Department>();
            DepartmentModifiedByNavigations = new HashSet<Department>();
            DepartmentsOfUsers = new HashSet<DepartmentsOfUser>();
            DepositAddedByNavigations = new HashSet<Deposit>();
            DepositModifiedByNavigations = new HashSet<Deposit>();
            DepositRelationAddedByNavigations = new HashSet<DepositRelation>();
            DepositRelationModifiedByNavigations = new HashSet<DepositRelation>();
            DepositTypeAddedByNavigations = new HashSet<DepositType>();
            DepositTypeModifiedByNavigations = new HashSet<DepositType>();
            DiscountCuponAddedByNavigations = new HashSet<DiscountCupon>();
            DiscountCuponModifiedByNavigations = new HashSet<DiscountCupon>();
            DiscountCuponsOfCustomerAddedByNavigations = new HashSet<DiscountCuponsOfCustomer>();
            DiscountCuponsOfCustomerModifiedByNavigations = new HashSet<DiscountCuponsOfCustomer>();
            DocumentAddedByNavigations = new HashSet<Document>();
            DocumentModifiedByNavigations = new HashSet<Document>();
            EmailTemplateAddedByNavigations = new HashSet<EmailTemplate>();
            EmailTemplateModifiedByNavigations = new HashSet<EmailTemplate>();
            ExpansionAddedByNavigations = new HashSet<Expansion>();
            ExpansionModifiedByNavigations = new HashSet<Expansion>();
            InverseAddedByNavigation = new HashSet<AppUser>();
            InverseModifiedByNavigation = new HashSet<AppUser>();
            MaintenanceBillAddedByNavigations = new HashSet<MaintenanceBill>();
            MaintenanceBillCustomerRepresentetiveUsers = new HashSet<MaintenanceBill>();
            MaintenanceBillModifiedByNavigations = new HashSet<MaintenanceBill>();
            MaintenanceBillSellingRepresentetiveUsers = new HashSet<MaintenanceBill>();
            MaintenencePeriodAddedByNavigations = new HashSet<MaintenencePeriod>();
            MaintenencePeriodModifiedByNavigations = new HashSet<MaintenencePeriod>();
            MarketPlaceAddedByNavigations = new HashSet<MarketPlace>();
            MarketPlaceModifiedByNavigations = new HashSet<MarketPlace>();
            OrderAddedByNavigations = new HashSet<Order>();
            OrderAndProductStateAddedByNavigations = new HashSet<OrderState>();
            OrderAndProductStateModifiedByNavigations = new HashSet<OrderState>();
            OrderModifiedByNavigations = new HashSet<Order>();
            OrdersProductAddedByNavigations = new HashSet<OrdersProduct>();
            OrdersProductModifiedByNavigations = new HashSet<OrdersProduct>();
            PaymentTypeAddedByNavigations = new HashSet<PaymentType>();
            PaymentTypeModifiedByNavigations = new HashSet<PaymentType>();
            ProductAddedByNavigations = new HashSet<Product>();
            ProductCategoryAddedByNavigations = new HashSet<ProductCategory>();
            ProductCategoryModifiedByNavigations = new HashSet<ProductCategory>();
            ProductGroupAddedByNavigations = new HashSet<ProductGroup>();
            ProductGroupModifiedByNavigations = new HashSet<ProductGroup>();
            ProductGroupsFaqAddedByNavigations = new HashSet<ProductGroupsFaq>();
            ProductGroupsFaqModifiedByNavigations = new HashSet<ProductGroupsFaq>();
            ProductModifiedByNavigations = new HashSet<Product>();
            ReturnAndFaultAddedByNavigations = new HashSet<ReturnAndFault>();
            ReturnAndFaultModifiedByNavigations = new HashSet<ReturnAndFault>();
            ReturnAndFaultRepresentitveUserNavigations = new HashSet<ReturnAndFault>();
            ReturnAndFaultStateAddedByNavigations = new HashSet<ReturnAndFaultState>();
            ReturnAndFaultStateModifiedByNavigations = new HashSet<ReturnAndFaultState>();
            RuleAddedByNavigations = new HashSet<Rule>();
            RuleModifiedByNavigations = new HashSet<Rule>();
            SegmentAddedByNavigations = new HashSet<Segment>();
            SegmentModifiedByNavigations = new HashSet<Segment>();
            SectorAddedByNavigations = new HashSet<Sector>();
            SectorModifiedByNavigations = new HashSet<Sector>();
            SegmentOranAddedByNavigations = new HashSet<SegmentOran>();
            SegmentOranModifiedByNavigations = new HashSet<SegmentOran>();
            SellsAndBuysAssetAddedByNavigations = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysAssetModifiedByNavigations = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysCategoryAddedByNavigations = new HashSet<SellsAndBuysCategory>();
            SellsAndBuysCategoryModifiedByNavigations = new HashSet<SellsAndBuysCategory>();
            SellsAndBuysGuideStepAddedByNavigations = new HashSet<SellsAndBuysGuideStep>();
            SellsAndBuysGuideStepModifiedByNavigations = new HashSet<SellsAndBuysGuideStep>();
            ServicePlaceAddedByNavigations = new HashSet<ServicePlace>();
            ServicePlaceModifiedByNavigations = new HashSet<ServicePlace>();
            ServiceReasonAddedByNavigations = new HashSet<ServiceReason>();
            ServiceReasonModifiedByNavigations = new HashSet<ServiceReason>();
            ServiceRecordAddedByNavigations = new HashSet<ServiceRecord>();
            ServiceRecordModifiedByNavigations = new HashSet<ServiceRecord>();
            ServiceRecordServicePersonalUserNavigations = new HashSet<ServiceRecord>();
            ServiceTypeAddedByNavigations = new HashSet<ServiceType>();
            ServiceTypeModifiedByNavigations = new HashSet<ServiceType>();
            SupplierAddedByNavigations = new HashSet<Supplier>();
            SupplierModifiedByNavigations = new HashSet<Supplier>();
            SupplierPaymentStateAddedByNavigations = new HashSet<SupplierPaymentState>();
            SupplierPaymentStateModifiedByNavigations = new HashSet<SupplierPaymentState>();
            SuppliersPaymentAddedByNavigations = new HashSet<SuppliersPayment>();
            SuppliersPaymentModifiedByNavigations = new HashSet<SuppliersPayment>();
            UserCompanyAddedByNavigations = new HashSet<UserCompany>();
            UserCompanyModifiedByNavigations = new HashSet<UserCompany>();
            VehicleInformationAddedByNavigations = new HashSet<VehicleInformation>();
            VehicleInformationModifiedByNavigations = new HashSet<VehicleInformation>();
            WarrantyTrackingAddedByNavigations = new HashSet<WarrantyTracking>();
            WarrantyTrackingModifiedByNavigations = new HashSet<WarrantyTracking>();
            WorkStandartAddedByNavigations = new HashSet<WorkStandart>();
            WorkStandartModifiedByNavigations = new HashSet<WorkStandart>();
        }


        public int UserCompanyId { get; set; }
        //public string Email { get; set; } = null!;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string? ProfilePictureUrl { get; set; }

        #region virtuals
        public virtual UserCompany UserCompany { get; set; } = null!;
        public virtual ICollection<Announcement> AnnouncementsAddedByNavigations { get; set; }
        public virtual ICollection<Announcement> AnnouncementsModifiedByNavigations { get; set; }
        public virtual ICollection<AppRolesOfUsers>? AppRolesOfUsersAddedByNavigations { get; set; }
        public virtual ICollection<AppRolesOfUsers> AppRolesOfUsersModifiedByNavigations { get; set; }
        public virtual ICollection<AppIdentityRoleGroup>? AppAuthorizationRoleGroupAddedByNavigations { get; set; }
        public virtual ICollection<AppIdentityRoleGroup> AppAuthorizationRoleGroupModifiedByNavigations { get; set; }
        //public virtual ICollection<AppAppUsersAuthorizationRole> AppUsersAuthorizationRoleUsers { get; set; } 
        public virtual ICollection<AppIdentityRole> AuthorizationsRoleAddedByNavigations { get; set; }
        public virtual ICollection<AppIdentityRole> AuthorizationsRoleModifiedByNavigations { get; set; }
        public virtual ICollection<Bank> BankAddedByNavigations { get; set; }
        public virtual ICollection<Bank> BankModifiedByNavigations { get; set; }
        public virtual ICollection<BankInformation> BankInformationAddedByNavigations { get; set; }
        public virtual ICollection<BankInformation> BankInformationModifiedByNavigations { get; set; }
        public virtual ICollection<Birim> BirimAddedByNavigations { get; set; }
        public virtual ICollection<Birim> BirimModifiedByNavigations { get; set; }
        public virtual ICollection<Brand> BrandAddedByNavigations { get; set; }
        public virtual ICollection<Brand> BrandModifiedByNavigations { get; set; }
        public virtual ICollection<CollectionReceipt> CollectionReceiptAddedByNavigations { get; set; }
        public virtual ICollection<CollectionReceipt> CollectionReceiptModifiedByNavigations { get; set; }
        public virtual ICollection<Currency> CurrencyAddedByNavigations { get; set; }
        public virtual ICollection<Currency> CurrencyModifiedByNavigations { get; set; }
        public virtual ICollection<CustomerType> CustomerTypeAddedByNavigations { get; set; }
        public virtual ICollection<CustomerType> CustomerTypeModifiedByNavigations { get; set; }
        public virtual ICollection<Customer> CustomerAddedByNavigations { get; set; }
        public virtual ICollection<Customer> CustomerModifiedByNavigations { get; set; }
        public virtual ICollection<Order> OrderRepresentetiveUserNavigations { get; set; }
        public virtual ICollection<CustomerActivityLog> CustomerActivityLogAddedByNavigations { get; set; }
        public virtual ICollection<CustomerActivityLog> CustomerActivityLogModifiedByNavigations { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressAddedByNavigations { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressModifiedByNavigations { get; set; }
        public virtual ICollection<CustomerBillingAddress> CustomerBillingAddressAddedByNavigations { get; set; }
        public virtual ICollection<CustomerBillingAddress> CustomerBillingAddressModifiedByNavigations { get; set; }
        public virtual ICollection<CustomerContact> CustomerContactAddedByNavigations { get; set; }
        public virtual ICollection<CustomerContact> CustomerContactModifiedByNavigations { get; set; }
        //public virtual ICollection<CustomerDetail> CustomerDetailAddedByNavigations { get; set; }
        //public virtual ICollection<CustomerDetail> CustomerDetailModifiedByNavigations { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUserAddedByNavigations { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUserModifiedByNavigations { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUsers { get; set; }
        public virtual ICollection<Department> DepartmentAddedByNavigations { get; set; }
        public virtual ICollection<Department> DepartmentModifiedByNavigations { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsers { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsersAddedByNavigations { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsersModifiedByNavigations { get; set; }
        public virtual ICollection<Deposit> DepositAddedByNavigations { get; set; }
        public virtual ICollection<Deposit> DepositModifiedByNavigations { get; set; }
        public virtual ICollection<DepositRelation> DepositRelationAddedByNavigations { get; set; }
        public virtual ICollection<DepositRelation> DepositRelationModifiedByNavigations { get; set; }
        public virtual ICollection<DepositType> DepositTypeAddedByNavigations { get; set; }
        public virtual ICollection<DepositType> DepositTypeModifiedByNavigations { get; set; }
        public virtual ICollection<DiscountCupon> DiscountCuponAddedByNavigations { get; set; }
        public virtual ICollection<DiscountCupon> DiscountCuponModifiedByNavigations { get; set; }
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomerAddedByNavigations { get; set; }
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomerModifiedByNavigations { get; set; }
        public virtual ICollection<Document> DocumentAddedByNavigations { get; set; }
        public virtual ICollection<Document> DocumentModifiedByNavigations { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplateAddedByNavigations { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplateModifiedByNavigations { get; set; }
        public virtual ICollection<Expansion> ExpansionAddedByNavigations { get; set; }
        public virtual ICollection<Expansion> ExpansionModifiedByNavigations { get; set; }
        public virtual ICollection<AppUser> InverseAddedByNavigation { get; set; }
        public virtual ICollection<AppUser> InverseModifiedByNavigation { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillAddedByNavigations { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillCustomerRepresentetiveUsers { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillModifiedByNavigations { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBillSellingRepresentetiveUsers { get; set; }
        public virtual ICollection<MaintenencePeriod> MaintenencePeriodAddedByNavigations { get; set; }
        public virtual ICollection<MaintenencePeriod> MaintenencePeriodModifiedByNavigations { get; set; }
        public virtual ICollection<MarketPlace> MarketPlaceAddedByNavigations { get; set; }
        public virtual ICollection<MarketPlace> MarketPlaceModifiedByNavigations { get; set; }
        public virtual ICollection<Order> OrderAddedByNavigations { get; set; }
        public virtual ICollection<OrderState> OrderAndProductStateAddedByNavigations { get; set; }
        public virtual ICollection<OrderState> OrderAndProductStateModifiedByNavigations { get; set; }
        public virtual ICollection<Order> OrderModifiedByNavigations { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductAddedByNavigations { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductModifiedByNavigations { get; set; }
        public virtual ICollection<PaymentType> PaymentTypeAddedByNavigations { get; set; }
        public virtual ICollection<PaymentType> PaymentTypeModifiedByNavigations { get; set; }
        public virtual ICollection<Product> ProductAddedByNavigations { get; set; }
        public virtual ICollection<ProductCategory> ProductCategoryAddedByNavigations { get; set; }
        public virtual ICollection<ProductCategory> ProductCategoryModifiedByNavigations { get; set; }
        public virtual ICollection<ProductGroup> ProductGroupAddedByNavigations { get; set; }
        public virtual ICollection<ProductGroup> ProductGroupModifiedByNavigations { get; set; }
        public virtual ICollection<ProductGroupsFaq> ProductGroupsFaqAddedByNavigations { get; set; }
        public virtual ICollection<ProductGroupsFaq> ProductGroupsFaqModifiedByNavigations { get; set; }
        public virtual ICollection<Product> ProductModifiedByNavigations { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaultAddedByNavigations { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaultModifiedByNavigations { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaultRepresentitveUserNavigations { get; set; }
        public virtual ICollection<ReturnAndFaultState> ReturnAndFaultStateAddedByNavigations { get; set; }
        public virtual ICollection<ReturnAndFaultState> ReturnAndFaultStateModifiedByNavigations { get; set; }
        public virtual ICollection<Rule> RuleAddedByNavigations { get; set; }
        public virtual ICollection<Rule> RuleModifiedByNavigations { get; set; }
        public virtual ICollection<Segment> SegmentAddedByNavigations { get; set; }
        public virtual ICollection<Segment> SegmentModifiedByNavigations { get; set; }
        public virtual ICollection<Sector> SectorAddedByNavigations { get; set; }
        public virtual ICollection<Sector> SectorModifiedByNavigations { get; set; }
        public virtual ICollection<SegmentOran> SegmentOranAddedByNavigations { get; set; }
        public virtual ICollection<SegmentOran> SegmentOranModifiedByNavigations { get; set; }
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssetAddedByNavigations { get; set; }
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssetModifiedByNavigations { get; set; }
        public virtual ICollection<SellsAndBuysCategory> SellsAndBuysCategoryAddedByNavigations { get; set; }
        public virtual ICollection<SellsAndBuysCategory> SellsAndBuysCategoryModifiedByNavigations { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideStepAddedByNavigations { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideStepModifiedByNavigations { get; set; }
        public virtual ICollection<ServicePlace> ServicePlaceAddedByNavigations { get; set; }
        public virtual ICollection<ServicePlace> ServicePlaceModifiedByNavigations { get; set; }
        public virtual ICollection<ServiceReason> ServiceReasonAddedByNavigations { get; set; }
        public virtual ICollection<ServiceReason> ServiceReasonModifiedByNavigations { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordAddedByNavigations { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordModifiedByNavigations { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecordServicePersonalUserNavigations { get; set; }
        public virtual ICollection<ServiceType> ServiceTypeAddedByNavigations { get; set; }
        public virtual ICollection<ServiceType> ServiceTypeModifiedByNavigations { get; set; }
        public virtual ICollection<Supplier> SupplierAddedByNavigations { get; set; }
        public virtual ICollection<Supplier> SupplierModifiedByNavigations { get; set; }
        public virtual ICollection<SupplierPaymentState> SupplierPaymentStateAddedByNavigations { get; set; }
        public virtual ICollection<SupplierPaymentState> SupplierPaymentStateModifiedByNavigations { get; set; }
        public virtual ICollection<SuppliersPayment> SuppliersPaymentAddedByNavigations { get; set; }
        public virtual ICollection<SuppliersPayment> SuppliersPaymentModifiedByNavigations { get; set; }
        public virtual ICollection<UserCompany> UserCompanyAddedByNavigations { get; set; }
        public virtual ICollection<UserCompany> UserCompanyModifiedByNavigations { get; set; }
        public virtual ICollection<VehicleInformation> VehicleInformationAddedByNavigations { get; set; }
        public virtual ICollection<VehicleInformation> VehicleInformationModifiedByNavigations { get; set; }
        public virtual ICollection<WarrantyTracking> WarrantyTrackingAddedByNavigations { get; set; }
        public virtual ICollection<WarrantyTracking> WarrantyTrackingModifiedByNavigations { get; set; }
        public virtual ICollection<WorkStandart> WorkStandartAddedByNavigations { get; set; }
        public virtual ICollection<WorkStandart> WorkStandartModifiedByNavigations { get; set; }
        public virtual AppUser AddedByNavigation { get; set; }
        public virtual AppUser? ModifiedByNavigation { get; set; }

        [NotMapped]
        public string NameSurname
        {
            get
            {
                return $"{Name} {Surname.ToUpper()}";
            }
        }
        #endregion

        public override string ToString()
        {
            return $"({Name} {Surname} <{Email}>)";
        }
    }
}
