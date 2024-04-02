namespace Entities.Exceptions;

public sealed class DocenteNotFoundException : NotFoundException
{
    public DocenteNotFoundException(Guid DocenteId)
        : base($"The Docente with id: {DocenteId} doesn't exist in the database.")
    {
    }
}