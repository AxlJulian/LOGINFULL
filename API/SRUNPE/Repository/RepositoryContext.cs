using Entities.Models;
using Entities.Models.D_Acudiente;
using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;
using Entities.Models.D_Estudiante;
using Entities.Models.D_Notas;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models.LOGIN;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acudiente>()
                .HasMany(a => a.CandidatoEstudiantes)
                .WithMany(c => c.Acudientes)
                .UsingEntity<Dictionary<string, object>>(
                    "AcudienteCandidatoEstudiante",
                    j => j.HasOne<CandidatoEstudiante>().WithMany().HasForeignKey("CandidatoEstudianteId"),
                    j => j.HasOne<Acudiente>().WithMany().HasForeignKey("AcudienteId"));

            modelBuilder.Entity<Aulas>(entity =>
            {
                entity.HasKey(e => e.AulaId);
                // Otras configuraciones...
            });

            modelBuilder.Entity<Aulas>(entity =>
            {
                entity.HasKey(e => e.AulaId);
                // Otras configuraciones...
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.DocenteId);

                entity.HasOne(d => d.Aula)
                      .WithOne(a => a.Docente)
                      .HasForeignKey<Docente>(d => d.AulaId)
                      .IsRequired(false);
            });

            modelBuilder.Entity<Horarios>(entity =>
            {
                entity.HasKey(e => e.HorarioId);
                // Otras configuraciones...
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.DocenteId);

                entity.HasOne(d => d.Horario)
                      .WithOne(h => h.Docente)
                      .HasForeignKey<Docente>(d => d.HorarioId)
                      .IsRequired(false);
            });



            modelBuilder.Entity<Cursos>(entity =>
            {
                entity.HasKey(e => e.CursoId);
                entity.HasMany(e => e.Docentes)
                      .WithMany(d => d.Cursos)
                      .UsingEntity<Dictionary<string, object>>(
                          "CursoDocente", // Nombre de la tabla de relación
                          j => j.HasOne<Docente>().WithMany(),
                          j => j.HasOne<Cursos>().WithMany()
                      );
            });

            {
                modelBuilder.Entity<Docente>()
                    .HasMany(d => d.Materias)
                    .WithMany(m => m.Docentes)
                    .UsingEntity<Dictionary<string, object>>(
                        "DocenteMateria",
                        j => j.HasOne<Materias>().WithMany().HasForeignKey("MateriaId"),
                        j => j.HasOne<Docente>().WithMany().HasForeignKey("DocenteId"),
                        j =>
                        {
                            j.HasKey("DocenteId", "MateriaId");
                        });
            }

            // Configuración para Acudiente
            modelBuilder.Entity<Acudiente>()
                .HasMany(a => a.TelefonosAcudiente)
                .WithOne(t => t.Acudiente)
                .HasForeignKey(t => t.AcudienteId);

            modelBuilder.Entity<Acudiente>()
                .HasOne(a => a.DireccionAcudiente)
                .WithOne(d => d.Acudiente)
                .HasForeignKey<DireccionAcudiente>(d => d.AcudienteId);

            // Configuración para TelefonoAcudiente
            modelBuilder.Entity<TelefonoAcudiente>()
                .HasKey(t => t.TelefonoAcudienteId);

            // Configuración para DireccionAcudiente
            modelBuilder.Entity<DireccionAcudiente>()
                .HasKey(d => d.DireccionAcudienteId);


            modelBuilder.ApplyConfiguration(new CandidatoEstudianteConfiguration());
            modelBuilder.ApplyConfiguration(new AcudienteConfiguration());

            modelBuilder.ApplyConfiguration(new EstudianteDocumentosConfiguration());
            modelBuilder.ApplyConfiguration(new DireccionAcudienteConfiguration());
            modelBuilder.ApplyConfiguration(new TelefonoAcudienteConfiguration());
            modelBuilder.ApplyConfiguration(new CupoConfiguration());
            modelBuilder.ApplyConfiguration(new RespuestaCupoConfiguration());
            modelBuilder.ApplyConfiguration(new PreMatriculaConfiguration());
            modelBuilder.ApplyConfiguration(new MatriculaConfiguration());
            modelBuilder.ApplyConfiguration(new AulaConfiguration());
            modelBuilder.ApplyConfiguration(new CursoConfiguration());
            modelBuilder.ApplyConfiguration(new HorarioConfiguration());
            modelBuilder.ApplyConfiguration(new MateriaConfiguration());
            modelBuilder.ApplyConfiguration(new AsistenciaConfiguration());
            modelBuilder.ApplyConfiguration(new EstadisticaConfiguration());
            modelBuilder.ApplyConfiguration(new DocenteConfiguration());
            modelBuilder.ApplyConfiguration(new NotaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CandidatoEstudiante> CandidatoEstudiantes { get; set; }
        public DbSet<EstudianteDocumentos> EstudianteDocumentos { get; set; }
        public DbSet<Acudiente> Acudientes { get; set; }
        public DbSet<DireccionAcudiente> DireccionAcudiente { get; set; }
        public DbSet<TelefonoAcudiente> TelefonoAcudiente { get; set; }
        public DbSet<Cupo> Cupo { get; set; }
        public DbSet<RespuestaCupo> RespuestaCupo { get; set; }
        public DbSet<PreMatricula> PreMatricula { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Aulas> Aulas { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Horarios> Horarios { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Estadisticas> Estadisticas { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Notas> Notas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<AsignacionDocente> AsignacionesDocentes { get; set; }
        public DbSet<AsignacionEstudiante> AsignacionesEstudiantes { get; set; }
    }
}
