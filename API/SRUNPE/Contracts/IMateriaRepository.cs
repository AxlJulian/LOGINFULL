using Entities.Models.D_DepartamentoAcademico;
using System;
using System.Collections.Generic;

namespace Contracts;

public interface IMateriaRepository
{
    IEnumerable<Materias> GetAllMaterias(bool trackChanges);
    Materias GetMateria(Guid materiaId, bool trackChanges);
    void CreateMateria(Materias materia);
    IEnumerable<Materias> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    void DeleteMateria(Materias materia);
}

