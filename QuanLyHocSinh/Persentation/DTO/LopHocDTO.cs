using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocDTO
    {
        private int malop;
        private string tenlop;
        private int siso;

        public int Malop
        {
            get { return malop; }
            set { malop = value; }
        }

        public string Tenlop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }

        public int Siso
        {
            get { return siso; }
            set { siso = value; }
        }

        public LopHocDTO(int _malop,string _tenlop,int _siso)
        {
            malop = _malop;
            tenlop = _tenlop;
            siso = _siso;
        }

        public LopHocDTO()
        {
            // TODO: Complete member initialization
        }
    }
}
