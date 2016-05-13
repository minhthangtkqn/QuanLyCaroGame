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
    public partial class FormThemGame : Form
    {
        string Username;
        bool ketQua;
        int thoiGian;

        public FormThemGame(string username)
        {
            InitializeComponent();

            Username = username;
            txtUsername.Text = Username;
            txtUsername.Enabled = false;

            Init();

        }

        private void Init()
        {
            radioThang.Checked = true;
            radioThua.Checked = false;

            for(int i = 0; i<201; i++)
            {
                comboThoiGian.Items.Add(i);
            }
            comboThoiGian.SelectedIndex = 5;
        }

        private void btnThemGame_Click(object sender, EventArgs e)
        {
            //lấy thông tin từ combo box và radio button
            ketQua = radioThang.Checked;
            thoiGian = Int32.Parse(comboThoiGian.SelectedItem.ToString());

            //thêm vào CSDL và thông báo kết quả
            GameBUS game = new GameBUS();
            if (game.addGameBUS(Username, ketQua, thoiGian))
            {
                MessageBox.Show("Thêm trận thành công (^_^)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm trận không thành công (>_<)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
