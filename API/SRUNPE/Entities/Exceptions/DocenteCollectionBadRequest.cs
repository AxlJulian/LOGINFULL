namespace Entities.Exceptions;

public sealed class DocenteCollectionBadRequest : BadRequestException
{
    public DocenteCollectionBadRequest()
        : base("Docente collection sent from a client is null.")
    {
    }
}
