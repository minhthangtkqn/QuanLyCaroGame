﻿namespace QuanLyCaroGame
{
    partial class FormThemGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemGame));
            this.btnThemGame = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboThoiGian = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioThang = new System.Windows.Forms.RadioButton();
            this.radioThua = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnThemGame
            // 
            this.btnThemGame.Font = new System.Drawing.Font("MS Reference Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGame.Location = new System.Drawing.Point(12, 248);
            this.btnThemGame.Name = "btnThemGame";
            this.btnThemGame.Size = new System.Drawing.Size(309, 36);
            this.btnThemGame.TabIndex = 5;
            this.btnThemGame.Text = "THÊM";
            this.btnThemGame.UseVisualStyleBackColor = true;
            this.btnThemGame.Click += new System.EventHandler(this.btnThemGame_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 66);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÊM KẾT QUẢ\r\nTRẬN ĐẤU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboThoiGian
            // 
            this.comboThoiGian.FormattingEnabled = true;
            this.comboThoiGian.Location = new System.Drawing.Point(93, 197);
            this.comboThoiGian.Name = "comboThoiGian";
            this.comboThoiGian.Size = new System.Drawing.Size(222, 21);
            this.comboThoiGian.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Người chơi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thời gian";
            // 
            // radioThang
            // 
            this.radioThang.AutoSize = true;
            this.radioThang.Location = new System.Drawing.Point(93, 162);
            this.radioThang.Name = "radioThang";
            this.radioThang.Size = new System.Drawing.Size(56, 17);
            this.radioThang.TabIndex = 2;
            this.radioThang.TabStop = true;
            this.radioThang.Text = "Thắng";
            this.radioThang.UseVisualStyleBackColor = true;
            // 
            // radioThua
            // 
            this.radioThua.AutoSize = true;
            this.radioThua.Location = new System.Drawing.Point(195, 162);
            this.radioThua.Name = "radioThua";
            this.radioThua.Size = new System.Drawing.Size(50, 17);
            this.radioThua.TabIndex = 3;
            this.radioThua.TabStop = true;
            this.radioThua.Text = "Thua";
            this.radioThua.UseVisualStyleBackColor = true;
            // 
            // FormThemGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 296);
            this.Controls.Add(this.radioThua);
            this.Controls.Add(this.radioThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboThoiGian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnThemGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThemGame";
            this.Text = "Thêm trận đấu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemGame;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboThoiGian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioThang;
        private System.Windows.Forms.RadioButton radioThua;
    }
}