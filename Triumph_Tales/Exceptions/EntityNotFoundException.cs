namespace Triumph_Tales.Exceptions;

public class EntityNotFoundException : ApplicationException
{
    public EntityNotFoundException(string errorMessage) : base(errorMessage)
    { }
}
