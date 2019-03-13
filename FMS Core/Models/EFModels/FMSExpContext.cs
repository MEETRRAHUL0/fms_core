using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FMS_Core.Models.EFModels
{
    public partial class FMSExpContext : DbContext
    {
        public FMSExpContext()
        {
        }

        public FMSExpContext(DbContextOptions<FMSExpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Certification> Certification { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<TblGst> TblGst { get; set; }
        public virtual DbSet<TblItemStock> TblItemStock { get; set; }
        public virtual DbSet<TblItemType> TblItemType { get; set; }
        public virtual DbSet<TblItemUnits> TblItemUnits { get; set; }
        public virtual DbSet<TblItems> TblItems { get; set; }
        public virtual DbSet<TblMenu> TblMenu { get; set; }
        public virtual DbSet<TblPayment> TblPayment { get; set; }
        public virtual DbSet<TblPaymentMode> TblPaymentMode { get; set; }
        public virtual DbSet<TblPurchase> TblPurchase { get; set; }
        public virtual DbSet<TblSale> TblSale { get; set; }
        public virtual DbSet<TblSequence> TblSequence { get; set; }
        public virtual DbSet<TblTransaction> TblTransaction { get; set; }
        public virtual DbSet<TblVendor> TblVendor { get; set; }
        public virtual DbSet<TblVendorAddress> TblVendorAddress { get; set; }
        public virtual DbSet<TblVendorType> TblVendorType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=FMSExp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            OnModelCreatingForView(modelBuilder);

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Certification>(entity =>
            {
                entity.Property(e => e.Provider)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription).HasColumnType("text");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGst>(entity =>
            {
                entity.ToTable("tbl_GST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cgst)
                    .HasColumnName("CGST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.Gst)
                    .HasColumnName("GST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Igst)
                    .HasColumnName("IGST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sgst)
                    .HasColumnName("SGST")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblItemStock>(entity =>
            {
                entity.ToTable("tbl_ItemStock");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BatchNo).HasMaxLength(50);

                entity.Property(e => e.Cgst)
                    .HasColumnName("CGST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDatetime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Expirydate).HasColumnType("date");

                entity.Property(e => e.Gst)
                    .HasColumnName("GST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Igst)
                    .HasColumnName("IGST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemwiseDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManufactureDate).HasColumnType("date");

                entity.Property(e => e.Mrp)
                    .HasColumnName("MRP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerUnit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerUnitAfterDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseId)
                    .HasColumnName("PurchaseID")
                    .HasMaxLength(50);

                entity.Property(e => e.SaleId)
                    .HasColumnName("SaleID")
                    .HasMaxLength(50);

                entity.Property(e => e.Sgst)
                    .HasColumnName("SGST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StockType).HasMaxLength(50);

                entity.Property(e => e.TotalPriceAfterTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPriceBeforeTax).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblItemStock)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_tbl_ItemStock_tbl_Items");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.TblItemStock)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_tbl_ItemStock_tbl_Purchase");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.TblItemStock)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_tbl_ItemStock_tbl_Sale");
            });

            modelBuilder.Entity<TblItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("tbl_ItemType");

                entity.Property(e => e.ItemType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblItemUnits>(entity =>
            {
                entity.HasKey(e => e.MeasurintUnitId);

                entity.ToTable("tbl_ItemUnits");

                entity.Property(e => e.MeasurintUnitId).HasColumnName("MeasurintUnitID");

                entity.Property(e => e.MeasuringUnits).HasMaxLength(50);
            });

            modelBuilder.Entity<TblItems>(entity =>
            {
                entity.ToTable("tbl_Items");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BarCode).HasMaxLength(100);

                entity.Property(e => e.CreatedDatetime).HasColumnType("date");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.HsnSacNo)
                    .HasColumnName("HSN_SAC_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemUniqueDescription).HasMaxLength(100);

                entity.Property(e => e.Manufacture).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Photo).HasMaxLength(50);

                entity.Property(e => e.Supplier).HasMaxLength(50);

                entity.HasOne(d => d.GstNavigation)
                    .WithMany(p => p.TblItems)
                    .HasForeignKey(d => d.Gst)
                    .HasConstraintName("FK_tbl_Items_tbl_GST");

                entity.HasOne(d => d.MeasuringUnitNavigation)
                    .WithMany(p => p.TblItems)
                    .HasForeignKey(d => d.MeasuringUnit)
                    .HasConstraintName("FK_tbl_Items_tbl_ItemUnits");

                entity.HasOne(d => d.SupplierNavigation)
                    .WithMany(p => p.TblItems)
                    .HasForeignKey(d => d.Supplier)
                    .HasConstraintName("FK_tbl_Items_tbl_vendor");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.TblItems)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_tbl_Items_tbl_ItemType");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.ToTable("tblMenu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordinal).HasColumnName("ordinal");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(500);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPayment>(entity =>
            {
                entity.ToTable("tbl_Payment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDatetime).HasMaxLength(50);

                entity.Property(e => e.PartyName).HasMaxLength(50);

                entity.Property(e => e.PaymentDate).HasMaxLength(50);

                entity.Property(e => e.PaymentMode).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.HasOne(d => d.PartyNameNavigation)
                    .WithMany(p => p.TblPayment)
                    .HasForeignKey(d => d.PartyName)
                    .HasConstraintName("FK_tbl_Payment_tbl_Payment");
            });

            modelBuilder.Entity<TblPaymentMode>(entity =>
            {
                entity.ToTable("tbl_PaymentMode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPurchase>(entity =>
            {
                entity.ToTable("tbl_Purchase");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDatetime).HasMaxLength(50);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartyInvoiceDate).HasColumnType("date");

                entity.Property(e => e.PartyInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.PartyName).HasMaxLength(50);

                entity.Property(e => e.PaymentDueAfter).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RoundOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScanCopy).HasMaxLength(100);

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountAfterTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountBeforeTax).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.PartyNameNavigation)
                    .WithMany(p => p.TblPurchase)
                    .HasForeignKey(d => d.PartyName)
                    .HasConstraintName("FK_tbl_Purchase_tbl_vendor");

                entity.HasOne(d => d.PaymentModeNavigation)
                    .WithMany(p => p.TblPurchase)
                    .HasForeignKey(d => d.PaymentMode)
                    .HasConstraintName("FK_tbl_Purchase_tbl_PaymentMode");
            });

            modelBuilder.Entity<TblSale>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.ToTable("tbl_Sale");

                entity.Property(e => e.SaleId)
                    .HasColumnName("SaleID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDatetime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAfterTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherChargeAfterTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.RoundOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScanCopy).HasMaxLength(100);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalValueafterTax).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblSale)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_tbl_Sale_tbl_vendor");

                entity.HasOne(d => d.PaymentModeNavigation)
                    .WithMany(p => p.TblSale)
                    .HasForeignKey(d => d.PaymentMode)
                    .HasConstraintName("FK_tbl_Sale_tbl_PaymentMode");
            });

            modelBuilder.Entity<TblSequence>(entity =>
            {
                entity.ToTable("tbl_Sequence");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PreFix)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTransaction>(entity =>
            {
                entity.ToTable("tbl_Transaction");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDatetime).HasMaxLength(50);

                entity.Property(e => e.EntryDate).HasMaxLength(50);

                entity.Property(e => e.EntryId)
                    .IsRequired()
                    .HasColumnName("EntryID")
                    .HasMaxLength(50);

                entity.Property(e => e.EntryType).HasMaxLength(50);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("PaymentID")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseId)
                    .HasColumnName("PurchaseID")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesId)
                    .HasColumnName("SalesID")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransactionRef).HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.TblTransaction)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_tbl_Transaction_tbl_Payment");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.TblTransaction)
                    .HasForeignKey(d => d.PurchaseId)
                    .HasConstraintName("FK_tbl_Transaction_tbl_Purchase");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.TblTransaction)
                    .HasForeignKey(d => d.SalesId)
                    .HasConstraintName("FK_tbl_Transaction_tbl_Sale");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.TblTransaction)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_tbl_Transaction_tbl_vendor");
            });

            modelBuilder.Entity<TblVendor>(entity =>
            {
                entity.ToTable("tbl_vendor");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdhaarNo).HasMaxLength(50);

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cinno)
                    .HasColumnName("CINNo")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreatedDatetime).HasMaxLength(50);

                entity.Property(e => e.CreditInterestRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitInterestRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(50);

                entity.Property(e => e.Gstno)
                    .HasColumnName("GSTNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpeningBalanceDate).HasMaxLength(50);

                entity.Property(e => e.OpeningBalanceType).HasMaxLength(50);

                entity.Property(e => e.Panno)
                    .HasColumnName("PANNo")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(100);

                entity.Property(e => e.Place).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SuretyPerson).HasMaxLength(50);

                entity.Property(e => e.SuretyPersonAddress).HasMaxLength(500);

                entity.Property(e => e.SuretyPersonContactNo).HasMaxLength(50);

                entity.Property(e => e.Tinno)
                    .HasColumnName("TINNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.VendorType).HasMaxLength(50);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.TblVendor)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_tbl_vendor_tbl_vendorType");
            });

            modelBuilder.Entity<TblVendorAddress>(entity =>
            {
                entity.ToTable("tbl_VendorAddress");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddLine1).HasMaxLength(100);

                entity.Property(e => e.AddLine2).HasMaxLength(100);

                entity.Property(e => e.AddressType).HasMaxLength(50);

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.PinCode).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendorID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.TblVendorAddress)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_tbl_VendorAddress_tbl_vendor");
            });

            modelBuilder.Entity<TblVendorType>(entity =>
            {
                entity.ToTable("tbl_vendorType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
