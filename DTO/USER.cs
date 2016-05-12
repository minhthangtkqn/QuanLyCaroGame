using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DTO
{
    public class USER
    {
        public USER(string username, string password, string hoTen, bool gioiTinh)
        {
            this.username = username;
            this.password = password;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
        }

        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }

        public virtual IEnumerable<GAME> game { get; set; }
    }
}
