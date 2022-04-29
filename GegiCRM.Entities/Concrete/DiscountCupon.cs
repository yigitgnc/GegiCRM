using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class DiscountCupon : IBaseEntity
    {
        public DiscountCupon()
        {
            DiscountCuponsOfCustomers = new HashSet<DiscountCuponsOfCustomer>();
        }

        
        public string CuponCode { get; set; } = null!;
        public int CuponCurrencyId { get; set; }
        public decimal DiscountAmountMoney { get; set; }
        public string CuponName { get; set; } = null!;
        public string CuponDescription { get; set; } = null!;

        public virtual Currency CuponCurrency { get; set; } = null!;
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomers { get; set; }
    }
}
