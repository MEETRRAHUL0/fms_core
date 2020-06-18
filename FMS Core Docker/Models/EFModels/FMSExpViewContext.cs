using FMS;
using Microsoft.EntityFrameworkCore;

namespace FMS_Core.Models.EFModels
{
    public partial class FMSExpContext : DbContext
    {
        public virtual DbSet<vw_StockAvailable> vw_StockAvailable { get; set; }
        public virtual DbSet<vw_StockDetails> vw_StockDetails { get; set; }
        public virtual DbSet<vw_StockExpirydetails> vw_StockExpirydetails { get; set; }

        protected void OnModelCreatingForView(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vw_StockAvailable>(entity =>
            {
                entity.HasKey(e => e.Guid);
                entity.ToTable("vw_StockAvailable");
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<vw_StockDetails>(entity =>
            {
                entity.HasKey(e => e.Guid);
                entity.ToTable("vw_StockDetails");
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<vw_StockExpirydetails>(entity =>
            {
                entity.HasKey(e => e.Guid);
                entity.ToTable("vw_StockExpirydetails");
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            //return modelBuilder;
        }
    }
}