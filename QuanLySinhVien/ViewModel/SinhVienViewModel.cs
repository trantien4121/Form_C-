using QuanLySinhVien.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong,
        ThatBai
    }
    public class SinhVienViewModel
    {
        public int ID { get; set; }
        public String MaSinhVien { get; set; }
        public String HoDem  { get; set; }
        public String Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
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
            if(count > 0)
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
        public static KetQua DeleteSinhVien(String maSV)
        {
            var db = new AppDBContext();
            var flag = false;
            var result = db.SinhViens.Where(e => e.MaSinhVien == maSV).ToList();    

            if (result != null)
            {
                foreach(var sv in result)
                {
                    db.SinhViens.Remove(sv);
                }
                flag = true; 
            }
            else
            {
                flag = false;
            }

            if (flag == true)
            {
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
            else
            {
                return KetQua.TrungMa;

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
    }
}
    
