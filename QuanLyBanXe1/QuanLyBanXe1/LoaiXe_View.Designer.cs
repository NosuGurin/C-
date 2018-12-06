namespace QuanLyBanXe1
{
    partial class LoaiXe_View
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.txttenlx = new System.Windows.Forms.TextBox();
            this.txtmalx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btload = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsx = new System.Windows.Forms.DataGridView();
            this.Maloaixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloaixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dacdiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grtimkiem = new System.Windows.Forms.GroupBox();
            this.rdbdacdiem = new System.Windows.Forms.RadioButton();
            this.rdbtlx = new System.Windows.Forms.RadioButton();
            this.rdbmlx = new System.Windows.Forms.RadioButton();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsx)).BeginInit();
            this.grtimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdd);
            this.groupBox1.Controls.Add(this.txttenlx);
            this.groupBox1.Controls.Add(this.txtmalx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại xe";
            // 
            // txtdd
            // 
            this.txtdd.Location = new System.Drawing.Point(440, 19);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(151, 20);
            this.txtdd.TabIndex = 5;
            // 
            // txttenlx
            // 
            this.txttenlx.Location = new System.Drawing.Point(176, 56);
            this.txttenlx.Name = "txttenlx";
            this.txttenlx.Size = new System.Drawing.Size(151, 20);
            this.txttenlx.TabIndex = 4;
            // 
            // txtmalx
            // 
            this.txtmalx.Location = new System.Drawing.Point(176, 19);
            this.txtmalx.Name = "txtmalx";
            this.txtmalx.Size = new System.Drawing.Size(151, 20);
            this.txtmalx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đặc điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btin);
            this.groupBox2.Controls.Add(this.btload);
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.bthuy);
            this.groupBox2.Controls.Add(this.btluu);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 47);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // btload
            // 
            this.btload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btload.Location = new System.Drawing.Point(516, 16);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(85, 28);
            this.btload.TabIndex = 6;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.btload_Click);
            // 
            // btthoat
            // 
            this.btthoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthoat.Location = new System.Drawing.Point(425, 16);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(91, 28);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bthuy
            // 
            this.bthuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.bthuy.Location = new System.Drawing.Point(341, 16);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(84, 28);
            this.bthuy.TabIndex = 4;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Location = new System.Drawing.Point(255, 16);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(86, 28);
            this.btluu.TabIndex = 3;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Location = new System.Drawing.Point(169, 16);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(86, 28);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Location = new System.Drawing.Point(89, 16);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 28);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthem.Location = new System.Drawing.Point(3, 16);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(86, 28);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsx);
            this.groupBox3.Location = new System.Drawing.Point(12, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 177);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách loại xe";
            // 
            // dsx
            // 
            this.dsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaixe,
            this.Tenloaixe,
            this.Dacdiem});
            this.dsx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsx.Location = new System.Drawing.Point(3, 16);
            this.dsx.Name = "dsx";
            this.dsx.Size = new System.Drawing.Size(687, 158);
            this.dsx.TabIndex = 0;
            this.dsx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsx_CellClick);
            // 
            // Maloaixe
            // 
            this.Maloaixe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Maloaixe.DataPropertyName = "Maloaixe";
            this.Maloaixe.HeaderText = "Mã loại xe";
            this.Maloaixe.Name = "Maloaixe";
            // 
            // Tenloaixe
            // 
            this.Tenloaixe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenloaixe.DataPropertyName = "Tenloaixe";
            this.Tenloaixe.HeaderText = "Tên loại xe";
            this.Tenloaixe.Name = "Tenloaixe";
            // 
            // Dacdiem
            // 
            this.Dacdiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dacdiem.DataPropertyName = "Dacdiem";
            this.Dacdiem.HeaderText = "Đặc điểm";
            this.Dacdiem.Name = "Dacdiem";
            // 
            // grtimkiem
            // 
            this.grtimkiem.Controls.Add(this.rdbdacdiem);
            this.grtimkiem.Controls.Add(this.rdbtlx);
            this.grtimkiem.Controls.Add(this.rdbmlx);
            this.grtimkiem.Controls.Add(this.bttimkiem);
            this.grtimkiem.Controls.Add(this.label8);
            this.grtimkiem.Controls.Add(this.txttimkiem);
            this.grtimkiem.Location = new System.Drawing.Point(12, 164);
            this.grtimkiem.Name = "grtimkiem";
            this.grtimkiem.Size = new System.Drawing.Size(693, 67);
            this.grtimkiem.TabIndex = 5;
            this.grtimkiem.TabStop = false;
            this.grtimkiem.Text = "Tìm kiếm";
            // 
            // rdbdacdiem
            // 
            this.rdbdacdiem.AutoSize = true;
            this.rdbdacdiem.Location = new System.Drawing.Point(408, 19);
            this.rdbdacdiem.Name = "rdbdacdiem";
            this.rdbdacdiem.Size = new System.Drawing.Size(71, 17);
            this.rdbdacdiem.TabIndex = 12;
            this.rdbdacdiem.TabStop = true;
            this.rdbdacdiem.Text = "Đặc điểm";
            this.rdbdacdiem.UseVisualStyleBackColor = true;
            // 
            // rdbtlx
            // 
            this.rdbtlx.AutoSize = true;
            this.rdbtlx.Location = new System.Drawing.Point(270, 19);
            this.rdbtlx.Name = "rdbtlx";
            this.rdbtlx.Size = new System.Drawing.Size(77, 17);
            this.rdbtlx.TabIndex = 11;
            this.rdbtlx.TabStop = true;
            this.rdbtlx.Text = "Tên loại xe";
            this.rdbtlx.UseVisualStyleBackColor = true;
            // 
            // rdbmlx
            // 
            this.rdbmlx.AutoSize = true;
            this.rdbmlx.Checked = true;
            this.rdbmlx.Location = new System.Drawing.Point(126, 19);
            this.rdbmlx.Name = "rdbmlx";
            this.rdbmlx.Size = new System.Drawing.Size(73, 17);
            this.rdbmlx.TabIndex = 10;
            this.rdbmlx.TabStop = true;
            this.rdbmlx.Text = "Mã loại xe";
            this.rdbmlx.UseVisualStyleBackColor = true;
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
            this.btin.Location = new System.Drawing.Point(601, 16);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(91, 28);
            this.btin.TabIndex = 7;
            this.btin.Text = "In";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // LoaiXe_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 416);
            this.Controls.Add(this.grtimkiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoaiXe_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại xe";
            this.Load += new System.EventHandler(this.LoaiXe_View_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsx)).EndInit();
            this.grtimkiem.ResumeLayout(false);
            this.grtimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.TextBox txttenlx;
        private System.Windows.Forms.TextBox txtmalx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView dsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dacdiem;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.GroupBox grtimkiem;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rdbdacdiem;
        private System.Windows.Forms.RadioButton rdbtlx;
        private System.Windows.Forms.RadioButton rdbmlx;
        private System.Windows.Forms.Button btin;
    }
}