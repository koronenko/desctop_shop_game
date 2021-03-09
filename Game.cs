using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User
{
    public class Game
    {
        // автовластивості полів класу-сутності Game
        public int GameId { get; set; }
        public string game_Title { get; set; }
        public string game_Genre { get; set; }
        public string game_Describe { get; set; }
        public string game_Developer { get; set; }
        public int game_Price { get; set; }
        public List<Order> game_Orders { get; set; }
       
        public List<Shop> game_Shops { get; set; }

       
    }
}
