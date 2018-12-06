using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanXe1;
using Microsoft.Reporting.WinForms;

namespace QuanLyBanXe1
{
    public partial class Xe_RP_View : Form
    {
        public Xe_RP_View()
        {
            InitializeComponent();
        }

        private void Xe_RP_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanXeDataSet.XE' table. You can move, or remove it, as needed.
            this.XETableAdapter.Fill(this.QuanLyBanXeDataSet.XE);

            this.report_xe.RefreshReport();

           SetParameters(comboBox1.SelectedValue.ToString());
            this.report_xe.RefreshReport();
        }

        private void SetParameters(string maxe)
        {
            ReportParameter rp = new ReportParameter("Maxe");
            rp.Values.Add(maxe);
            report_xe.LocalReport.SetParameters(rp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xe_View xe = new Xe_View();
            xe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetParameters(comboBox1.SelectedValue.ToString());
            report_xe.RefreshReport();
        }

       
    }
}
