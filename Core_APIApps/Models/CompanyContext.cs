﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Core_APIApps.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<PersonInfo> PersonInfos { get; set; }

    public virtual DbSet<ToDo> ToDos { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Company;Integrated Security=SSPI;TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("PK__Departme__0148CAAE1BEE0851");

            entity.ToTable("Department");

            entity.Property(e => e.DeptNo).ValueGeneratedNever();
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__Employee__AF2D66D300538B3D");

            entity.ToTable("Employee");

            entity.Property(e => e.EmpNo).ValueGeneratedNever();
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.DeptNoNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DeptNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employee__DeptNo__286302EC");
        });

        modelBuilder.Entity<PersonInfo>(entity =>
        {
            entity.HasKey(e => e.BusinessEntityId).HasName("PK__PersonIn__889843170524EC19");

            entity.ToTable("PersonInfo");

            entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PersonType)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ToDo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ToDo__3214EC07A888C133");

            entity.ToTable("ToDo");

            entity.Property(e => e.Task)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("task");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
