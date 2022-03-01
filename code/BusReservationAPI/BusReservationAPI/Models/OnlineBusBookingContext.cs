using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusReservationAPI.Models​
{
    public partial class OnlineBusBookingContext : DbContext
    {
        public OnlineBusBookingContext()
        {
        }

        public OnlineBusBookingContext(DbContextOptions<OnlineBusBookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingMaster> BookingMasters { get; set; } = null!;
        public virtual DbSet<BusMaster> BusMasters { get; set; } = null!;
        public virtual DbSet<CardDetail> CardDetails { get; set; } = null!;
        public virtual DbSet<CityDetail> CityDetails { get; set; } = null!;
        public virtual DbSet<PickUpStand> PickUpStands { get; set; } = null!;
        public virtual DbSet<Pnrdetail> Pnrdetails { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<RouteDetail> RouteDetails { get; set; } = null!;
        public virtual DbSet<ScheduleMaster> ScheduleMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               // optionsBuilder.UseSqlServer("Server=LAPTOP-DVT298FV\\SQLEXPRESS;Database=OnlineBusBooking;user id=sa;password=newuser123#;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingMaster>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("BookingMaster");

                entity.Property(e => e.BoardingId).HasColumnName("BoardingID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pnrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNRNo");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.SeatNo).HasMaxLength(50);

                entity.Property(e => e.TravelDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusMaster>(entity =>
            {
                entity.HasKey(e => e.BusId);

                entity.ToTable("BusMaster");

                entity.Property(e => e.BusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BustType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardDetail>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo).HasMaxLength(100);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cvvno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CVVNo");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CityDetail>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PickUpStand>(entity =>
            {
                entity.HasKey(e => e.StandId);

                entity.ToTable("PickUpStand");

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pnrdetail>(entity =>
            {
                entity.HasKey(e => e.PnrdetailsId);

                entity.ToTable("PNRDetails");

                entity.Property(e => e.PnrdetailsId).HasColumnName("PNRDetailsID");

                entity.Property(e => e.Pnrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNRNo");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("Registration");

                entity.Property(e => e.RegId).HasColumnName("regId");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RouteDetail>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScheduleMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScheduleMaster");

                entity.Property(e => e.ArivalTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.ScheduleId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
