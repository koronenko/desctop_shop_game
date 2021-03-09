using Forma_Desctop_User.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Forma_Desctop_User
{
    public partial class Final_Project_02_12_2020 : DbContext
    {
        public Final_Project_02_12_2020()
            : base("name=Final_Project_02_12_2020")
        {
            //Ініціалізація БД та знищення попередньої, зв'язок один до багатьох
            //Database.SetInitializer(new DropCreateDatabaseAlways<Final_Project_02_12_2020>());
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Final_Project_02_12_2020>());
            Database.SetInitializer(new CreateDatabaseIfNotExists<Final_Project_02_12_2020>());
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Login_Class> Login_Classes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
