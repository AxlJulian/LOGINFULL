using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models.D_Notas;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class NotaService : INotaService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public NotaService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<NotaDto> GetAllNotas(bool trackChanges)
        {
            var notas = _repository.Nota.GetAllNotas(trackChanges);

            var notasDto = _mapper.Map<IEnumerable<NotaDto>>(notas);

            return notasDto;
        }

        public NotaDto GetNota(int id, bool trackChanges)
        {
            var nota = _repository.Nota.GetNota(id, trackChanges);
            if (nota is null)
                throw new NotaNotFoundException(id);

            var notaDto = _mapper.Map<NotaDto>(nota);
            return notaDto;
        }

        public NotaDto CreateNota(NotaForCreationDto nota)
        {
            var notaEntity = _mapper.Map<Notas>(nota);

            _repository.Nota.CreateNota(notaEntity);
            _repository.Save();

            var notaToReturn = _mapper.Map<NotaDto>(notaEntity);

            return notaToReturn;
        }

        public IEnumerable<NotaDto> GetByIds(IEnumerable<int> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var notaEntities = _repository.Nota.GetByIds(ids, trackChanges);
            if (ids.Count() != notaEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var notasToReturn = _mapper.Map<IEnumerable<NotaDto>>(notaEntities);

            return notasToReturn;
        }

        public void DeleteNota(int notaId, bool trackChanges)
        {
            var nota = _repository.Nota.GetNota(notaId, trackChanges);
            if (nota is null)
            {
                throw new NotaNotFoundException(notaId);
            }

            _repository.Nota.DeleteNota(nota);
            _repository.Save();
        }

        public void UpdateNota(int notaId, NotaForUpdateDto notaForUpdate, bool trackChanges)
        {
            var notaEntity = _repository.Nota.GetNota(notaId, trackChanges);
            if (notaEntity is null)
                throw new NotaNotFoundException(notaId);
            _mapper.Map(notaForUpdate, notaEntity);
            _repository.Save();
        }

        public (IEnumerable<NotaDto> notas, string ids) CreateNotaCollection(IEnumerable<NotaForCreationDto> notaCollection)
        {
            if (notaCollection is null)
                throw new NotaCollectionBadRequest();

            var notaEntities = _mapper.Map<IEnumerable<Notas>>(notaCollection);
            foreach (var nota in notaEntities)
            {
                _repository.Nota.CreateNota(nota);
            }

            _repository.Save();

            var notaCollectionToReturn = _mapper.Map<IEnumerable<NotaDto>>(notaEntities);
            var ids = string.Join(",", notaCollectionToReturn.Select(c => c.NotaId));

            return (notas: notaCollectionToReturn, ids: ids);
        }
    }
}
