using System;
using System.Collections.Generic;
using System.Linq;  //De su dung menh de where
using System.Text;
using System.Threading.Tasks;

namespace form22_09_2022.ViewModel
{
    public class GiangVienViewModel
    {
        public String MaGiangVien { set; get; }
        public String Ho { set; get; } 
        public String Ten { set; get; }
        public String HoVaTen
        {
            get
            {
                return $"{ Ho} {Ten}";
            }
        }
        public DateTime NgaySinh { set; get; }
        public bool GioiTinh { set; get; }
        public String GioiTinhStr 
        {
            get
            {
                return GioiTinh ? "Nam" : "Nữ";
            }
        }  
        public String QueQuan { set; get; }
        public int MaKhoa { set; get; }
        public static List<GiangVienViewModel> getAll()
        {
            var list = new List<GiangVienViewModel>();
            list.Add(new GiangVienViewModel { });
            var lsKhoa = KhoaViewModel.getList();
            Random r = new Random();
            foreach (var khoa in lsKhoa)
            {
                for (int i = 0; i < 10; i++)
                {
                    var random = r.Next(1);
                    list.Add(new GiangVienViewModel
                    {
                        MaGiangVien = $"{khoa.MaKhoa}{i}",
                        Ho = "Nguyễn",
                        Ten = $"{khoa.TenKhoa}{i}",
                        GioiTinh = (random == 0 ? true : false),
                        MaKhoa = khoa.MaKhoa,
                        QueQuan = "TT Huế",
                    });
                }

            }
            return list;
        }
        public static List<GiangVienViewModel> getByKhoa(int maKhoa) 
        {
            var list = getAll();
            var result = list.Where(x => x.MaKhoa == maKhoa).ToList();  //Tromg where la bieu thuc Linq
            return result;
        }
    }
}
