namespace QuanLyBanXe1
{
    partial class QuanLyBanXe_View
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
            this.btxe = new System.Windows.Forms.Button();
            this.btloai = new System.Windows.Forms.Button();
            this.btnsx = new System.Windows.Forms.Button();
            this.btncc = new System.Windows.Forms.Button();
            this.btkh = new System.Windows.Forms.Button();
            this.btnv = new System.Windows.Forms.Button();
            this.bthdban = new System.Windows.Forms.Button();
            this.bthdnhap = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btcthdnhap = new System.Windows.Forms.Button();
            this.btcthdban = new System.Windows.Forms.Button();
            this.btdoimk = new System.Windows.Forms.Button();
            this.btbaocaocthdb = new System.Windows.Forms.Button();
            this.btbccthdn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btxe
            // 
            this.btxe.Location = new System.Drawing.Point(193, 42);
            this.btxe.Name = "btxe";
            this.btxe.Size = new System.Drawing.Size(118, 23);
            this.btxe.TabIndex = 0;
            this.btxe.Text = "Xe";
            this.btxe.UseVisualStyleBackColor = true;
            this.btxe.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btloai
            // 
            this.btloai.Location = new System.Drawing.Point(37, 105);
            this.btloai.Name = "btloai";
            this.btloai.Size = new System.Drawing.Size(118, 23);
            this.btloai.TabIndex = 1;
            this.btloai.Text = "Loại xe";
            this.btloai.UseVisualStyleBackColor = true;
            this.btloai.Click += new System.EventHandler(this.bt2_Click);
            // 
            // btnsx
            // 
            this.btnsx.Location = new System.Drawing.Point(37, 170);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(118, 23);
            this.btnsx.TabIndex = 2;
            this.btnsx.Text = "Nhà sản xuất";
            this.btnsx.UseVisualStyleBackColor = true;
            this.btnsx.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btncc
            // 
            this.btncc.Location = new System.Drawing.Point(338, 105);
            this.btncc.Name = "btncc";
            this.btncc.Size = new System.Drawing.Size(122, 23);
            this.btncc.TabIndex = 3;
            this.btncc.Text = "Nhà cung cấp";
            this.btncc.UseVisualStyleBackColor = true;
            this.btncc.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btkh
            // 
            this.btkh.Location = new System.Drawing.Point(193, 170);
            this.btkh.Name = "btkh";
            this.btkh.Size = new System.Drawing.Size(118, 23);
            this.btkh.TabIndex = 5;
            this.btkh.Text = "Khách hàng";
            this.btkh.UseVisualStyleBackColor = true;
            this.btkh.Click += new System.EventHandler(this.bt6_Click);
            // 
            // btnv
            // 
            this.btnv.Location = new System.Drawing.Point(193, 227);
            this.btnv.Name = "btnv";
            this.btnv.Size = new System.Drawing.Size(118, 23);
            this.btnv.TabIndex = 6;
            this.btnv.Text = "Nhân viên";
            this.btnv.UseVisualStyleBackColor = true;
            this.btnv.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bthdban
            // 
            this.bthdban.Location = new System.Drawing.Point(193, 105);
            this.bthdban.Name = "bthdban";
            this.bthdban.Size = new System.Drawing.Size(118, 23);
            this.bthdban.TabIndex = 7;
            this.bthdban.Text = "Hóa đơn bán";
            this.bthdban.UseVisualStyleBackColor = true;
            this.bthdban.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bthdnhap
            // 
            this.bthdnhap.Location = new System.Drawing.Point(338, 42);
            this.bthdnhap.Name = "bthdnhap";
            this.bthdnhap.Size = new System.Drawing.Size(122, 23);
            this.bthdnhap.TabIndex = 8;
            this.bthdnhap.Text = "Hóa đơn nhập";
            this.bthdnhap.UseVisualStyleBackColor = true;
            this.bthdnhap.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(338, 227);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(122, 23);
            this.btthoat.TabIndex = 11;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.bt12_Click);
            // 
            // btcthdnhap
            // 
            this.btcthdnhap.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btcthdnhap.Location = new System.Drawing.Point(338, 170);
            this.btcthdnhap.Name = "btcthdnhap";
            this.btcthdnhap.Size = new System.Drawing.Size(118, 23);
            this.btcthdnhap.TabIndex = 12;
            this.btcthdnhap.Text = "CT_Hóa đơn nhập";
            this.btcthdnhap.UseVisualStyleBackColor = true;
            this.btcthdnhap.Click += new System.EventHandler(this.btcthdnhap_Click);
            // 
            // btcthdban
            // 
            this.btcthdban.Location = new System.Drawing.Point(37, 227);
            this.btcthdban.Name = "btcthdban";
            this.btcthdban.Size = new System.Drawing.Size(118, 23);
            this.btcthdban.TabIndex = 13;
            this.btcthdban.Text = "CT_Hóa đơn bán";
            this.btcthdban.UseVisualStyleBackColor = true;
            this.btcthdban.Click += new System.EventHandler(this.btcthdban_Click);
            // 
            // btdoimk
            // 
            this.btdoimk.Location = new System.Drawing.Point(37, 42);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(118, 23);
            this.btdoimk.TabIndex = 14;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = true;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // btbaocaocthdb
            // 
            this.btbaocaocthdb.Location = new System.Drawing.Point(37, 277);
            this.btbaocaocthdb.Name = "btbaocaocthdb";
            this.btbaocaocthdb.Size = new System.Drawing.Size(118, 23);
            this.btbaocaocthdb.TabIndex = 15;
            this.btbaocaocthdb.Text = "Báo cáo bán hàng";
            this.btbaocaocthdb.UseVisualStyleBackColor = true;
            this.btbaocaocthdb.Click += new System.EventHandler(this.btbaocaocthdb_Click);
            // 
            // btbccthdn
            // 
            this.btbccthdn.Location = new System.Drawing.Point(193, 277);
            this.btbccthdn.Name = "btbccthdn";
            this.btbccthdn.Size = new System.Drawing.Size(118, 23);
            this.btbccthdn.TabIndex = 16;
            this.btbccthdn.Text = "Báo cáo nhập hàng";
            this.btbccthdn.UseVisualStyleBackColor = true;
            this.btbccthdn.Click += new System.EventHandler(this.btbccthdn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Báo cáo doanh thu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyBanXe_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbccthdn);
            this.Controls.Add(this.btbaocaocthdb);
            this.Controls.Add(this.btdoimk);
            this.Controls.Add(this.btcthdban);
            this.Controls.Add(this.btcthdnhap);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bthdnhap);
            this.Controls.Add(this.bthdban);
            this.Controls.Add(this.btnv);
            this.Controls.Add(this.btkh);
            this.Controls.Add(this.btncc);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.btloai);
            this.Controls.Add(this.btxe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyBanXe_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán xe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btxe;
        private System.Windows.Forms.Button btloai;
        private System.Windows.Forms.Button btnsx;
        private System.Windows.Forms.Button btncc;
        private System.Windows.Forms.Button btkh;
        private System.Windows.Forms.Button btnv;
        private System.Windows.Forms.Button bthdban;
        private System.Windows.Forms.Button bthdnhap;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btcthdnhap;
        private System.Windows.Forms.Button btcthdban;
        private System.Windows.Forms.Button btdoimk;
        private System.Windows.Forms.Button btbaocaocthdb;
        private System.Windows.Forms.Button btbccthdn;
        private System.Windows.Forms.Button button1;
    }
}