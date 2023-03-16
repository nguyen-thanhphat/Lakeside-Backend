using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class KhachHang
    {
        [Key]
        public int ma_khach_hang { get; set; }
        public string? ten_khach_hang { get; set; } 
        public bool gioi_tinh { get; set; }
        public string? dia_chi { get; set; } 
        public string? email { get; set; } 
        public string? so_dien_thoai { get; set; } 
        public string? so_dinh_danh { get; set; } 
        public List<DatPhong> DatPhongs { get; set; }
    }
}
