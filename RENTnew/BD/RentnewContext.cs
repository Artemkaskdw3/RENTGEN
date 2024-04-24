using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RENTnew.BD;

public partial class RentnewContext : DbContext
{
    public RentnewContext()
    {
    }

    public RentnewContext(DbContextOptions<RentnewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assisstant> Assisstants { get; set; }

    public virtual DbSet<Departament> Departaments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<GroupingReserch> GroupingReserches { get; set; }

    public virtual DbSet<HeathCf> HeathCfs { get; set; }

    public virtual DbSet<PartOfBody> PartOfBodies { get; set; }

    public virtual DbSet<Pathology> Pathologies { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Reserch> Reserchs { get; set; }

    public virtual DbSet<ReserchsName> ReserchsNames { get; set; }

    public virtual DbSet<SystemsRe> SystemsRes { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=K-903;Database=RENTnew;  TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Assisstant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Assissta__3213E83FEE14427B");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("firstName");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .HasColumnName("middleName");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Departament>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__departam__3213E83F1CDF0CC9");

            entity.ToTable("departaments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameDep)
                .HasMaxLength(100)
                .HasColumnName("nameDep");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__doctors__3213E83F4ECB7FB9");

            entity.ToTable("doctors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("firstName");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .HasColumnName("middleName");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<GroupingReserch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Grouping__3213E83F49085822");

            entity.ToTable("GroupingReserch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameGroup)
                .HasMaxLength(100)
                .HasColumnName("nameGroup");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HeathCf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HeathCF__3213E83F90C40B1F");

            entity.ToTable("HeathCF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameHcf)
                .HasMaxLength(100)
                .HasColumnName("nameHCF");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<PartOfBody>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PartOfBo__3214EC07BB1E8BFD");

            entity.ToTable("PartOfBody");

            entity.Property(e => e.PartOfBodyName).HasMaxLength(100);
        });

        modelBuilder.Entity<Pathology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patholog__3213E83F119F8B27");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NamePathologies)
                .HasMaxLength(100)
                .HasColumnName("namePathologies");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");

            entity.HasOne(d => d.PartOfBody).WithMany(p => p.Pathologies)
                .HasForeignKey(d => d.PartOfBodyId)
                .HasConstraintName("PartOfBodyToPathologys");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patients__3213E83F984399C5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age)
                .HasColumnType("date")
                .HasColumnName("age");
            entity.Property(e => e.Appartaments)
                .HasMaxLength(100)
                .HasColumnName("appartaments");
            entity.Property(e => e.Building)
                .HasMaxLength(100)
                .HasColumnName("building");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("firstName");
            entity.Property(e => e.Letter)
                .HasMaxLength(100)
                .HasColumnName("letter");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .HasColumnName("middleName");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .HasColumnName("street");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Reserch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reserchs__3213E83FCC7248E5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateReserch)
                .HasColumnType("date")
                .HasColumnName("dateReserch");
            entity.Property(e => e.DepartamentId).HasColumnName("departamentId");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.Dose)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("dose");
            entity.Property(e => e.Hcfid).HasColumnName("HCFId");
            entity.Property(e => e.NameRerserchId).HasColumnName("nameRerserchId");
            entity.Property(e => e.PatientId).HasColumnName("patientId");
            entity.Property(e => e.ResultId).HasColumnName("resultId");

            entity.HasOne(d => d.AssisstantNavigation).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.Assisstant)
                .HasConstraintName("FK_Orders_To_Customers");

            entity.HasOne(d => d.Departament).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.DepartamentId)
                .HasConstraintName("FK__Reserchs__depart__60A75C0F");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserchs__doctor__628FA481");

            entity.HasOne(d => d.Hcf).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.Hcfid)
                .HasConstraintName("FK__Reserchs__HCFId__619B8048");

            entity.HasOne(d => d.NameRerserch).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.NameRerserchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserchs__nameRe__5FB337D6");

            entity.HasOne(d => d.Patient).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserchs__patien__6383C8BA");

            entity.HasOne(d => d.Result).WithMany(p => p.Reserches)
                .HasForeignKey(d => d.ResultId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserchs__result__6477ECF3");
        });

        modelBuilder.Entity<ReserchsName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reserchs__3213E83FAAB2E206");

            entity.ToTable("ReserchsName");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameReserch)
                .HasMaxLength(100)
                .HasColumnName("nameReserch");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");

            entity.HasOne(d => d.Group).WithMany(p => p.ReserchsNames)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ReserchsN__Group__66603565");

            entity.HasOne(d => d.System).WithMany(p => p.ReserchsNames)
                .HasForeignKey(d => d.SystemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ReserchsN__Syste__6754599E");
        });

        modelBuilder.Entity<SystemsRe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SystemsR__3213E83F5A4AB0A6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameSystem).HasMaxLength(100);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
