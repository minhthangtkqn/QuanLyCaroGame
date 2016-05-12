using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class UserBUS
    {
        public USER getUserBUS(string username)
        {
            UserDAO db = new UserDAO();
            return db.getUserDAO(username);
        }

        public bool loginBUS(string username, string password)
        {
            UserDAO db = new UserDAO();
            return db.loginDAO(username, password);
        }

        public string getHoTenBUS(string Username)
        {
            
        }
    }
}
