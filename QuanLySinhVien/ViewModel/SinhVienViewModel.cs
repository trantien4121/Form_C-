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
       
    }
}
    
