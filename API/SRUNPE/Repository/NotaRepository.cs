using Contracts;
using Entities.Models.D_Notas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal sealed class NotaRepository : RepositoryBase<Notas>, INotaRepository
    {
        public NotaRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Notas> GetAllNotas(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.PeriodoAcademico)
                .ToList();

        public Notas GetNota(int notaId, bool trackChanges) =>
            FindByCondition(c => c.NotaId == notaId, trackChanges)
                .SingleOrDefault();

        public void CreateNota(Notas nota) => Create(nota);

        public IEnumerable<Notas> GetByIds(IEnumerable<int> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.NotaId), trackChanges)
                .ToList();

        public void DeleteNota(Notas nota) => Delete(nota);
    }
}
