using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class DatPhong
    {
        [Key]
        public int ma_dat_phong { get; set; }
        public KhachHang KhachHang { get; set; }
        public int ma_khach_hang { get; set; }
        public Phong Phong { get; set; }
        public int ma_phong { get; set; }
        public DateTime ngay_nhan_phong { get; set; }
        public DateTime ngay_tra_phong { get; set; }
        public int so_luong_nguoi { get; set; }

        public List<HoaDon> HoaDons { get; set; }
        public List<ChiTietDatPhong> ChiTietDatPhongs { get; set; }
    }
}
