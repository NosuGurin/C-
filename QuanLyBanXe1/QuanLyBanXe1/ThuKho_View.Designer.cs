namespace QuanLyBanXe1
{
    partial class ThuKho_View
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
            this.btdoimk = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btkh = new System.Windows.Forms.Button();
            this.btncc = new System.Windows.Forms.Button();
            this.btnsx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btdoimk
            // 
            this.btdoimk.Location = new System.Drawing.Point(51, 80);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(118, 23);
            this.btdoimk.TabIndex = 18;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = true;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // bt12
            // 
            this.bt12.Location = new System.Drawing.Point(365, 208);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(122, 23);
            this.bt12.TabIndex = 16;
            this.bt12.Text = "Thoát";
            this.bt12.UseVisualStyleBackColor = true;
            this.bt12.Click += new System.EventHandler(this.bt12_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(51, 143);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(118, 23);
            this.bt2.TabIndex = 20;
            this.bt2.Text = "Loại xe";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(207, 80);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(118, 23);
            this.bt1.TabIndex = 19;
            this.bt1.Text = "Xe";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Báo cáo doanh thu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btkh
            // 
            this.btkh.Location = new System.Drawing.Point(207, 208);
            this.btkh.Name = "btkh";
            this.btkh.Size = new System.Drawing.Size(118, 23);
            this.btkh.TabIndex = 24;
            this.btkh.Text = "Khách hàng";
            this.btkh.UseVisualStyleBackColor = true;
            this.btkh.Click += new System.EventHandler(this.btkh_Click);
            // 
            // btncc
            // 
            this.btncc.Location = new System.Drawing.Point(365, 143);
            this.btncc.Name = "btncc";
            this.btncc.Size = new System.Drawing.Size(122, 23);
            this.btncc.TabIndex = 23;
            this.btncc.Text = "Nhà cung cấp";
            this.btncc.UseVisualStyleBackColor = true;
            this.btncc.Click += new System.EventHandler(this.btncc_Click);
            // 
            // btnsx
            // 
            this.btnsx.Location = new System.Drawing.Point(51, 208);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(118, 23);
            this.btnsx.TabIndex = 22;
            this.btnsx.Text = "Nhà sản xuất";
            this.btnsx.UseVisualStyleBackColor = true;
            this.btnsx.Click += new System.EventHandler(this.btnsx_Click);
            // 
            // ThuKho_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 270);
            this.Controls.Add(this.btkh);
            this.Controls.Add(this.btncc);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btdoimk);
            this.Controls.Add(this.bt12);
            this.Name = "ThuKho_View";
            this.Text = "Quản lý thủ kho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdoimk;
        private System.Windows.Forms.Button bt12;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btkh;
        private System.Windows.Forms.Button btncc;
        private System.Windows.Forms.Button btnsx;
    }
}