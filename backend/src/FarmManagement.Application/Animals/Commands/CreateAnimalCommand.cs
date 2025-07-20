using FarmManagement.Application.Animals.Dtos;


namespace FarmManagement.Application.Animals.Commands
{
    public record CreateAnimalCommand(string Tag, string Species, DateTime DateOfBirth) : MediatR.IRequest<AnimalDto>;
}
