namespace QuanLyBanXe1
{
    partial class KhachHang_View
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btload = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dskh = new System.Windows.Forms.DataGridView();
            this.Makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grtimkiem = new System.Windows.Forms.GroupBox();
            this.rdbdiachi = new System.Windows.Forms.RadioButton();
            this.rdbdienthoai = new System.Windows.Forms.RadioButton();
            this.rdbtenkh = new System.Windows.Forms.RadioButton();
            this.rdbmakh = new System.Windows.Forms.RadioButton();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btin = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dskh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grtimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btin);
            this.groupBox2.Controls.Add(this.btload);
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btluu);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // btload
            // 
            this.btload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btload.Location = new System.Drawing.Point(410, 16);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(75, 27);
            this.btload.TabIndex = 12;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.bttiemkiem_Click);
            // 
            // btthoat
            // 
            this.btthoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthoat.Location = new System.Drawing.Point(334, 16);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(76, 27);
            this.btthoat.TabIndex = 9;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click_1);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Location = new System.Drawing.Point(253, 16);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(81, 27);
            this.btluu.TabIndex = 8;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click_1);
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Location = new System.Drawing.Point(175, 16);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(78, 27);
            this.btxoa.TabIndex = 7;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Location = new System.Drawing.Point(93, 16);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(82, 27);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btthem
            // 
            this.btthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthem.Location = new System.Drawing.Point(3, 16);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(90, 27);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dskh);
            this.groupBox3.Location = new System.Drawing.Point(13, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 274);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dskh
            // 
            this.dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dskh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makh,
            this.Tenkh,
            this.Dienthoai,
            this.Diachi});
            this.dskh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dskh.Location = new System.Drawing.Point(3, 16);
            this.dskh.Name = "dskh";
            this.dskh.Size = new System.Drawing.Size(744, 255);
            this.dskh.TabIndex = 1;
            this.dskh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dskh_CellClick_1);
            // 
            // Makh
            // 
            this.Makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Makh.DataPropertyName = "Makh";
            this.Makh.HeaderText = "Mã khách hàng";
            this.Makh.Name = "Makh";
            // 
            // Tenkh
            // 
            this.Tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkh.DataPropertyName = "Tenkh";
            this.Tenkh.HeaderText = "Tên khách hàng";
            this.Tenkh.Name = "Tenkh";
            // 
            // Dienthoai
            // 
            this.Dienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.Name = "Dienthoai";
            // 
            // Diachi
            // 
            this.Diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(484, 76);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(166, 20);
            this.txtdiachi.TabIndex = 15;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(484, 23);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(166, 20);
            this.txtdienthoai.TabIndex = 14;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(203, 76);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(166, 20);
            this.txttenkh.TabIndex = 13;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(203, 23);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(166, 20);
            this.txtmakh.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã khách hàng";
            // 
            // grtimkiem
            // 
            this.grtimkiem.Controls.Add(this.rdbdiachi);
            this.grtimkiem.Controls.Add(this.rdbdienthoai);
            this.grtimkiem.Controls.Add(this.rdbtenkh);
            this.grtimkiem.Controls.Add(this.rdbmakh);
            this.grtimkiem.Controls.Add(this.bttimkiem);
            this.grtimkiem.Controls.Add(this.label8);
            this.grtimkiem.Controls.Add(this.txttimkiem);
            this.grtimkiem.Location = new System.Drawing.Point(13, 186);
            this.grtimkiem.Name = "grtimkiem";
            this.grtimkiem.Size = new System.Drawing.Size(750, 67);
            this.grtimkiem.TabIndex = 6;
            this.grtimkiem.TabStop = false;
            this.grtimkiem.Text = "Tìm kiếm";
            // 
            // rdbdiachi
            // 
            this.rdbdiachi.AutoSize = true;
            this.rdbdiachi.Location = new System.Drawing.Point(526, 19);
            this.rdbdiachi.Name = "rdbdiachi";
            this.rdbdiachi.Size = new System.Drawing.Size(58, 17);
            this.rdbdiachi.TabIndex = 13;
            this.rdbdiachi.Text = "Địa chỉ";
            this.rdbdiachi.UseVisualStyleBackColor = true;
            // 
            // rdbdienthoai
            // 
            this.rdbdienthoai.AutoSize = true;
            this.rdbdienthoai.Location = new System.Drawing.Point(409, 19);
            this.rdbdienthoai.Name = "rdbdienthoai";
            this.rdbdienthoai.Size = new System.Drawing.Size(73, 17);
            this.rdbdienthoai.TabIndex = 12;
            this.rdbdienthoai.Text = "Điện thoại";
            this.rdbdienthoai.UseVisualStyleBackColor = true;
            // 
            // rdbtenkh
            // 
            this.rdbtenkh.AutoSize = true;
            this.rdbtenkh.Location = new System.Drawing.Point(273, 19);
            this.rdbtenkh.Name = "rdbtenkh";
            this.rdbtenkh.Size = new System.Drawing.Size(104, 17);
            this.rdbtenkh.TabIndex = 11;
            this.rdbtenkh.Text = "Tên khách hàng";
            this.rdbtenkh.UseVisualStyleBackColor = true;
            // 
            // rdbmakh
            // 
            this.rdbmakh.AutoSize = true;
            this.rdbmakh.Checked = true;
            this.rdbmakh.Location = new System.Drawing.Point(140, 19);
            this.rdbmakh.Name = "rdbmakh";
            this.rdbmakh.Size = new System.Drawing.Size(100, 17);
            this.rdbmakh.TabIndex = 10;
            this.rdbmakh.TabStop = true;
            this.rdbmakh.Text = "Mã khách hàng";
            this.rdbmakh.UseVisualStyleBackColor = true;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(569, 40);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(84, 23);
            this.bttimkiem.TabIndex = 9;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nhập thông tin";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(113, 42);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(437, 20);
            this.txttimkiem.TabIndex = 7;
            // 
            // btin
            // 
            this.btin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btin.Location = new System.Drawing.Point(485, 16);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(75, 27);
            this.btin.TabIndex = 13;
            this.btin.Text = "In";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // KhachHang_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 535);
            this.Controls.Add(this.grtimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KhachHang_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_View_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dskh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grtimkiem.ResumeLayout(false);
            this.grtimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dskh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.GroupBox grtimkiem;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rdbdiachi;
        private System.Windows.Forms.RadioButton rdbdienthoai;
        private System.Windows.Forms.RadioButton rdbtenkh;
        private System.Windows.Forms.RadioButton rdbmakh;
        private System.Windows.Forms.Button btin;

    }
}