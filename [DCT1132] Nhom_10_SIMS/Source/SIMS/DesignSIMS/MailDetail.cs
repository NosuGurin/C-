using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DesignSIMS
{
    public partial class MailDetail : Form
    {
        private DataRow mail;
        private MailBLL mailBLL = new MailBLL();
        public MailDetail()
        {
            InitializeComponent();
        }

        public MailDetail(DataRow mail_)
        {
            InitializeComponent();
            this.mail = mail_;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            mailBLL.confirmmail(mail[0].ToString());
            MessageBox.Show("Success", "NOTICE");
            this.Close();
        }

        private void MailDetail_Load(object sender, EventArgs e)
        {
            txtFrom.Text = mail[1].ToString();
            txtSubject.Text = mail[2].ToString();
            txtContent.Text = mail[3].ToString();
        }
    }
}
