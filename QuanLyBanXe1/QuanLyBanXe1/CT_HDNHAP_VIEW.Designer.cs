namespace QuanLyBanXe1
{
    partial class CT_HDNHAP_VIEW
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dscthdn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmahdn = new System.Windows.Forms.ComboBox();
            this.cbmaxe = new System.Windows.Forms.ComboBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.Mahdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grtimkiem = new System.Windows.Forms.GroupBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btload = new System.Windows.Forms.Button();
            this.rdbmahdn = new System.Windows.Forms.RadioButton();
            this.rdbmaxe = new System.Windows.Forms.RadioButton();
            this.rdbsl = new System.Windows.Forms.RadioButton();
            this.rdbdg = new System.Windows.Forms.RadioButton();
            this.rdbtt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscthdn)).BeginInit();
            this.grtimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtthanhtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdg);
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.cbmaxe);
            this.groupBox1.Controls.Add(this.cbmahdn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết hóa đơn nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btload);
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.bthuy);
            this.groupBox2.Controls.Add(this.btluu);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dscthdn);
            this.groupBox3.Location = new System.Drawing.Point(12, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // dscthdn
            // 
            this.dscthdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dscthdn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahdn,
            this.Maxe,
            this.Soluong,
            this.Dongia,
            this.Thanhtien});
            this.dscthdn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dscthdn.Location = new System.Drawing.Point(3, 16);
            this.dscthdn.Name = "dscthdn";
            this.dscthdn.Size = new System.Drawing.Size(739, 162);
            this.dscthdn.TabIndex = 1;
            this.dscthdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dscthdn_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // cbmahdn
            // 
            this.cbmahdn.FormattingEnabled = true;
            this.cbmahdn.Location = new System.Drawing.Point(152, 25);
            this.cbmahdn.Name = "cbmahdn";
            this.cbmahdn.Size = new System.Drawing.Size(121, 21);
            this.cbmahdn.TabIndex = 4;
            // 
            // cbmaxe
            // 
            this.cbmaxe.FormattingEnabled = true;
            this.cbmaxe.Location = new System.Drawing.Point(152, 70);
            this.cbmaxe.Name = "cbmaxe";
            this.cbmaxe.Size = new System.Drawing.Size(121, 21);
            this.cbmaxe.TabIndex = 5;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(378, 26);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 6;
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(378, 71);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(100, 20);
            this.txtdg.TabIndex = 7;
            // 
            // btthem
            // 
            this.btthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthem.Location = new System.Drawing.Point(3, 16);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(82, 30);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Location = new System.Drawing.Point(85, 16);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(82, 30);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Location = new System.Drawing.Point(167, 16);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(82, 30);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Location = new System.Drawing.Point(249, 16);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(82, 30);
            this.btluu.TabIndex = 3;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bthuy
            // 
            this.bthuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.bthuy.Location = new System.Drawing.Point(331, 16);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(82, 30);
            this.bthuy.TabIndex = 4;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btthoat
            // 
            this.btthoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthoat.Location = new System.Drawing.Point(413, 16);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(82, 30);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thành tiền";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(611, 25);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(100, 20);
            this.txtthanhtien.TabIndex = 9;
            // 
            // Mahdn
            // 
            this.Mahdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mahdn.DataPropertyName = "Mahdnhap";
            this.Mahdn.HeaderText = "Mã hóa đơn nhập";
            this.Mahdn.Name = "Mahdn";
            this.Mahdn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Maxe
            // 
            this.Maxe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Maxe.DataPropertyName = "Maxe";
            this.Maxe.HeaderText = "Mã xe";
            this.Maxe.Name = "Maxe";
            // 
            // Soluong
            // 
            this.Soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Dongia
            // 
            this.Dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dongia.DataPropertyName = "Dongia";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Format = "N0";
            this.Dongia.DefaultCellStyle = dataGridViewCellStyle11;
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            // 
            // Thanhtien
            // 
            this.Thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thanhtien.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Format = "N0";
            this.Thanhtien.DefaultCellStyle = dataGridViewCellStyle12;
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            // 
            // grtimkiem
            // 
            this.grtimkiem.Controls.Add(this.rdbtt);
            this.grtimkiem.Controls.Add(this.rdbdg);
            this.grtimkiem.Controls.Add(this.rdbsl);
            this.grtimkiem.Controls.Add(this.rdbmaxe);
            this.grtimkiem.Controls.Add(this.rdbmahdn);
            this.grtimkiem.Controls.Add(this.bttimkiem);
            this.grtimkiem.Controls.Add(this.label8);
            this.grtimkiem.Controls.Add(this.txttimkiem);
            this.grtimkiem.Location = new System.Drawing.Point(12, 187);
            this.grtimkiem.Name = "grtimkiem";
            this.grtimkiem.Size = new System.Drawing.Size(745, 79);
            this.grtimkiem.TabIndex = 6;
            this.grtimkiem.TabStop = false;
            this.grtimkiem.Text = "Tìm kiếm";
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
            // btload
            // 
            this.btload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btload.Location = new System.Drawing.Point(495, 16);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(82, 30);
            this.btload.TabIndex = 6;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.btload_Click);
            // 
            // rdbmahdn
            // 
            this.rdbmahdn.AutoSize = true;
            this.rdbmahdn.Checked = true;
            this.rdbmahdn.Location = new System.Drawing.Point(85, 19);
            this.rdbmahdn.Name = "rdbmahdn";
            this.rdbmahdn.Size = new System.Drawing.Size(110, 17);
            this.rdbmahdn.TabIndex = 10;
            this.rdbmahdn.TabStop = true;
            this.rdbmahdn.Text = "Mã hóa đơn nhập";
            this.rdbmahdn.UseVisualStyleBackColor = true;
            // 
            // rdbmaxe
            // 
            this.rdbmaxe.AutoSize = true;
            this.rdbmaxe.Location = new System.Drawing.Point(219, 19);
            this.rdbmaxe.Name = "rdbmaxe";
            this.rdbmaxe.Size = new System.Drawing.Size(54, 17);
            this.rdbmaxe.TabIndex = 11;
            this.rdbmaxe.Text = "Mã xe";
            this.rdbmaxe.UseVisualStyleBackColor = true;
            // 
            // rdbsl
            // 
            this.rdbsl.AutoSize = true;
            this.rdbsl.Location = new System.Drawing.Point(304, 19);
            this.rdbsl.Name = "rdbsl";
            this.rdbsl.Size = new System.Drawing.Size(67, 17);
            this.rdbsl.TabIndex = 12;
            this.rdbsl.Text = "Số lượng";
            this.rdbsl.UseVisualStyleBackColor = true;
            // 
            // rdbdg
            // 
            this.rdbdg.AutoSize = true;
            this.rdbdg.Location = new System.Drawing.Point(413, 19);
            this.rdbdg.Name = "rdbdg";
            this.rdbdg.Size = new System.Drawing.Size(62, 17);
            this.rdbdg.TabIndex = 13;
            this.rdbdg.Text = "Đơn giá";
            this.rdbdg.UseVisualStyleBackColor = true;
            // 
            // rdbtt
            // 
            this.rdbtt.AutoSize = true;
            this.rdbtt.Location = new System.Drawing.Point(529, 19);
            this.rdbtt.Name = "rdbtt";
            this.rdbtt.Size = new System.Drawing.Size(76, 17);
            this.rdbtt.TabIndex = 14;
            this.rdbtt.Text = "Thành tiền";
            this.rdbtt.UseVisualStyleBackColor = true;
            // 
            // CT_HDNHAP_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 465);
            this.Controls.Add(this.grtimkiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CT_HDNHAP_VIEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.CT_HDNHAP_VIEW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscthdn)).EndInit();
            this.grtimkiem.ResumeLayout(false);
            this.grtimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.ComboBox cbmaxe;
        private System.Windows.Forms.ComboBox cbmahdn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dscthdn;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.GroupBox grtimkiem;
        private System.Windows.Forms.RadioButton rdbtt;
        private System.Windows.Forms.RadioButton rdbdg;
        private System.Windows.Forms.RadioButton rdbsl;
        private System.Windows.Forms.RadioButton rdbmaxe;
        private System.Windows.Forms.RadioButton rdbmahdn;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}