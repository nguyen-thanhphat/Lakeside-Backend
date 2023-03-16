using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class DichVuDiKem
    {
        [Key]
        public int ma_dich_vu { get; set; }
        public int ten_dich_vu { get; set; }
        public decimal gia_dich_vu { get; set; }
        public string? mo_ta_dich_vu { get; set; } 

        public List<ChiTietDatPhong> ChiTietDatPhongs { get; set; }
    }
}
