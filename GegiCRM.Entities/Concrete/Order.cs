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
        public bool IsDenied { get; set; }
        public DateTime? DeniedDate { get; set; }
        public int? SelectedCustomerAddressId { get; set; }
        public int? SelectedCustomerBillingAddressId { get; set; }
        public int RepresentetiveUserId { get; set; }
        public string? OfferNote { get; set; }
        public string? OrderNote { get; set; }
        public string? OrderNumber { get; set; }
        public string? BayiMusteriAdi { get; set; }
        public bool SendBill { get; set; } = true;


        public virtual CustomerAddress SelectedCustomerAddress { get; set; }
        public virtual CustomerBillingAddress SelectedCustomerBillingAddress { get; set; }
        public virtual AppUser RepresentetiveUser { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual OrderState OrderState { get; set; } = null!;
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }


    }

    public partial class Order
    {

        [NotMapped]
        public string OfferApprovedDateDateFormatted => FormatNullDate(OfferApprovedDate);

        [NotMapped]
        public string OrderApprovedDateFormatted => FormatNullDate(OrderApprovedDate);

        [NotMapped]
        public string CancelledDateFormatted => FormatNullDate(CancelledDate);

        [NotMapped]
        public string DeniedDateFormatted => FormatNullDate(DeniedDate);

        public string CreateHtmlBadgeForOffer()
        {
            string badge = "<span class=\"badge bg-label-dark me-1\">Beklemede</span>";
            if (IsCancelled)
            {
                badge = "<span class=\"badge bg-label-danger me-1\">İptal</span>";
            }
            else if (IsOfferApproved)
            {
                badge = "<span class=\"badge bg-label-success me-1\">Onaylandı</span>";
            }
            return badge;
        }

        public string CreateHtmlBadgeForOrder()
        {
            string badge = "<span class=\"badge bg-label-dark me-1\">Beklemede</span>";
            if (IsDenied)
            {
                badge = "<span class=\"badge bg-label-danger me-1\">İptal</span>";
            }
            else if (IsOrderApproved)
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
