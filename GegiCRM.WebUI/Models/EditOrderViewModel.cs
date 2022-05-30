using System.Security.AccessControl;
using GegiCRM.Entities.Concrete;

namespace GegiCRM.WebUI.Models
{
    public class EditOrderViewModel
    {
        public Order Order { get; set; }
        public Customer OrdersCustomer { get; set; }

        
    }
}
