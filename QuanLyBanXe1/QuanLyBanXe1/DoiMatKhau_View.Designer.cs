namespace QuanLyBanXe1
{
    partial class DoiMatKhau_View
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtmkmoi1 = new System.Windows.Forms.TextBox();
            this.btdoimk = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.lbstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(201, 23);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(192, 20);
            this.txtmkcu.TabIndex = 3;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(201, 74);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(192, 20);
            this.txtmkmoi.TabIndex = 4;
            // 
            // txtmkmoi1
            // 
            this.txtmkmoi1.Location = new System.Drawing.Point(201, 127);
            this.txtmkmoi1.Name = "txtmkmoi1";
            this.txtmkmoi1.Size = new System.Drawing.Size(192, 20);
            this.txtmkmoi1.TabIndex = 5;
            // 
            // btdoimk
            // 
            this.btdoimk.Location = new System.Drawing.Point(83, 208);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(80, 32);
            this.btdoimk.TabIndex = 6;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = true;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(191, 208);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(80, 32);
            this.bthuy.TabIndex = 7;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(296, 208);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 32);
            this.btthoat.TabIndex = 8;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(51, 175);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(10, 13);
            this.lbstatus.TabIndex = 9;
            this.lbstatus.Text = ".";
            // 
            // DoiMatKhau_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 272);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btdoimk);
            this.Controls.Add(this.txtmkmoi1);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau_View";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtmkmoi1;
        private System.Windows.Forms.Button btdoimk;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label lbstatus;
    }
}