using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User
{
    public class Order
    {
        // автовластивості полів класу-сутності Order
        public int OrderId { get; set; }
        public User order_User { get; set; }
        public string order_Date { get; set; }
        public Manager order_Manager { get; set; }
        public string order_Status { get; set; }
        public Shop order_Shop { get; set; }
        
        public ICollection<Game> order_Games { get; set; }
        
    }
}
