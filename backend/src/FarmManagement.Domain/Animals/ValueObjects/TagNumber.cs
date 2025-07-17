using FarmManagement.Domain.Animals.Exceptions;

namespace FarmManagement.Domain.Animals.ValueObjects;

public record TagNumber
{
    public string Value { get; }
    public TagNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > 20)
            throw new AnimalDomainException("Invalid tag number");
        Value = value;
    }
}


