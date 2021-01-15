using Microsoft.EntityFrameworkCore;

namespace TD.SharedDatabase.Data.Models
{
    public class GiaoDucContext: DbContext
    {
        public GiaoDucContext(DbContextOptions<GiaoDucContext> options)
            : base(options)
        {
        }

        public DbSet<DonVi> DonVis { get; set; }
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<PhuongXa> PhuongXas { get; set; }
        public DbSet<QuanHuyen> QuanHuyens { get; set; }
        public DbSet<TinhThanh> TinhThanhs { get; set; }
        public DbSet<TruongHoc> TruongHocs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonVi>().ToTable("DonVi");
            modelBuilder.Entity<GiaoVien>().ToTable("GiaoVien");
            modelBuilder.Entity<HocSinh>().ToTable("HocSinh");
            modelBuilder.Entity<LopHoc>().ToTable("LopHoc");
            modelBuilder.Entity<PhuongXa>().ToTable("PhuongXa");
            modelBuilder.Entity<QuanHuyen>().ToTable("QuanHuyen");
            modelBuilder.Entity<TinhThanh>().ToTable("TinhThanh");
            modelBuilder.Entity<TruongHoc>().ToTable("TruongHoc");
        }
    }
}
