using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class MailBLL
    {
        MailDAL mailDAL = new MailDAL();

        public void sendmail(string idsend, string idreceive, string subject, string content)
        {
            mailDAL.sendmail(idsend, idreceive, subject, content);
        }

        public DataTable loadlistmail(string iduser)
        {
            DataTable dtlistmail = new DataTable();
            dtlistmail = mailDAL.loadlistmail(iduser);
            dtlistmail.Columns[0].ColumnName = "Mail ID";
            dtlistmail.Columns[1].ColumnName = "Sender";
            dtlistmail.Columns[2].ColumnName = "Subject";
            dtlistmail.Columns[3].ColumnName = "Content";
            dtlistmail.Columns[4].ColumnName = "Status";
            return dtlistmail;
        }

        public void confirmmail(string idmail)
        {
            mailDAL.confirmmail(idmail);
        }
    }
}
