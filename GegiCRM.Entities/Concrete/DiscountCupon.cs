using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class DiscountCupon
    {
        public DiscountCupon()
        {
            DiscountCuponsOfCustomers = new HashSet<DiscountCuponsOfCustomer>();
        }

        public Guid ModifiedBy { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public string CuponCode { get; set; } = null!;
        public int CuponCurrencyId { get; set; }
        public decimal DiscountAmountMoney { get; set; }
        public string CuponName { get; set; } = null!;
        public string CuponDescription { get; set; } = null!;

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Currency CuponCurrency { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomers { get; set; }
    }
}
