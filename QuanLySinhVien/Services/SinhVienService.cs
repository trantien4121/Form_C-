using QuanLySinhVien.Model;
using QuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Services
{
    public class SinhVienService
    {
        public static List<SinhVienViewModel> Getlist()
        {
            var db = new AppDBContext();
            var rs = db.SinhViens.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                HoDem = e.HoDem,
                Ten = e.Ten,
                GioiTinh = (int)e.GioiTinh,
                NgaySinh = e.NgaySinh,
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
                GioiTinh = (int)e.GioiTinh,
                NgaySinh = e.NgaySinh,
                QueQuan = e.QueQuan,
                IDLopHoc = (int)e.IDLopHoc,
            }).ToList();
            return rs;
        }
        public static KetQua Addsinhvien(SinhVien sv)
        {
            var db = new AppDBContext();

            int count = db.SinhViens.Where(e => e.MaSinhVien == sv.MaSinhVien).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();   //Luu lai thay doi
                return KetQua.ThanhCong;
            }


        }

        public static KetQua UpdateSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            sinhVien.Ten = sv.Ten;
            sinhVien.HoDem = sv.HoDem;
            sinhVien.QueQuan = sv.QueQuan;
            sinhVien.IDLopHoc = sv.IDLopHoc;
            sinhVien.GioiTinh = sv.GioiTinh;
            sinhVien.MaSinhVien = sv.MaSinhVien;
            sinhVien.NgaySinh = sv.NgaySinh;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua DeleteSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhViens.Remove(sinhVien);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
