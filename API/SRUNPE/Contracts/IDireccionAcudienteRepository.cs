using Entities.Models.D_Acudiente;
using System.Linq.Expressions;

namespace Contracts;
public interface IDireccionAcudienteRepository
{
    IEnumerable<DireccionAcudiente> GetAllDireccionAcudientes(bool trackChanges);
    DireccionAcudiente GetDireccionAcudiente(Guid direccionAcudienteId, bool trackChanges);
    void CreateDireccionAcudiente(DireccionAcudiente direccionAcudiente);
    IEnumerable<DireccionAcudiente> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    void DeleteDireccionAcudiente(DireccionAcudiente direccionAcudiente);
    IEnumerable<DireccionAcudiente> FindByCondition(Expression<Func<DireccionAcudiente, bool>> expression);
    void UpdateDireccionAcudiente(DireccionAcudiente direccionAcudiente);
}

