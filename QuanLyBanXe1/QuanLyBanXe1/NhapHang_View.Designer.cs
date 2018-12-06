namespace QuanLyBanXe1
{
    partial class NhapHang_View
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
            this.btcthdnhap = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btncc = new System.Windows.Forms.Button();
            this.btnsx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btdoimk
            // 
            this.btdoimk.Location = new System.Drawing.Point(55, 65);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(118, 23);
            this.btdoimk.TabIndex = 18;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = true;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // btcthdnhap
            // 
            this.btcthdnhap.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btcthdnhap.Location = new System.Drawing.Point(208, 128);
            this.btcthdnhap.Name = "btcthdnhap";
            this.btcthdnhap.Size = new System.Drawing.Size(118, 23);
            this.btcthdnhap.TabIndex = 17;
            this.btcthdnhap.Text = "CT_Hóa đơn nhập";
            this.btcthdnhap.UseVisualStyleBackColor = true;
            this.btcthdnhap.Click += new System.EventHandler(this.btcthdnhap_Click);
            // 
            // bt12
            // 
            this.bt12.Location = new System.Drawing.Point(356, 128);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(122, 23);
            this.bt12.TabIndex = 16;
            this.bt12.Text = "Thoát";
            this.bt12.UseVisualStyleBackColor = true;
            this.bt12.Click += new System.EventHandler(this.bt12_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(356, 65);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(122, 23);
            this.bt9.TabIndex = 15;
            this.bt9.Text = "Hóa đơn nhập";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(52, 128);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(118, 23);
            this.bt2.TabIndex = 20;
            this.bt2.Text = "Loại xe";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(208, 65);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(118, 23);
            this.bt1.TabIndex = 19;
            this.bt1.Text = "Xe";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btncc
            // 
            this.btncc.Location = new System.Drawing.Point(208, 180);
            this.btncc.Name = "btncc";
            this.btncc.Size = new System.Drawing.Size(122, 23);
            this.btncc.TabIndex = 22;
            this.btncc.Text = "Nhà cung cấp";
            this.btncc.UseVisualStyleBackColor = true;
            // 
            // btnsx
            // 
            this.btnsx.Location = new System.Drawing.Point(52, 180);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(118, 23);
            this.btnsx.TabIndex = 21;
            this.btnsx.Text = "Nhà sản xuất";
            this.btnsx.UseVisualStyleBackColor = true;
            // 
            // NhapHang_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 250);
            this.Controls.Add(this.btncc);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btdoimk);
            this.Controls.Add(this.btcthdnhap);
            this.Controls.Add(this.bt12);
            this.Controls.Add(this.bt9);
            this.Name = "NhapHang_View";
            this.Text = "NhapHang_View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdoimk;
        private System.Windows.Forms.Button btcthdnhap;
        private System.Windows.Forms.Button bt12;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btncc;
        private System.Windows.Forms.Button btnsx;
    }
}