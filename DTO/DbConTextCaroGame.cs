using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DTO
{
    public class DbConTextCaroGame : DbContext
    {
        public DbSet<GAME> games { get; set; }
        public DbSet<USER> users { get; set; }

        public DbConTextCaroGame()
            : base("QuanLy")
        {
            //Database.SetInitializer<DbConTextCaroGame>(new TaoDataBase());
        }
        public class TaoDataBase : CreateDatabaseIfNotExists<DbConTextCaroGame>
        {
            protected override void Seed(DbConTextCaroGame context)
            {
                context.users.Add(new USER ("minhthang", "minhthang1","Hoang Minh Thang", true ));

                context.SaveChanges();
            }
        }

    }
}
