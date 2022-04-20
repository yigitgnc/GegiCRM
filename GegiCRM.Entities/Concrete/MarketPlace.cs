using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class MarketPlace
    {
        public MarketPlace()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public string MarketPlaceName { get; set; } = null!;
        public string MarketPlaceDescription { get; set; } = null!;

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
