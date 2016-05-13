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
    public partial class FormLogin : Form
    {
        DbConTextCaroGame context = new DbConTextCaroGame();
        UserBUS user = new UserBUS();
        string Username = "";

        public FormLogin()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }

        public FormLogin(string username, string password)
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
            AcceptButton = btnLogin;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            if (!LoginValidate())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool login = user.loginBUS(txtUsername.Text, txtPassword.Text);

            if(login)
            {
                //Mo form thong tin
                (new Thread(new ThreadStart(RunFormQL))).Start();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không đúng.");
            }
        }

        private void RunFormQL()
        {
            Application.Run(new FormQL(Username));
        }

        private bool LoginValidate()
        {
            bool validate = true;
            if (txtUsername.Text == "") 
                validate = false;
            if (txtPassword.Text == "")
                validate = false;

            return validate;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            (new Thread(new ThreadStart(RunFormDangKy))).Start();
            this.Close();
        }

        private void RunFormDangKy()
        {
            Application.Run(new FormRegister());
        }
    }
}
