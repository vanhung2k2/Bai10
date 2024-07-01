using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface INhanVien
    {
        public void ThemNhanVien();
        public void XuatThongTinNhanVien();
        NhanVien TimKiemNhanVien(int id);
        void TaoSanLuong(int id, CongDoan congDoan);
    }
}
