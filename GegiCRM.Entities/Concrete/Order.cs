using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GegiCRM.Entities.Concrete
{
    public partial class Order : BaseEntity<int>
    {
        public Order()
        {
            OrdersCurrencies = new HashSet<OrdersCurrency>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }


        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }
        public bool IsFrequentlyUsed { get; set; }
        public bool IsOfferApproved { get; set; }
        public DateTime? OfferApprovedDate { get; set; }
        public bool IsOrderApproved { get; set; }
        public DateTime? OrderApprovedDate { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public bool IsDeneied { get; set; }
        public DateTime? DeniedDate { get; set; }
        public int? SelectedCustomerAddressId { get; set; }
        public int? SelectedCustomerBillingAddressId { get; set; }
        public int RepresentetiveUserId { get; set; }

        public virtual CustomerAddress SelectedCustomerAddress { get; set; }
        public virtual CustomerBillingAddress SelectedCustomerBillingAddress { get; set; }
        public virtual AppUser RepresentetiveUser { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual OrderState OrderState { get; set; } = null!;
        public virtual ICollection<OrdersCurrency> OrdersCurrencies { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }


    }

    public partial class Order
    {

        [NotMapped]
        public string SiparisOnayFormatted => FormatNullDate(OrderApprovedDate);
        [NotMapped]
        public string TeklifOnayFormatted => FormatNullDate(OrderApprovedDate);

        public string CreateHtmlBadge(bool property)
        {
            string badge = "<span class=\"badge bg-label-dark me-1\">Beklemede</span>";
            if (IsCancelled)
            {
                badge = "<span class=\"badge bg-label-danger me-1\">İptal</span>";
            }
            else if (property)
            {
                badge = "<span class=\"badge bg-label-success me-1\">Onaylandı</span>";
            }
            return badge;
        }

        private string FormatNullDate(DateTime? date)
        {
            string value = "";
            if (date == null)
            {
                value = "Beklemede";
            }
            else
            {
                value = date.ToString();
            }

            return value;

        }
    }
}
