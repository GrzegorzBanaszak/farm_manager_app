using FarmManagement.Application.Animals.Dtos;
using MediatR;

namespace FarmManagement.Application.Animals.Commands
{
    public record CreateAnimalCommand(string Tag, string Species, DateTime DateOfBirth) : IRequest<AnimalDto>;
}
