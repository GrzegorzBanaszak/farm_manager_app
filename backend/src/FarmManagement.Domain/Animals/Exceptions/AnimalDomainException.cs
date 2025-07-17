namespace FarmManagement.Domain.Animals.Exceptions
{
    public class AnimalDomainException : Exception
    {
        public AnimalDomainException(string message) : base(message) { }
    }
}
