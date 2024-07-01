using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongDoan
    {
        public int MaCongDoan { get; set; }
        public string TenCongDoan { get; set; }
        public int SoLuongSanPham { get; set; }

        public CongDoan(int maCongDoan, string tenCongDoan, int soLuongSanPham)
        {
            MaCongDoan = maCongDoan;
            TenCongDoan = tenCongDoan;
            SoLuongSanPham = soLuongSanPham;
        }
    }
}
