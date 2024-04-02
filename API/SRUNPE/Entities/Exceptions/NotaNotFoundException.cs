using Entities.Models.D_Notas;

namespace Entities.Exceptions;

public sealed class NotaNotFoundException : NotFoundException
{
    public NotaNotFoundException(int NotaId)
        : base($"The CandidatoEstudiante with id: {NotaId} doesn't exist in the database.")
    {
    }
}
