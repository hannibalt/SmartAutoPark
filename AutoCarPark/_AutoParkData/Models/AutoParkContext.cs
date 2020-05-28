using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _AutoParkData.Models
{
    public partial class AutoParkContext : DbContext
    {
        public AutoParkContext()
        {
        }

        public AutoParkContext(DbContextOptions<AutoParkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarParks> CarParks { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Moderators> Moderators { get; set; }
        public virtual DbSet<OldPayment> OldPayment { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VehicleTypes> VehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=OUZ;Database=AutoPark;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarParks>(entity =>
            {
                entity.HasKey(e => e.ParkId)
                    .HasName("PK__CarParks__B255A109AF1ED22F");

                entity.Property(e => e.ParkId).HasColumnName("Park_Id");

                entity.Property(e => e.ParkActive)
                    .HasColumnName("Park_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParkCapacity).HasColumnName("Park_Capacity");

                entity.Property(e => e.ParkName)
                    .HasColumnName("Park_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__Logs__2D26E78EFDCFBD05");

                entity.Property(e => e.LogId).HasColumnName("Log_Id");

                entity.Property(e => e.CarEntryTime)
                    .HasColumnName("Car_EntryTime")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CarOutTime)
                    .HasColumnName("Car_OutTime")
                    .HasColumnType("date");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SubPlate)
                    .HasColumnName("Sub_Plate")
                    .HasMaxLength(11);

                entity.Property(e => e.VehicleType).HasColumnName("Vehicle_Type");

                entity.HasOne(d => d.Park)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.ParkId)
                    .HasConstraintName("FK__Logs__ParkId__4D94879B");

                entity.HasOne(d => d.SubPlateNavigation)
                    .WithMany(p => p.Logs)
                    .HasPrincipalKey(p => p.UseCarPlate)
                    .HasForeignKey(d => d.SubPlate)
                    .HasConstraintName("FK__Logs__Sub_Plate__4CA06362");
            });

            modelBuilder.Entity<Moderators>(entity =>
            {
                entity.HasKey(e => e.ModId)
                    .HasName("PK__Moderato__D5F2725B23BAA749");

                entity.Property(e => e.ModId).HasColumnName("Mod_Id");

                entity.Property(e => e.ModEmail)
                    .HasColumnName("Mod_Email")
                    .HasMaxLength(44);

                entity.Property(e => e.ModPassword)
                    .HasColumnName("Mod_Password")
                    .HasMaxLength(15);

                entity.Property(e => e.ModUsername)
                    .HasColumnName("Mod_username")
                    .HasMaxLength(20);

                entity.HasOne(d => d.ByPark)
                    .WithMany(p => p.Moderators)
                    .HasForeignKey(d => d.ByParkId)
                    .HasConstraintName("FK__Moderator__ByPar__3A81B327");
            });

            modelBuilder.Entity<OldPayment>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__OldPayme__2D26E78E69F5F3C9");

                entity.Property(e => e.LogId).HasColumnName("Log_Id");

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.PaymCost)
                    .HasColumnName("Paym_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.PaymId).HasColumnName("Paym_Id");

                entity.Property(e => e.PaymUserPlate).HasMaxLength(11);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasKey(e => e.PaymType)
                    .HasName("PK__PaymentT__9E1F691E0A05B1F3");

                entity.Property(e => e.PaymtQuantity).HasColumnType("money");

                entity.Property(e => e.PaymtValidity).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymId)
                    .HasName("PK__Payments__22190F5F3B3F507F");

                entity.Property(e => e.PaymId).HasColumnName("Paym_Id");

                entity.Property(e => e.EventDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymCost)
                    .HasColumnName("Paym_Cost")
                    .HasColumnType("money");

                entity.Property(e => e.PaymUserPlate).HasMaxLength(11);

                entity.HasOne(d => d.Park)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ParkId)
                    .HasConstraintName("FK__Payments__EventD__47DBAE45");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UseId)
                    .HasName("PK__Users__09268C6192981CCD");

                entity.HasIndex(e => e.UseCarPlate)
                    .HasName("UQ__Users__EB1AE3521FD6A3B3")
                    .IsUnique();

                entity.Property(e => e.UseId).HasColumnName("Use_Id");

                entity.Property(e => e.TypId).HasColumnName("Typ_Id");

                entity.Property(e => e.UseActive)
                    .HasColumnName("Use_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseCarPlate)
                    .IsRequired()
                    .HasColumnName("Use_CarPlate")
                    .HasMaxLength(11);

                entity.Property(e => e.UseName)
                    .HasColumnName("Use_Name")
                    .HasMaxLength(15);

                entity.Property(e => e.UseSurname)
                    .HasColumnName("Use_Surname")
                    .HasMaxLength(15);

                entity.HasOne(d => d.Typ)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TypId)
                    .HasConstraintName("FK__Users__Use_Activ__412EB0B6");
            });

            modelBuilder.Entity<VehicleTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__VehicleT__516F03B59E9CC25C");

                entity.Property(e => e.TypeName).HasMaxLength(15);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
