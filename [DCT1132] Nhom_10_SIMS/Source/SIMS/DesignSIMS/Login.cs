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
using System.Threading;

namespace DesignSIMS
{
    public partial class Login : Form
    {
        private UserBLL userBLL;

        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                userBLL = new UserBLL();
                string id = txtID.Text;
                id = id.ToUpper().ToString();
                string pass = txtPass.Text;
                if (!userBLL.verifyuser(id))
                {
                    lblError.Text = "*ID not exists";
                }
                else
                    if (userBLL.verifylogin(id, pass))
                    {
                        this.Hide();
                        Form form = new Form();
                        switch (userBLL.getrole())
                        {
                            case 1:
                                form = new SPSpace(userBLL);
                                break;
                            case 2:
                                form = new SMSpace(userBLL);
                                break;
                            case 3:
                                form = new IMSpace(userBLL);
                                break;
                            case 4:
                                form = new AdminSpace(userBLL);
                                break;
                        }
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "*Your password is not correct";
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        
    }
}
