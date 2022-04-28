using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class MarketPlace : BaseEntity
    {
        public MarketPlace()
        {
            Suppliers = new HashSet<Supplier>();
        }

        
        public string MarketPlaceName { get; set; } = null!;
        public string MarketPlaceDescription { get; set; } = null!;


        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
