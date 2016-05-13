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
            Database.SetInitializer<DbConTextCaroGame>(new TaoDataBase());
        }


        public class TaoDataBase : CreateDatabaseIfNotExists<DbConTextCaroGame>
        {
            protected override void Seed(DbConTextCaroGame context)
            {
                context.users.Add(new USER ("s", "s","Hoang Minh Thang", true, 5));
                context.users.Add(new USER("a", "a", "Tu Thien", true, 7));
                context.users.Add(new USER("b", "b", "Quang Ngu", true, 3));
                
                context.games.Add(new GAME("s", true, 10));
                context.games.Add(new GAME("a", true, 4));
                context.games.Add(new GAME("s", true, 7));


                context.SaveChanges();
            }
        }

    }
}
