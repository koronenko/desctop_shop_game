using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User.Model
{
    public class Login_Class
    {
        public int Login_ClassId { get; set; }
        public string login_Clas_Login { get; set; }
        public string login_Clas_Parol { get; set; }
        public virtual User User { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
