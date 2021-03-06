﻿using System;
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
    public partial class FormUpdate : Form
    {
        UserBUS User = new UserBUS();

        string hoTen, Username;
        bool gioiTinh;
        int capDo;

        public FormUpdate(string username, bool gioiTinh, string hoTen, string CapDo)
        {
            InitializeComponent();
            AcceptButton = btnCapNhat;


            Username = username;
            txtHoTen.Text = hoTen;
            txtCapDo.Text = CapDo;

            if (gioiTinh)
                radioNam.Checked = true;
            else
                radioNu.Checked = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            hoTen = txtHoTen.Text;
            capDo = Int32.Parse( txtCapDo.Text);
            gioiTinh = radioNam.Checked;

            //Thực hiện cập nhật
            bool check = User.updateBUS(Username, gioiTinh, hoTen, capDo);

            if(check)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể cập nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }


    }
}
