using Forma_Desctop_User.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User
{
    public class User
    {
        // автовластивості полів класу-сутності Customer
        [ForeignKey("Login_Class")]
        public int UserId { get; set; }
        public virtual Login_Class Login_Class { get; set; }
        public string user_Name { get; set; }
        public string user_Adress { get; set; }
        public string user_Phone { get; set; }

        public List<Order> user_Orders { get; set; }
        public Shop user_Shop { get; set; }

    }
}
