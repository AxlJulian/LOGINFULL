using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
	private readonly RepositoryContext _repositoryContext;
	private readonly Lazy<ICandidatoEstudianteRepository> _candidatoEstudianteRepository;
	private readonly Lazy<IEstudianteDocumentosRepository> _estudianteDocumentosRepository;
    private readonly Lazy<IAcudienteRepository> _acudientesRepository;
    private readonly Lazy<IDireccionAcudienteRepository> _direccionAcudienteRepository;
    private readonly Lazy<ITelefonoAcudienteRepository> _telefonoAcudienteRepository;
    private readonly Lazy<ICupoRepository> _cupoRepository;
    private readonly Lazy<IRespuestaCupoRepository> _respuestaCupoRepository;
    private readonly Lazy<IPreMatriculaRepository> _preMatriculaRepository;
    private readonly Lazy<IMatriculaRepository> _matriculaRepository;
    private readonly Lazy<IAulaRepository> _aulaRepository;
    private readonly Lazy<ICursoRepository> _cursoRepository;
    private readonly Lazy<IHorarioRepository> _horarioRepository;
    private readonly Lazy<IMateriaRepository> _materiaRepository;
    private readonly Lazy<IAsistenciaRepository> _asistenciaRepository;
    private readonly Lazy<IEstadisticaRepository> _estadisticaRepository;
    private readonly Lazy<IDocenteRepository> _docenteRepository;
    private readonly Lazy<INotaRepository> _notaRepository;
    public RepositoryManager(RepositoryContext repositoryContext)
	{
		_repositoryContext = repositoryContext;
        
        _candidatoEstudianteRepository = new Lazy<ICandidatoEstudianteRepository>(() => new CandidatoEstudianteRepository(repositoryContext));
       
        _estudianteDocumentosRepository = new Lazy<IEstudianteDocumentosRepository>(() => new EstudianteDocumentosRepository(repositoryContext));
        
        _acudientesRepository = new Lazy<IAcudienteRepository>(() => new AcudienteRepository(repositoryContext));
        
        _direccionAcudienteRepository = new Lazy<IDireccionAcudienteRepository>(() => new DireccionAcudienteRepository(repositoryContext));
       
        _telefonoAcudienteRepository = new Lazy<ITelefonoAcudienteRepository>(() => new TelefonoAcudienteRepository(repositoryContext));
        
        _cupoRepository = new Lazy<ICupoRepository>(() => new CupoRepository(repositoryContext));

        _respuestaCupoRepository = new Lazy<IRespuestaCupoRepository>(() => new RespuestaCupoRepository(repositoryContext));

        _preMatriculaRepository = new Lazy<IPreMatriculaRepository>(() => new PreMatriculaRepository(repositoryContext));

        _matriculaRepository = new Lazy<IMatriculaRepository>(() => new MatriculaRepository(repositoryContext));

        _aulaRepository = new Lazy<IAulaRepository>(() => new AulaRepository(repositoryContext));

        _cursoRepository = new Lazy<ICursoRepository>(() => new CursoRepository(repositoryContext));

        _horarioRepository = new Lazy<IHorarioRepository>(() => new HorarioRepository(repositoryContext));

        _materiaRepository = new Lazy<IMateriaRepository>(() => new MateriaRepository(repositoryContext));

        _asistenciaRepository = new Lazy<IAsistenciaRepository>(() => new AsistenciaRepository(repositoryContext));

        _estadisticaRepository = new Lazy<IEstadisticaRepository>(() => new EstadisticaRepository(repositoryContext));

        _docenteRepository = new Lazy<IDocenteRepository>(() => new DocenteRepository(repositoryContext));

        _notaRepository = new Lazy<INotaRepository>(() => new NotaRepository(repositoryContext));

    }

    public ICandidatoEstudianteRepository CandidatoEstudiante => _candidatoEstudianteRepository.Value;
    public IEstudianteDocumentosRepository EstudianteDocumentos => _estudianteDocumentosRepository.Value;
    public IAcudienteRepository Acudiente => _acudientesRepository.Value;
    public IDireccionAcudienteRepository DireccionAcudiente => _direccionAcudienteRepository.Value;
    public ITelefonoAcudienteRepository TelefonoAcudiente => _telefonoAcudienteRepository.Value;
    public ICupoRepository Cupo => _cupoRepository.Value;
    public IRespuestaCupoRepository RespuestaCupo => _respuestaCupoRepository.Value;
    public IPreMatriculaRepository PreMatricula => _preMatriculaRepository.Value;
    public IMatriculaRepository Matricula => _matriculaRepository.Value;
    public IAulaRepository Aula => _aulaRepository.Value;
    public ICursoRepository Curso => _cursoRepository.Value;
    public IHorarioRepository Horario => _horarioRepository.Value;
    public IMateriaRepository Materia => _materiaRepository.Value;
    public IAsistenciaRepository Asistencia => _asistenciaRepository.Value;
    public IEstadisticaRepository Estadistica => _estadisticaRepository.Value;
    public IDocenteRepository Docente => _docenteRepository.Value;
    public INotaRepository Nota => _notaRepository.Value;

    public void Save()
    {
        try
        {
            _repositoryContext.SaveChanges();
        }
        catch (Exception ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine(ex.Message);
            throw;
        }
        foreach (var entry in _repositoryContext.ChangeTracker.Entries())
        {
            Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State.ToString()}");
        }

    }

}
