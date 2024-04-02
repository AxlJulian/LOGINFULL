using Entities.Models.D_Docente;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;

namespace Service.Contracts;

public interface IDocenteService
{
    IEnumerable<DocenteDto> GetAllDocentes(bool trackChanges);
    DocenteDto GetDocente(Guid id, bool trackChanges);
    DocenteDto CreateDocente(DocenteForCreationDto docente);
    IEnumerable<DocenteDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    (IEnumerable<DocenteDto> docente, string ids) CreateDocenteCollection(IEnumerable<DocenteForCreationDto> docenteCollection);
    void DeleteDocente(Guid docenteId, bool trackChanges);
    void UpdateDocente(Guid docenteId, DocenteForUpdateDto docenteForUpdate, bool trackChanges);
    void AssignHorarioToDocente(Guid docenteId, Guid horarioId);
    void AssignAulaToDocente(Guid docenteId, Guid aulaId);
    void AssignCursosToDocente(Guid docenteId, IEnumerable<Guid> cursoIds);
    //bool AssignMateriasToDocente(Guid docenteId, AssignMateriasDto dto);


}





