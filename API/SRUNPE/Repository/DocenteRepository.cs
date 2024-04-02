using Contracts;
using Entities.Models.D_Docente;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal sealed class DocenteRepository : RepositoryBase<Docente>, IDocenteRepository
    {
        public DocenteRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Docente> GetAllDocentes(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Include(d => d.Horario)
                .Include(d => d.Aula)
                .OrderBy(d => d.Nombres)
                .ToList();
        }



        public Docente GetDocente(Guid docenteId, bool trackChanges) =>
            FindByCondition(c => c.DocenteId.Equals(docenteId), trackChanges)
                .SingleOrDefault();

        public void CreateDocente(Docente docente) => Create(docente);

        public IEnumerable<Docente> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.DocenteId), trackChanges)
                .ToList();

        public void DeleteDocente(Docente docente) => Delete(docente);

        public Docente GetDocenteWithRelations(Guid id, bool trackChanges)
        {
            return FindByCondition(d => d.DocenteId.Equals(id), trackChanges)
                .Include(d => d.Materias)
                .FirstOrDefault();
        }



    }
}
