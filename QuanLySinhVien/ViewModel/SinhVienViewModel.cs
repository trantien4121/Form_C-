using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.ViewModel
{
    public class SinhVienViewModel
    {
        public int ID { get; set; }
        public String MaSinhVien { get; set; }
        public String HoDem  { get; set; }
        public String Ten { get; set; }
        public String NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public String QueQuan { get; set; }
        public int IDLopHoc { get; set; }
        public static List<SinhVienViewModel> Getlist()
        {
            var db = new AppDBContext();
            var rs = db.SinhViens.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                HoDem = e.HoDem,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh.ToString(),
                QueQuan = e.QueQuan,
                IDLopHoc = (int)e.IDLopHoc,
            }).ToList();

            return rs;

        }
        public static List<SinhVienViewModel> Getlist(int idLopHoc)
        {
            var db = new AppDBContext();
            var rs = db.SinhViens.Where(e => e.IDLopHoc == idLopHoc).Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                HoDem = e.HoDem,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh.ToString(),
                QueQuan = e.QueQuan,
                IDLopHoc = (int)e.IDLopHoc,
            }).ToList();
            return rs;
        }
    }
}
    
