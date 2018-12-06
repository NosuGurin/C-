using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class NhaCungCap_BUS
    {
        NhaCungCap_DAL cn = new NhaCungCap_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemNhaCungCap(x);
        }
        //Them
        public void ThemDuLieu(NhaCungCap et)
        {
            cn.ThemDuLieu(et);
        }
        //Sua
        public void SuaDuLieu(NhaCungCap et)
        {
            cn.SuaDuLieu(et); 
        }
        //Xoa
        public void XoaDuLieu(NhaCungCap et)
        {
            cn.XoaDuLieu(et);
        }
        //Lay
        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }
        public DataTable LayThongTinNhaCC(string DieuKien)
        {
            return cn.LayThonTinNCC(DieuKien);
        }

        public DataTable LayThongTinMaNCungCap(string DieuKien)
        {
            return cn.LayThongTinMaNCungCap(DieuKien);
        }
        public DataTable LayThongTinTenNCungCap(string DieuKien)
        {
            return cn.LayThongTinTenNCungCap(DieuKien);
        }
        public DataTable LayThongTinDiaChi(string DieuKien)
        {
            return cn.LayThongTinDiaChi(DieuKien);
        }
        public DataTable LayThongTinDienThoai(string DieuKien)
        {
            return cn.LayThongTinDienThoai(DieuKien);
        }
        public DataTable LayThongTinEmail(string DieuKien)
        {
            return cn.LayThongTinEmail(DieuKien);
        }

        public int KiemTraManCungCap(string x)
        {
            return cn.KiemTraManCungCap(x);
        }
        public int KiemTraTennCungCap(string x)
        {
            return cn.KiemTraTennCungCap(x);
        }
        public int KiemTraDiaChi(string x)
        {
            return cn.KiemTraDiaChi(x);
        }
        public int KiemTraDienThoai(string x)
        {
            return cn.KiemTraDienThoai(x);
        }
        public int KiemTraMaEmail(string x)
        {
            return cn.KiemTraEmail(x);
        }

    }
}
