﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class UserDAO
    {
        public USER getUserDAO(string username)
        {
            DbConTextCaroGame db = new DbConTextCaroGame();
            //var p = from k in db.users where k.username == username select k;
            //return p.ToArray()[0];

            //var p = (from k in db.users where k.username == username select k).First();
            //return p;

            return db.users.FirstOrDefault(x => x.username == username);
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


        //public string getHoTenDAO(string Username)
        //{
        //    DbConTextCaroGame db = new DbConTextCaroGame();

        //    var hoTen = (from t in db.users where t.username == Username select t.HoTen);
        //    return hoTen.ToArray()[0];
        //}


        //public int getCapDoDAO(string username)
        //{
        //    DbConTextCaroGame db = new DbConTextCaroGame();

        //    var Cap = (from t in db.users where t.username == username select t.CapDo);
        //    return Cap.ToArray()[0];
        //}


        //public bool getGioiTinhDAO(string Username)
        //{
        //    DbConTextCaroGame db = new DbConTextCaroGame();

        //    var GT = (from t in db.users where t.username == Username select t.GioiTinh);
        //    return GT.ToArray()[0];
        //}


        public bool updateDAO(string username, bool gioiTinh, string hoTen, int capDo)
        {
            try
            {
                DbConTextCaroGame db = new DbConTextCaroGame();
                
                USER user = db.users.FirstOrDefault(x => x.username == username);
                if (user != null)
                {
                    user.HoTen = hoTen;
                    user.GioiTinh = gioiTinh;
                    user.CapDo = capDo;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            
        }


        public bool ThemUserDAO(string username, string password, string hoTen, bool gioiTinh, int capDo)
        {
            try
            {
                DbConTextCaroGame context = new DbConTextCaroGame();
                if (context.users.FirstOrDefault(x => x.username == username) != null)
                {
                    return false;
                }
                
                USER user = new USER(username, password, hoTen, gioiTinh, capDo);
                context.users.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        

    }
}
