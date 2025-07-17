namespace FarmManagement.Domain.Animals.ValueObjects
{
    public record AnimalId(Guid Value)
    {
        public override string ToString() => Value.ToString();
    }
}
