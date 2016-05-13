using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class GAME
    {
        public GAME()
        {

        }

        public GAME(string username, bool result, int time)
        {
            this.username = username;
            this.result = result;
            this.time = time;
        }


        [Key]
        public int gameID { get; set; }
        public string username { get; set; }
        public bool result { get; set; }
        public int time { get; set; }

        [ForeignKey("username")]
        public virtual USER user { get; set; }
    }
}
