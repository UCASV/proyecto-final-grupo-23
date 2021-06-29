using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_V2
{
    public partial class ProyectoContext : DbContext
    {
        public ProyectoContext()
        {
        }

        public ProyectoContext(DbContextOptions<ProyectoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Cabinxemployee> Cabinxemployees { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GroupPriority> GroupPriorities { get; set; }
        public virtual DbSet<Pacient> Pacients { get; set; }
        public virtual DbSet<Quotee> Quotees { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }
        public virtual DbSet<TypeInstitution> TypeInstitutions { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=proyecto_final3;User=root;Password=malditos0001;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("cabin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Mandated)
                    .HasMaxLength(50)
                    .HasColumnName("mandated");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Cabinxemployee>(entity =>
            {
                entity.HasKey(e => new { e.IdCabin, e.IdEmployee })
                    .HasName("PRIMARY");

                entity.ToTable("cabinxemployee");

                entity.HasIndex(e => e.IdEmployee, "fk_cabinXemployee_employee");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Cabinxemployees)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cabinxemployee_cabin");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Cabinxemployees)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cabinXemployee_employee");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("disease");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Disease1)
                    .HasMaxLength(50)
                    .HasColumnName("disease");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.HasIndex(e => e.IdTypeEmployee, "id_type_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.Property(e => e.NameEmployee)
                    .HasMaxLength(50)
                    .HasColumnName("name_employee");

                entity.Property(e => e.PasswordEmployee)
                    .HasMaxLength(50)
                    .HasColumnName("password_employee");

                entity.Property(e => e.UserEmployee)
                    .HasMaxLength(50)
                    .HasColumnName("user_employee");

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .HasConstraintName("employee_ibfk_1");
            });

            modelBuilder.Entity<GroupPriority>(entity =>
            {
                entity.ToTable("group_priority");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Groupp)
                    .HasMaxLength(50)
                    .HasColumnName("groupp");
            });

            modelBuilder.Entity<Pacient>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PRIMARY");

                entity.ToTable("pacient");

                entity.HasIndex(e => e.IdDisease, "id_Disease");

                entity.HasIndex(e => e.IdGroupPriority, "id_group_priority");

                entity.HasIndex(e => e.IdTypeInstitution, "id_type_institution");

                entity.Property(e => e.Dui)
                    .HasMaxLength(20)
                    .HasColumnName("DUI");

                entity.Property(e => e.AdressPacient)
                    .HasMaxLength(50)
                    .HasColumnName("adress_pacient");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdDisease).HasColumnName("id_Disease");

                entity.Property(e => e.IdGroupPriority).HasColumnName("id_group_priority");

                entity.Property(e => e.IdTypeInstitution).HasColumnName("id_type_institution");

                entity.Property(e => e.NamePacient)
                    .HasMaxLength(50)
                    .HasColumnName("name_pacient");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.HasOne(d => d.IdDiseaseNavigation)
                    .WithMany(p => p.Pacients)
                    .HasForeignKey(d => d.IdDisease)
                    .HasConstraintName("pacient_ibfk_1");

                entity.HasOne(d => d.IdGroupPriorityNavigation)
                    .WithMany(p => p.Pacients)
                    .HasForeignKey(d => d.IdGroupPriority)
                    .HasConstraintName("pacient_ibfk_3");

                entity.HasOne(d => d.IdTypeInstitutionNavigation)
                    .WithMany(p => p.Pacients)
                    .HasForeignKey(d => d.IdTypeInstitution)
                    .HasConstraintName("pacient_ibfk_2");
            });

            modelBuilder.Entity<Quotee>(entity =>
            {
                entity.ToTable("quotee");

                entity.HasIndex(e => e.DuiPacient, "DUI_pacient");

                entity.HasIndex(e => e.IdCabin, "id_cabin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateVaccine)
                    .HasColumnType("date")
                    .HasColumnName("date_vaccine");

                entity.Property(e => e.DuiPacient)
                    .HasMaxLength(20)
                    .HasColumnName("DUI_pacient");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.PlaceVaccination)
                    .HasMaxLength(50)
                    .HasColumnName("place_vaccination");

                entity.HasOne(d => d.DuiPacientNavigation)
                    .WithMany(p => p.Quotees)
                    .HasForeignKey(d => d.DuiPacient)
                    .HasConstraintName("quotee_ibfk_2");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Quotees)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("quotee_ibfk_1");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.ToTable("record");

                entity.HasIndex(e => e.IdCabin, "id_cabin");

                entity.HasIndex(e => e.IdEmployee, "id_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateRecord)
                    .HasColumnType("date")
                    .HasColumnName("date_record");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("record_ibfk_1");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("record_ibfk_2");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("side_effects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SideEffects)
                    .HasMaxLength(50)
                    .HasColumnName("side_effects");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.ToTable("type_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Typee)
                    .HasMaxLength(50)
                    .HasColumnName("typee");
            });

            modelBuilder.Entity<TypeInstitution>(entity =>
            {
                entity.ToTable("type_institution");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Typee)
                    .HasMaxLength(50)
                    .HasColumnName("typee");
            });

            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.ToTable("vaccination");

                entity.HasIndex(e => e.DuiPacient, "DUI_pacient");

                entity.HasIndex(e => e.IdSideEffects, "id_Side_effects");

                entity.HasIndex(e => e.IdCabin, "id_cabin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateVaccine)
                    .HasColumnType("date")
                    .HasColumnName("date_vaccine");

                entity.Property(e => e.DuiPacient)
                    .HasMaxLength(20)
                    .HasColumnName("DUI_pacient");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdSideEffects).HasColumnName("id_Side_effects");

                entity.HasOne(d => d.DuiPacientNavigation)
                    .WithMany(p => p.Vaccinations)
                    .HasForeignKey(d => d.DuiPacient)
                    .HasConstraintName("vaccination_ibfk_3");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Vaccinations)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("vaccination_ibfk_1");

                entity.HasOne(d => d.IdSideEffectsNavigation)
                    .WithMany(p => p.Vaccinations)
                    .HasForeignKey(d => d.IdSideEffects)
                    .HasConstraintName("vaccination_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
