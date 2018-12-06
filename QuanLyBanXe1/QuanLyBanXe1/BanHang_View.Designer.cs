namespace QuanLyBanXe1
{
    partial class BanHang_View
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
            this.btbaocaocthdb = new System.Windows.Forms.Button();
            this.btdoimk = new System.Windows.Forms.Button();
            this.btcthdban = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.bthdban = new System.Windows.Forms.Button();
            this.btkh = new System.Windows.Forms.Button();
            this.btloai = new System.Windows.Forms.Button();
            this.btxe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbaocaocthdb
            // 
            this.btbaocaocthdb.Location = new System.Drawing.Point(355, 40);
            this.btbaocaocthdb.Name = "btbaocaocthdb";
            this.btbaocaocthdb.Size = new System.Drawing.Size(118, 23);
            this.btbaocaocthdb.TabIndex = 25;
            this.btbaocaocthdb.Text = "Báo cáo bán hàng";
            this.btbaocaocthdb.UseVisualStyleBackColor = true;
            // 
            // btdoimk
            // 
            this.btdoimk.Location = new System.Drawing.Point(54, 40);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(118, 23);
            this.btdoimk.TabIndex = 24;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = true;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // btcthdban
            // 
            this.btcthdban.Location = new System.Drawing.Point(54, 168);
            this.btcthdban.Name = "btcthdban";
            this.btcthdban.Size = new System.Drawing.Size(118, 23);
            this.btcthdban.TabIndex = 23;
            this.btcthdban.Text = "CT_Hóa đơn bán";
            this.btcthdban.UseVisualStyleBackColor = true;
            this.btcthdban.Click += new System.EventHandler(this.btcthdban_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(355, 103);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(122, 23);
            this.btthoat.TabIndex = 22;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // bthdban
            // 
            this.bthdban.Location = new System.Drawing.Point(210, 103);
            this.bthdban.Name = "bthdban";
            this.bthdban.Size = new System.Drawing.Size(118, 23);
            this.bthdban.TabIndex = 21;
            this.bthdban.Text = "Hóa đơn bán";
            this.bthdban.UseVisualStyleBackColor = true;
            this.bthdban.Click += new System.EventHandler(this.bthdban_Click);
            // 
            // btkh
            // 
            this.btkh.Location = new System.Drawing.Point(210, 168);
            this.btkh.Name = "btkh";
            this.btkh.Size = new System.Drawing.Size(118, 23);
            this.btkh.TabIndex = 20;
            this.btkh.Text = "Khách hàng";
            this.btkh.UseVisualStyleBackColor = true;
            this.btkh.Click += new System.EventHandler(this.btkh_Click);
            // 
            // btloai
            // 
            this.btloai.Location = new System.Drawing.Point(54, 103);
            this.btloai.Name = "btloai";
            this.btloai.Size = new System.Drawing.Size(118, 23);
            this.btloai.TabIndex = 17;
            this.btloai.Text = "Loại xe";
            this.btloai.UseVisualStyleBackColor = true;
            this.btloai.Click += new System.EventHandler(this.btloai_Click);
            // 
            // btxe
            // 
            this.btxe.Location = new System.Drawing.Point(210, 40);
            this.btxe.Name = "btxe";
            this.btxe.Size = new System.Drawing.Size(118, 23);
            this.btxe.TabIndex = 16;
            this.btxe.Text = "Xe";
            this.btxe.UseVisualStyleBackColor = true;
            this.btxe.Click += new System.EventHandler(this.btxe_Click);
            // 
            // BanHang_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 243);
            this.Controls.Add(this.btbaocaocthdb);
            this.Controls.Add(this.btdoimk);
            this.Controls.Add(this.btcthdban);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bthdban);
            this.Controls.Add(this.btkh);
            this.Controls.Add(this.btloai);
            this.Controls.Add(this.btxe);
            this.Name = "BanHang_View";
            this.Text = "Quản lý bán hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbaocaocthdb;
        private System.Windows.Forms.Button btdoimk;
        private System.Windows.Forms.Button btcthdban;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bthdban;
        private System.Windows.Forms.Button btkh;
        private System.Windows.Forms.Button btloai;
        private System.Windows.Forms.Button btxe;
    }
}