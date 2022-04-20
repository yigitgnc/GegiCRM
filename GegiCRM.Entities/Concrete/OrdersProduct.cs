﻿using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class OrdersProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string? ReferanceCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductStateId { get; set; }
        public int? KesinCurrencyId { get; set; }
        public int? ReferansCurrencyId { get; set; }
        public decimal? Adet { get; set; }
        public decimal? KesinFiyat { get; set; }
        public decimal? BirimFiyat { get; set; }
        public int BirimId { get; set; }
        public string? ReferansBirimFiyat { get; set; }
        public string? Notes { get; set; }
        public int? KesinSupplierId { get; set; }
        public int ReferansSupplierId { get; set; }
        public DateTime? AbonelikBaslangic { get; set; }
        public DateTime? AbonelikBitis { get; set; }
        public DateTime? KesinSevkTarihi { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Birim Birim { get; set; } = null!;
        public virtual Currency? KesinCurrency { get; set; }
        public virtual Supplier? KesinSupplier { get; set; }
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual OrderAndProductState ProductState { get; set; } = null!;
        public virtual Currency? ReferansCurrency { get; set; }
        public virtual Supplier ReferansSupplier { get; set; } = null!;
    }
}
