namespace QuanLyBanXe1
{
    partial class Xe_RP_View
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.XEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyBanXeDataSet = new QuanLyBanXe1.QuanLyBanXeDataSet();
            this.report_xe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.XETableAdapter = new QuanLyBanXe1.QuanLyBanXeDataSetTableAdapters.XETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.xEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.XEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // XEBindingSource
            // 
            this.XEBindingSource.DataMember = "XE";
            this.XEBindingSource.DataSource = this.QuanLyBanXeDataSet;
            // 
            // QuanLyBanXeDataSet
            // 
            this.QuanLyBanXeDataSet.DataSetName = "QuanLyBanXeDataSet";
            this.QuanLyBanXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_xe
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.XEBindingSource;
            this.report_xe.LocalReport.DataSources.Add(reportDataSource1);
            this.report_xe.LocalReport.ReportEmbeddedResource = "QuanLyBanXe1.Xe_RP.rdlc";
            this.report_xe.Location = new System.Drawing.Point(12, 63);
            this.report_xe.Name = "report_xe";
            this.report_xe.Size = new System.Drawing.Size(853, 362);
            this.report_xe.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XETableAdapter
            // 
            this.XETableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.xEBindingSource2;
            this.comboBox1.DisplayMember = "Maxe";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Maxe";
            // 
            // xEBindingSource1
            // 
            this.xEBindingSource1.DataMember = "XE";
            this.xEBindingSource1.DataSource = this.QuanLyBanXeDataSet;
            // 
            // xEBindingSource2
            // 
            this.xEBindingSource2.DataMember = "XE";
            this.xEBindingSource2.DataSource = this.QuanLyBanXeDataSet;
            // 
            // Xe_RP_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 466);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_xe);
            this.Name = "Xe_RP_View";
            this.Text = "Report Xe";
            this.Load += new System.EventHandler(this.Xe_RP_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_xe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource XEBindingSource;
        private QuanLyBanXeDataSet QuanLyBanXeDataSet;
        private QuanLyBanXeDataSetTableAdapters.XETableAdapter XETableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource xEBindingSource2;
        private System.Windows.Forms.BindingSource xEBindingSource1;
    }
}