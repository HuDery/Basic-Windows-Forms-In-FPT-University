using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PE_PRN211_LeHaDuy_RePo.Models
{
    public partial class BookPubLisherContext : DbContext
    {
        public BookPubLisherContext()
        {
        }

        public BookPubLisherContext(DbContextOptions<BookPubLisherContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountUser> AccountUsers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server =(local); database =BookPubLisher;uid=sa;pwd=1472580369;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__AccountU__1788CCAC6291CA96");

                entity.ToTable("AccountUser");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserFullName).HasMaxLength(100);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(90);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookId)
                    .HasMaxLength(20)
                    .HasColumnName("BookID");

                entity.Property(e => e.AuthorName).HasMaxLength(150);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PublisherId)
                    .HasMaxLength(20)
                    .HasColumnName("PublisherID");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Book__PublisherI__286302EC");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");

                entity.Property(e => e.PublisherId)
                    .HasMaxLength(20)
                    .HasColumnName("PublisherID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
