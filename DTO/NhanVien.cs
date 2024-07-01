using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public double LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }
        public double PhuCap { get; set; }
        public double TongLuong { get; set; }
        public List<CongDoan> CongDoans { get; set; }

        //public NhanVien(int id, string name, string gioiTinh, int tuoi, float luongCoBan, float heSoLuong, float phuCap, float tongLuong, List<CongDoan> congDoans)
        //{
        //    Id = id;
        //    Name = name;
        //    GioiTinh = gioiTinh;
        //    Tuoi = tuoi;
        //    LuongCoBan = luongCoBan;
        //    HeSoLuong = heSoLuong;
        //    PhuCap = phuCap;
        //    TongLuong = tongLuong;
        //    CongDoans = congDoans;
        //}
    }
}
