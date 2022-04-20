﻿using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ProductCategory
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int ProductGroupId { get; set; }
        public string ProductCategoryName { get; set; } = null!;
        public string? ProductCategoryDescription { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ProductGroup ProductGroup { get; set; } = null!;
    }
}
