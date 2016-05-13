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
    public partial class FormRegister : Form
    {
        UserBUS User = new UserBUS();

        string username, password, hoTen;
        bool gioiTinh;
        int capDo = 1;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!xacNhanMatKhau())
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            username = txtUsername.Text;
            password = txtPassword.Text;
            hoTen = txtHoTen.Text;
            gioiTinh = radioNam.Checked;

            if (!User.themUserBUSS(username, password, hoTen, gioiTinh, 1))
            {
                MessageBox.Show("Đăng ký không thành công (>_<)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (new Thread(new ThreadStart(RunFormLogin))).Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thành công (^_^)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                (new Thread(new ThreadStart(RunFormLoginTC))).Start();
                this.Close();
            }
            
        }

        private bool xacNhanMatKhau()
        {
            if (txtPassword.Text.Equals(txtXacNhanMatKhau.Text))
                return true;
            return false;
        }

        private bool validateRegister()
        {
            bool check = true;
            if (txtUsername.Text == "")
                check = false;
            if (txtPassword.Text == "")
                check = false;
            if (txtHoTen.Text == "")
                check = false;
            if (radioNam.Checked == false && radioNu.Checked == false)
                check = false;
            return check;
        }


        private void RunFormLogin()
        {
            Application.Run(new FormLogin());
        }

        private void RunFormLoginTC()
        {
            Application.Run(new FormLogin(username, password));
        }

    }
}
