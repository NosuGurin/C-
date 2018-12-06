namespace Persentation
{
    partial class Form2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtsiso = new System.Windows.Forms.TextBox();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bthocsinh = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsiso);
            this.groupBox1.Controls.Add(this.txttenlop);
            this.groupBox1.Controls.Add(this.txtmalop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.bthocsinh);
            this.groupBox2.Controls.Add(this.btload);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách lớp học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.Siso});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btthem
            // 
            this.btthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthem.Location = new System.Drawing.Point(3, 16);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 28);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Location = new System.Drawing.Point(78, 16);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 28);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Location = new System.Drawing.Point(153, 16);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 28);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btload
            // 
            this.btload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btload.Location = new System.Drawing.Point(228, 16);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(75, 28);
            this.btload.TabIndex = 3;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.btload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sỉ số";
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(122, 21);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(181, 20);
            this.txtmalop.TabIndex = 3;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(122, 66);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(181, 20);
            this.txttenlop.TabIndex = 4;
            // 
            // txtsiso
            // 
            this.txtsiso.Location = new System.Drawing.Point(387, 19);
            this.txtsiso.Name = "txtsiso";
            this.txtsiso.Size = new System.Drawing.Size(181, 20);
            this.txtsiso.TabIndex = 5;
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            // 
            // Siso
            // 
            this.Siso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Siso.DataPropertyName = "SiSo";
            this.Siso.HeaderText = "Sỉ số";
            this.Siso.Name = "Siso";
            this.Siso.ReadOnly = true;
            // 
            // bthocsinh
            // 
            this.bthocsinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.bthocsinh.Location = new System.Drawing.Point(303, 16);
            this.bthocsinh.Name = "bthocsinh";
            this.bthocsinh.Size = new System.Drawing.Size(75, 28);
            this.bthocsinh.TabIndex = 4;
            this.bthocsinh.Text = "Học Sinh";
            this.bthocsinh.UseVisualStyleBackColor = true;
            this.bthocsinh.Click += new System.EventHandler(this.bthocsinh_Click);
            // 
            // btthoat
            // 
            this.btthoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btthoat.Location = new System.Drawing.Point(378, 16);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 28);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsiso;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siso;
        private System.Windows.Forms.Button bthocsinh;
        private System.Windows.Forms.Button btthoat;
    }
}