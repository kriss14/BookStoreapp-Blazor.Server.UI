using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp_Blazor.Server.UI.Data;

public partial class BookStoreDbContext : IdentityDbContext<AppUser>
{
    public BookStoreDbContext()
    {
    }

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; } = null!;

    public virtual DbSet<Book> Books { get; set; } = null!;

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=BookStoreDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC07CFFEDD87");

            entity.Property(e => e.Bio)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC078B4E261E");

            entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EAFB34C728").IsUnique();

            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Summary).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_Books_ToTable");
        });

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = "af172c47-fde8-44c4-93b8-fe2e623a592f"
            },
            new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                Id = "8a51b850-3ad5-4998-92dc-581ec43eb234"
            }
            );

        var hasher = new PasswordHasher<AppUser>();
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = "41c6470f-ccb1-42db-954b-c330a72c8b34",
                Email = "admin@bookstore.com",
                NormalizedEmail = "ADMIN@BOOKSTORE.COM",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = hasher.HashPassword(null, "Admin$1")
            },
               new AppUser
               {
                   Id = "8a51b850-3ad5-4998-92dc-581ec43eb234",
                   Email = "user@bookstore.com",
                   NormalizedEmail = "USER@BOOKSTORE.COM",
                   FirstName = "System",
                   LastName = "User",
                   PasswordHash = hasher.HashPassword(null, "User$1")
               }
            );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(

            new IdentityUserRole<string>
            {
                RoleId = "af172c47-fde8-44c4-93b8-fe2e623a592f",
                UserId = "8a51b850-3ad5-4998-92dc-581ec43eb234"
            },

            new IdentityUserRole<string>
            {
                 RoleId = "8a51b850-3ad5-4998-92dc-581ec43eb234",
                 UserId = "41c6470f-ccb1-42db-954b-c330a72c8b34"
            }
        );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
