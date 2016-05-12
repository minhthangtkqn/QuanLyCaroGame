using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCaroGame
{
    public partial class FormQL : Form
    {

        UserBUS User = new UserBUS();

        string Username, hoTen;
        int CapDo;
        bool gioiTinh;

        public FormQL(String username)
        {
            InitializeComponent();
            Username = username;
            hoTen = User.getHoTenBUS(Username);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

    }
}
