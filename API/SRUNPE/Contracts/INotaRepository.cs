using Entities.Models.D_Notas;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface INotaRepository
    {
        IEnumerable<Notas> GetAllNotas(bool trackChanges);
        Notas GetNota(int notaId, bool trackChanges);
        void CreateNota(Notas nota);
        IEnumerable<Notas> GetByIds(IEnumerable<int> ids, bool trackChanges);
        void DeleteNota(Notas nota);
    }
}
