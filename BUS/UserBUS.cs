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

        //public string getHoTenBUS(string Username)
        //{
        //    UserDAO db = new UserDAO();
        //    return db.getHoTenDAO(Username);
        //}

        //public int getCapDoBUS(string username)
        //{
        //    UserDAO db = new UserDAO();
        //    return db.getCapDoDAO(username);
        //}

        //public bool getGioitTinhBUS(string Username)
        //{
        //    UserDAO db = new UserDAO();
        //    return db.getGioiTinhDAO(Username);
        //}


        public bool updateBUS(string username, bool gioiTinh, string hoTen, int capDo)
        {
            UserDAO db = new UserDAO();
            return db.updateDAO(username, gioiTinh, hoTen, capDo);
        }

        public bool themUserBUSS(string username, string password, string hoTen, bool gioiTinh, int capDo)
        {
            UserDAO db = new UserDAO();
            return db.ThemUserDAO(username, password, hoTen, gioiTinh, capDo);
        }
    }
}
