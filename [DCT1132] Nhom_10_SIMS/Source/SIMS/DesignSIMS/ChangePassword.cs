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
    public partial class ChangePassword : Form
    {
        private UserBLL userBLL;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(UserBLL userBLL_)
        {
            InitializeComponent();
            this.userBLL = userBLL_;
        }



        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtID.Text = userBLL.getname();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string iduser=userBLL.getid();
            string oldpassword=txtOldpassword.Text;
            string newpassword = txtNewpassword.Text;
            string retypepassword = txtRetypepassword.Text;
            if (!userBLL.verifypassword(newpassword, retypepassword))
            {
                lblError.Text = "*The passwords do not match";
            }
            else
            {
                if(!userBLL.verifylogin(iduser,oldpassword))
                {
                    lblError.Text = "*Old passwords is not correct";
                }
                else
                {
                    userBLL.changepassword(newpassword);
                    MessageBox.Show("Change password success!", "NOTICE");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
