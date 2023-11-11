using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSV
{
    public partial class QLSVDbContext : DbContext
    {
        public QLSVDbContext()
            : base("name=ChuoiKN")
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsFixedLength();

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.TenDangNhap)
                .IsFixedLength();
        }
    }
}
