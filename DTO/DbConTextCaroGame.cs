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
                context.users.Add(new USER("s", "s","Hoang Minh Thang", true, 5));
                context.users.Add(new USER("a", "a", "Tu Thien", false, 7));
                context.users.Add(new USER("b", "b", "Quang Ngu", true, 3));
                context.users.Add(new USER("thang", "thang", "Minh Thang", false, 8));
                context.users.Add(new USER("conghuong", "conghuong", "Cong Huong", true, 3));
                context.users.Add(new USER("ductin", "ductin", "Tin Nguyen", false, 3));
                context.users.Add(new USER("tanMen", "tanMen", "Le Tan", false, 3));

                
                context.games.Add(new GAME("s", true, 10));
                context.games.Add(new GAME("s", false, 9));
                context.games.Add(new GAME("s", false, 8));
                context.games.Add(new GAME("s", false, 9));

                context.games.Add(new GAME("a", true, 4));
                context.games.Add(new GAME("a", true, 10));
                context.games.Add(new GAME("a", false, 7));
                context.games.Add(new GAME("a", false, 9));

                context.games.Add(new GAME("b", false, 7));
                context.games.Add(new GAME("b", false, 12));
                context.games.Add(new GAME("b", true, 4));
                context.games.Add(new GAME("b", false, 5));

                context.games.Add(new GAME("thang", false, 12));
                context.games.Add(new GAME("thang", true, 4));
                context.games.Add(new GAME("thang", false, 5));
                context.games.Add(new GAME("thang", false, 20));

                context.games.Add(new GAME("ductin", false, 7));
                context.games.Add(new GAME("ductin", false, 12));
                context.games.Add(new GAME("ductin", true, 4));
                context.games.Add(new GAME("ductin", false, 5));
                context.games.Add(new GAME("ductin", false, 9));

                context.games.Add(new GAME("tanMen", true, 9));
                context.games.Add(new GAME("tanMen", false, 7));
                context.games.Add(new GAME("tanMen", false, 12));
                context.games.Add(new GAME("tanMen", true, 4));
                context.games.Add(new GAME("tanMen", false, 5));

                context.games.Add(new GAME("conghuong", true, 19));
                context.games.Add(new GAME("conghuong", false, 6));
                context.games.Add(new GAME("conghuong", false, 4));

                context.games.Add(new GAME("thang", true, 4));
                context.games.Add(new GAME("thang", false, 5));
                context.games.Add(new GAME("ductin", false, 7));
                context.games.Add(new GAME("ductin", false, 12));
                context.games.Add(new GAME("ductin", true, 4));



                context.SaveChanges();
            }
        }

    }
}
