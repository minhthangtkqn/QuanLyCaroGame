using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class GameDAO
    {
        string message;

        public DataTable getThongTinGameDAO(string username)
        {
            DbConTextCaroGame db = new DbConTextCaroGame();
            List<GAME> games = db.games.Where(x => x.username == username).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Game ID");
            dt.Columns.Add("Người chơi");
            dt.Columns.Add("Kết quả");
            dt.Columns.Add("Thời gian trận đấu (phút)");

            for (int i = 0; i < games.Count; i++)
            {
                dt.Rows.Add();
                dt.Rows[i][0] = games[i].gameID;
                dt.Rows[i][1] = games[i].username;

                if (games[i].result)        dt.Rows[i][2] = "Thắng";
                else                        dt.Rows[i][2] = "Thua";
                
                dt.Rows[i][3] = games[i].time;
            }
            return dt;
        }


        public bool xoaGameDAO(int gameID)
        {
            try
            {
                DbConTextCaroGame context = new DbConTextCaroGame();
                GAME game = context.games.FirstOrDefault(x => x.gameID == gameID);
                if (game != null)
                {
                    context.games.Remove(game);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool updateGameDAO(int gameID, bool result, int time)
        {

            try
            {
                DbConTextCaroGame db = new DbConTextCaroGame();
                GAME game = db.games.FirstOrDefault(x => x.gameID == gameID);
                if (game != null)
                {
                    game.result = result;
                    game.time = time;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
