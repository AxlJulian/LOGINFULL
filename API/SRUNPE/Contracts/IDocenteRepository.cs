using Entities.Models.D_Docente;


namespace Contracts;

public interface IDocenteRepository
{
    IEnumerable<Docente> GetAllDocentes(bool trackChanges);
    Docente GetDocente(Guid docenteId, bool trackChanges);
    void CreateDocente(Docente docente);
    IEnumerable<Docente> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    void DeleteDocente(Docente docente);
    
    Docente GetDocenteWithRelations(Guid id, bool trackChanges);


}
