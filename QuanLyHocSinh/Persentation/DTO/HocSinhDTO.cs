using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhDTO
    {
        private int mahs;
        private string tenhs;
        private string diachi;
        private string dienthoai;
        private DateTime ngaysinh;
        private int malop;

        public int Mahs
        {
            get { return mahs; }
            set { mahs = value; }
        }

        public string Tenhs
        {
            get { return tenhs; }
            set { tenhs = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public int Malop
        {
            get { return malop; }
            set { malop = value; }
        }

        public HocSinhDTO(int _mahs,string _tenhs,string _diachi,string _dienthoai,DateTime _ngaysinh,int _malop)
        {
            mahs = _mahs;
            tenhs = _tenhs;
            diachi = _diachi;
            dienthoai = _dienthoai;
            ngaysinh = _ngaysinh;
            malop = _malop;
        }

        public HocSinhDTO()
        {
            // TODO: Complete member initialization
        }
    }
}
