using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class SinhVien
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string HoTenSV { get; set; }
        public string GioiTinh { get; set; }
        [Display(Name = "NgaySinh")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime NgaySinh { get; set; }
        [StringLength(200)]
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public string DienThoai { get; set; }

    }
}
