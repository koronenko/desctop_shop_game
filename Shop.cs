using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string shop_Name { get; set; }
        public List<Game> shop_Games { get; set; }
        public List<User> shop_Users { get; set; }
        public List<Order> shop_Orders { get; set; }
        public List<Manager> shop_Managers { get; set; }
    }
}
