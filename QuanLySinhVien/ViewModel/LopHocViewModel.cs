using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.ViewModel
{
    public class LopHocViewModel
    {
        public int ID { get; set; }
        public string TenLop { get; set; }

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
