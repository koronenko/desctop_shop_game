using Forma_Desctop_User.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User
{
   public class Manager
    {
        [ForeignKey("Login_Class")]
        public int ManagerId { get; set; }
        public string manager_Name { get; set; }
       // public List<Login_Class> manager_login { get; set; }
       public virtual Login_Class Login_Class { get; set; }
        public Shop manager_Shop { get; set; }
        public List<Order> manager_Orders { get; set; }

    }
}
