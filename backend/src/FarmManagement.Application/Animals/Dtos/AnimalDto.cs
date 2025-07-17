namespace FarmManagement.Application.Animals.Dtos
{
    public record AnimalDto(Guid Id, string Tag, string Species, DateTime DateOfBirth);
}
