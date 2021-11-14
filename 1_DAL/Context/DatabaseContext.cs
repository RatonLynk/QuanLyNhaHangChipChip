using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL.Models;

#nullable disable

namespace _1_DAL.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BanAn> BanAns { get; set; }
        public virtual DbSet<CachCheBien> CachCheBiens { get; set; }
        public virtual DbSet<CongThuc> CongThucs { get; set; }
        public virtual DbSet<DanhMucFood> DanhMucFoods { get; set; }
        public virtual DbSet<DonVi> DonVis { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<MonAnChiTiet> MonAnChiTiets { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ThucDon> ThucDons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-GMM3CUTL\\SQLEXPRESS;Initial Catalog=QLNH;Persist Security Info=True;User ID=chi11;Password=chi11");
            }
        }

        

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
