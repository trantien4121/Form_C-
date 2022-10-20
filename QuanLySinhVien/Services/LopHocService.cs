using QuanLySinhVien.Model;
using QuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Services
{
    public class LopHocService
    {
        //Lay toan bo lop hoc
        public static List<LopHocViewModel> Getlist()
        {
            var db = new AppDBContext();
            var rs = db.LopHocs.Select(e => new LopHocViewModel
            {
                ID = e.ID,
                TenLop = e.TenLop,
            }).ToList();

            return rs;

        }

        public static KetQua addLopHoc(LopHoc lh)
        {
            var db = new AppDBContext();
            int count = db.LopHocs.Where( e => e.TenLop ==lh.TenLop ).Count();
            if (count > 0)
                return KetQua.TrungMa;
            else
            {
                db.LopHocs.Add(lh);
                db.SaveChanges();
                return KetQua.ThanhCong;

            }
        }
        public static KetQua UpdateLopHoc(LopHocViewModel lh)
        {
            var db = new AppDBContext();
            var lopHoc = db.LopHocs.Where(e => e.ID == lh.ID).FirstOrDefault();
            lopHoc.TenLop = lh.TenLop;

            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua DeleteLopHoc(LopHocViewModel lh)
        {
            var db = new AppDBContext();
            var lopHoc = db.LopHocs.Where(e => e.ID == lh.ID).FirstOrDefault();
            db.LopHocs.Remove(lopHoc);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
