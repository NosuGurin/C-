using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();
        private DataTable dtuser=new DataTable();
        private DataTable dtlistuser=new DataTable();
        private int userrole;
        private string username;
        private string userid;
        private string password;

        ~UserBLL()
        {
        }

        public Boolean verifylogin(string iduser_, string password_)
        {
            if (userid == iduser_ && password == password_)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verifyuser(string iduser)
        {
            getuser(iduser);
            if (dtuser.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                password = Convert.ToString(dtuser.Rows[0]["password"]);
                username = Convert.ToString(dtuser.Rows[0]["username"]);
                userrole = Convert.ToInt16(dtuser.Rows[0]["idrole"]);
                userid = iduser;
                return true;
            }
        }

        public Boolean verifypassword(string newpassword, string retypepassword)
        {
            if (newpassword == retypepassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void changepassword(string newpassword)
        {
            userDAL.changepassword(userid, newpassword);
            getuser(userid);
        }

        private void getuser(string iduser)
        {
            dtuser = userDAL.verifylogin(iduser);
        }

        public DataTable loaduser()
        {
            DataTable dt = new DataTable();
            dt = userDAL.loaduser();
            foreach (DataRow row in dt.Rows)
            {
                row["username"] = row["rolename"].ToString() + " " + row["username"].ToString();
            }
            return dt;
        }

        public string getname()
        {
            return username;
        }

        public string getid()
        {
            return userid;
        }

        public int getrole()
        {
            return userrole;
        }

    }
}
