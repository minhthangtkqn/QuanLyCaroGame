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

        string gameID;
        bool ketQua;
        int thoiGian;

        public FormQL(String username)
        {
            InitializeComponent();
            Username = username;

            us = User.getUserBUS(username);
            

            
            //Khong cho chinh sua cac text box
            khoaTextBox();

            //chỉ được chỉnh sửa, xóa khi đã chọn 1 hàng
            khoaButton();

            setValueToTextBox();

            ReLoad();

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
            FormUpdate capNhat = new FormUpdate(Username, gioiTinh, hoTen, capDo);
            capNhat.ShowDialog();
        }


        private void ReLoad()
        {
            GameBUS game = new GameBUS();
            dataGridView1.DataSource = game.getThongTinGameBUS(Username);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 170;
            }
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

            ketQua = false;

            gameID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string result = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            if (result == "Thắng")
            {
                ketQua = true;
            }
            thoiGian = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //(new Thread(new ThreadStart(RunFormSuaGame))).Start();
            FormSuaGame suaGame = new FormSuaGame(gameID, ketQua, thoiGian);
            suaGame.ShowDialog();
        }

        private void RunFormSuaGame()
        {
            Application.Run(new FormSuaGame(gameID, ketQua, thoiGian));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh viên: Hoàng Minh Thắng\nClass: 13TCLC", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void danhSáchTrậnĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReLoad();
            us = User.getUserBUS(Username);
            setValueToTextBox();
        }

        private void btnThemGame_Click(object sender, EventArgs e)
        {
            FormThemGame themGame = new FormThemGame(Username);
            themGame.ShowDialog();
        }

        private void sửaThôngTinNgườiChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(null, null);
        }
    }
}
