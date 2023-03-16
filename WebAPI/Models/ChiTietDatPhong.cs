using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ChiTietDatPhong
    {
        [Key]
        public int ma_chi_tiet_dat_phong { get; set; }
        public DatPhong DatPhong { get; set; }
        public int ma_dat_phong { get; set; }
        public DichVuDiKem DichVuDiKem { get; set; }
        public int ma_dich_vu { get; set; }
        public int so_luong { get; set; }
    }
}
