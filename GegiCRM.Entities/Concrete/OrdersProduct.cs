using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GegiCRM.Entities.Concrete
{
    public partial class OrdersProduct : BaseEntity<int>
    {
        public OrdersProduct()
        {
            OrdersCurrencies = new HashSet<OrdersCurrency>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string? ReferanceCode { get; set; }
        public int? KesinCurrencyId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ReferansCurrencyId { get; set; }
        public decimal? KesinCurrencyValue { get; set; }
        public decimal? ReferansCurrencyValue { get; set; }
        public decimal? CurrencyValue { get; set; }
        public decimal? Adet { get; set; }
        public decimal? KesinFiyat { get; set; }
        public decimal? BirimFiyat { get; set; }
        public decimal? Fiyat { get; set; }
        public int BirimId { get; set; }
        public decimal? ReferansBirimFiyat { get; set; }
        public string? Notes { get; set; }
        public int? KesinSupplierId { get; set; }
        public int ReferansSupplierId { get; set; }
        public DateTime? AbonelikBaslangic { get; set; }
        public DateTime? AbonelikBitis { get; set; }
        public DateTime? KesinSevkTarihi { get; set; }

        public bool IsApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public bool IsDenied { get; set; }
        public DateTime? DeniedDate { get; set; }
        public bool IsFrequentlyUsed { get; set; }
        public int? KesinSevkDurumuId{ get; set; }

        public virtual KesinSevkiyatDurumu? KesinSevkDurumu { get; set; } = null!;
        public virtual Birim Birim { get; set; } = null!;
        public virtual Currency? Currency { get; set; }
        public virtual Currency? KesinCurrency { get; set; }
        public virtual Supplier? KesinSupplier { get; set; }
        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Currency? ReferansCurrency { get; set; }
        public virtual Supplier ReferansSupplier { get; set; } = null!;

        public virtual ICollection<OrdersCurrency> OrdersCurrencies { get; set; }
    }

    public partial class OrdersProduct
    {

        [NotMapped]
        public string ApprovedDateFormatted => FormatNullDate(ApprovedDate);

        [NotMapped]
        public string CancelledDateFormatted => FormatNullDate(CancelledDate);

        [NotMapped]
        public string DeniedDateFormatted => FormatNullDate(DeniedDate);
        [NotMapped]
        public string AbonelikBaslangicFormatted => FormatNullDate(AbonelikBaslangic);
        [NotMapped]
        public string AbonelikBitisFormatted => FormatNullDate(AbonelikBitis);

        public string CreateHtmlBadge(bool property)
        {
            string badge = "<span class=\"badge bg-label-dark me-1\">Beklemede</span>";
            if (IsCancelled)
            {
                badge = "<span class=\"badge bg-label-danger me-1\">İptal</span>";
            }
            else if (IsDenied)
            {
                badge = "<span class=\"badge bg-label-danger me-1\">Red</span>";
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
