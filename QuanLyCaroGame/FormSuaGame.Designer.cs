namespace QuanLyCaroGame
{
    partial class FormSuaGame
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
            this.radioThang = new System.Windows.Forms.RadioButton();
            this.radioThua = new System.Windows.Forms.RadioButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioThang
            // 
            this.radioThang.AutoSize = true;
            this.radioThang.Location = new System.Drawing.Point(184, 67);
            this.radioThang.Name = "radioThang";
            this.radioThang.Size = new System.Drawing.Size(56, 17);
            this.radioThang.TabIndex = 0;
            this.radioThang.TabStop = true;
            this.radioThang.Text = "Thắng";
            this.radioThang.UseVisualStyleBackColor = true;
            // 
            // radioThua
            // 
            this.radioThua.AutoSize = true;
            this.radioThua.Location = new System.Drawing.Point(184, 90);
            this.radioThua.Name = "radioThua";
            this.radioThua.Size = new System.Drawing.Size(50, 17);
            this.radioThua.TabIndex = 1;
            this.radioThua.TabStop = true;
            this.radioThua.Text = "Thua";
            this.radioThua.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(134, 135);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(138, 20);
            this.txtTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả trận đấu";
            // 
            // FormSuaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.radioThua);
            this.Controls.Add(this.radioThang);
            this.Name = "FormSuaGame";
            this.Text = "FormSuaGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioThang;
        private System.Windows.Forms.RadioButton radioThua;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}