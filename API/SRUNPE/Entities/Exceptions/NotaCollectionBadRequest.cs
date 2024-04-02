namespace Entities.Exceptions;

public sealed class NotaCollectionBadRequest : BadRequestException
{
    public NotaCollectionBadRequest()
        : base("Nota collection sent from a client is null.")
    {
    }
}
