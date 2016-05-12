using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class UserDAO
    {
        public USER getUserDAO(string username)
        {
            DbConTextCaroGame db = new DbConTextCaroGame();
            var p = from k in db.users where k.username == username select k;
            return p.ToArray()[0];
        }

        public bool loginDAO(string username, string password)
        {
            DbConTextCaroGame db = new DbConTextCaroGame();
            bool check = false;

            //kiem tra co ton tai username hay ko
            var usernames = (from l in db.users select l.username);
            foreach (var userN in usernames)
                if (userN.ToString() == username)
                    check = true;
            if (!check)
                return check;
            else
            {
                //kiem tra password co dung khong
                var pass = (from p in db.users where p.username == username select p.password);
                if (pass.ToArray()[0] == password)
                    return true;
            }
            return false;
        }

    }
}
