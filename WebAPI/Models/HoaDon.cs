using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class HoaDon
    {
        [Key]
        public int ma_hoa_don { get; set; }
        public DatPhong DatPhong { get; set; }
        public int ma_dat_phong { get; set; }
        public decimal tong_tien { get; set; }
        public DateTime ngay_thanh_toan { get; set; }

    }
}
