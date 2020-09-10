using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Entities

{
    public partial class DbblogContext : DbContext
    {
        public DbblogContext()
        {
        }

        public DbblogContext(DbContextOptions<DbblogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblMakale> TblMakale { get; set; }
        public virtual DbSet<Tbletiket> Tbletiket { get; set; }
        public virtual DbSet<Tblkullanici> Tblkullanici { get; set; }
        public virtual DbSet<Tblmakaleetiket> Tblmakaleetiket { get; set; }
        public virtual DbSet<Tblresim> Tblresim { get; set; }
        public virtual DbSet<Tblyazar> Tblyazar { get; set; }
        public virtual DbSet<Tblyorum> Tblyorum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=dbblog;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblKategori>(entity =>
            {
                entity.ToTable("tblKategori");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasColumnName("adi")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMakale>(entity =>
            {
                entity.ToTable("tblMakale");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnName("aciklama");

                entity.Property(e => e.Baslik)
                    .IsRequired()
                    .HasColumnName("baslik")
                    .HasMaxLength(100);

                entity.Property(e => e.YazarId).HasColumnName("yazarId");

                entity.Property(e => e.Yuklemetarihi)
                    .HasColumnName("yuklemetarihi")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.TblMakale)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMakale_tblKategori");

                entity.HasOne(d => d.Yazar)
                    .WithMany(p => p.TblMakale)
                    .HasForeignKey(d => d.YazarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMakale_tblyazar");
            });

            modelBuilder.Entity<Tbletiket>(entity =>
            {
                entity.ToTable("tbletiket");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adi)
                    .HasColumnName("adi")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tblkullanici>(entity =>
            {
                entity.ToTable("tblkullanici");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isim)
                    .IsRequired()
                    .HasColumnName("isim")
                    .HasMaxLength(50);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(200);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(200);

                entity.Property(e => e.Soyisim)
                    .IsRequired()
                    .HasColumnName("soyisim")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tblmakaleetiket>(entity =>
            {
                entity.HasKey(e => new { e.MakaleId, e.EtiketId });

                entity.ToTable("tblmakaleetiket");

                entity.Property(e => e.MakaleId).HasColumnName("makaleId");

                entity.Property(e => e.EtiketId).HasColumnName("etiketId");

                entity.HasOne(d => d.Etiket)
                    .WithMany(p => p.Tblmakaleetiket)
                    .HasForeignKey(d => d.EtiketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblmakaleetiket_tbletiket");

                entity.HasOne(d => d.Makale)
                    .WithMany(p => p.Tblmakaleetiket)
                    .HasForeignKey(d => d.MakaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblmakaleetiket_tblMakale");
            });

            modelBuilder.Entity<Tblresim>(entity =>
            {
                entity.ToTable("tblresim");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResimUrl)
                    .IsRequired()
                    .HasColumnName("resim_url")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Makale)
                    .WithMany(p => p.Tblresim)
                    .HasForeignKey(d => d.MakaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblresim_tblMakale");
            });

            modelBuilder.Entity<Tblyazar>(entity =>
            {
                entity.ToTable("tblyazar");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .HasMaxLength(1500);

                entity.Property(e => e.Isim)
                    .HasColumnName("isim")
                    .HasMaxLength(50);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50);

                entity.Property(e => e.Soyisim)
                    .HasColumnName("soyisim")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tblyorum>(entity =>
            {
                entity.ToTable("tblyorum");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MakaleId).HasColumnName("makaleId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Yorum)
                    .IsRequired()
                    .HasColumnName("yorum")
                    .HasMaxLength(1500);

                entity.HasOne(d => d.Makale)
                    .WithMany(p => p.Tblyorum)
                    .HasForeignKey(d => d.MakaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblyorum_tblMakale");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tblyorum)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblyorum_tblkullanici");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
