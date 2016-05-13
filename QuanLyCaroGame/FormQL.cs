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
using System.Threading;

namespace QuanLyCaroGame
{
    public partial class FormQL : Form
    {

        UserBUS User = new UserBUS();
        USER us;

        string Username, hoTen, capDo;
        bool gioiTinh;

        public FormQL(String username)
        {
            InitializeComponent();
            us = User.getUserBUS(username);
            Username = username;
            
            //Khong cho chinh sua cac text box
            khoaTextBox();

            //chi duoc sua, xoa du lieu khi da chon
            khoaButton();

            setValueToTextBox();

        }

        private void khoaButton()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void khoaTextBox()
        {
            txtCapDo.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtHoTen.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void setValueToTextBox()
        {
            
            txtUsername.Text = Username;

            hoTen = txtHoTen.Text = us.HoTen;

            capDo = txtCapDo.Text = us.CapDo.ToString();

            gioiTinh = us.GioiTinh;

            //hoTen = txtHoTen.Text = User.getHoTenBUS(Username);
            //capDo = txtCapDo.Text = User.getCapDoBUS(Username).ToString();
            //gioiTinh = User.getGioitTinhBUS(Username);
            

            if (gioiTinh)
                txtGioiTinh.Text = "Nam";
            else
                txtGioiTinh.Text = "Nữ";
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            (new Thread(new ThreadStart(RunFormUpdate))).Start();
            this.Close();
        }


        private void RunFormUpdate()
        {
            Application.Run(new FormUpdate(Username, gioiTinh, hoTen, capDo));
        }

        private void ReLoad()
        {
            btnDSGame_Click(new object(), new EventArgs());
        }

        private void btnDSGame_Click(object sender, EventArgs e)
        {
            GameBUS game = new GameBUS();
            dataGridView1.DataSource = game.getThongTinGameBUS(Username);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
            {
                int gameID = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                GameBUS game = new GameBUS();
                if(game.xoaGameBUS(gameID))
                {
                    MessageBox.Show("Xóa thành công");
                    ReLoad();
                }
                
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            (new Thread(new ThreadStart(RunFormEdit))).Start();
        }

        private void RunFormEdit(bool result, int time)
        {
            Application.Run(new FormUpdate(Username, gioiTinh, hoTen, capDo));
        }
    }
}
