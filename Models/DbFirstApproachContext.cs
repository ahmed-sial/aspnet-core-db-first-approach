using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstApproach.Models;

public partial class DbFirstApproachContext : DbContext
{
    public DbFirstApproachContext()
    {
    }

    public DbFirstApproachContext(DbContextOptions<DbFirstApproachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3213E83F59DECB96");

            entity.ToTable("Student");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cgpa)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("cgpa");
            entity.Property(e => e.FName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_name");
            entity.Property(e => e.LName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("l_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
