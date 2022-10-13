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
    }
}
