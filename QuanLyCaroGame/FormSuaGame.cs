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
    public partial class FormSuaGame : Form
    {
        int gameID;
        bool ketQua;
        int thoiGian;

        public FormSuaGame(string game_ID, bool result, int time)
        {
            InitializeComponent();

            ketQua = result;
            thoiGian = time;
            gameID = Int32.Parse(game_ID);

            setDataFromCallerToForm();

        }

        private void setDataFromCallerToForm()
        {
            txtTime.Text = thoiGian.ToString();
            if (ketQua)
                radioThang.Checked = true;
            else
                radioThua.Checked = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!validateCapNhat())
                return;

            thoiGian = Int32.Parse(txtTime.Text);
            ketQua = radioThang.Checked;
            
            //Tiến hành cập nhật
            GameBUS game = new GameBUS();
            if (game.updateGameBUS(gameID, ketQua, thoiGian))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật");
                this.Close();
            }
            
        }

        private bool validateCapNhat()
        {
            if (txtTime.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
