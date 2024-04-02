using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface INotaService
    {
        IEnumerable<NotaDto> GetAllNotas(bool trackChanges);
        NotaDto GetNota(int notaId, bool trackChanges);
        NotaDto CreateNota(NotaForCreationDto nota);
        IEnumerable<NotaDto> GetByIds(IEnumerable<int> ids, bool trackChanges);
        (IEnumerable<NotaDto> notas, string ids) CreateNotaCollection(IEnumerable<NotaForCreationDto> notaCollection);
        void DeleteNota(int notaId, bool trackChanges);
        void UpdateNota(int notaId, NotaForUpdateDto notaForUpdate, bool trackChanges);
    }
}

