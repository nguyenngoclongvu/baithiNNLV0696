using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace nguyenngoclongvu0696.Models
{
    public class nnlvcau3
    {
        [Key]
         [Display(Name ="Họ Tên")]
        public string HoTen { get; set; }
         [Display(Name ="Lớp Học")]
        public string  LopHoc { get; set; }
         [Display(Name ="Số Điện Thoại")]
        public string  SoDienThoai { get; set; }
    }
}