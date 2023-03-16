using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Phong> tbl_phong { get; set; }
        public DbSet<DatPhong> tbl_dat_phong { get; set; }
        public DbSet<KhachHang> tbl_khach_hang { get; set; }
        public DbSet<HoaDon> tbl_hoa_don { get; set; }
        public DbSet<ChiTietDatPhong> tbl_chi_tiet_dat_phong { get; set; }
        public DbSet<DichVuDiKem> tbl_dich_vu { get; set; }
    }
}
