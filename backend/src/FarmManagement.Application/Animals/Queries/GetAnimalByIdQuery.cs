using FarmManagement.Application.Animals.Dtos;
using MediatR;

namespace FarmManagement.Application.Animals.Queries;

public record class GetAnimalByIdQuery(Guid Id) : IRequest<AnimalDto>;
