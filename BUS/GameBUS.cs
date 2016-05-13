using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GameBUS
    {
        public DataTable getThongTinGameBUS(string username)
        {
            GameDAO game = new GameDAO();
            return game.getThongTinGameDAO(username);
        }

        public bool xoaGameBUS(int gameID)
        {
            GameDAO game = new GameDAO();
            return game.xoaGameDAO(gameID);
            
        }


        public bool updateGameBUS(int gameID, bool result, int time)
        {
            GameDAO game = new GameDAO();
            return game.updateGameDAO(gameID, result, time);
        }

        
    }
}
