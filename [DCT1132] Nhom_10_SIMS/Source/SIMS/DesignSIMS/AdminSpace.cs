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
    public partial class AdminSpace : Form
    {
        private UserBLL userBLL = new UserBLL();

        public AdminSpace()
        {
            InitializeComponent();
        }

        public AdminSpace(UserBLL userBLL_)
        {
            InitializeComponent();
            this.userBLL = userBLL_;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword formchangepassword = new ChangePassword(userBLL);
            formchangepassword.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formlogin = new Login();
            formlogin.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminSpace_Load(object sender, EventArgs e)
        {

        }
    }
}
