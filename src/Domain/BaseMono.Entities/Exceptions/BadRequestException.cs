namespace BaseMono.Entities.Exceptions
{
    internal class BadRequestException : Exception
    {
        protected BadRequestException(string? message) : base(message)
        {
        }
    }
}
