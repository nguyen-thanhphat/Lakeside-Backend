using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Phong
    {
        [Key]
        public int ma_phong { get; set; }
        public string? loai_phong { get; set; } 
        public decimal gia_phong { get; set; }
        public int so_luong_nguoi_toi_da { get; set; }
        public string? so_giuong { get; set; } 
        public string? trang_thai { get; set; } 
        public string? danh_gia { get; set; } 
        public List<DatPhong> DatPhongs { get; set; }
    }
}
