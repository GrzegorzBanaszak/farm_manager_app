using FarmManagement.Application.Animals.Dtos;
using FarmManagement.Domain.Animals.Aggregate;
using FarmManagement.Domain.Animals.ValueObjects;
using FarmManagement.SharedKernel.Interfaces;
using MediatR;

namespace FarmManagement.Application.Animals.Commands;

public class CreateAnimalHandler : IRequestHandler<CreateAnimalCommand, AnimalDto>
{
    private readonly IRepository<Animal, AnimalId> _repo;
    public CreateAnimalHandler(IRepository<Animal, AnimalId> repo)
        => _repo = repo;

    public async Task<AnimalDto> Handle(CreateAnimalCommand request, CancellationToken cancellationToken)
    {
        var animal = new Animal(
            new AnimalId(Guid.NewGuid()),
            new TagNumber(request.Tag),
            request.Species,
            request.DateOfBirth
        );

        await _repo.Add(animal);
        await _repo.SaveChangesAsync();
        return new AnimalDto(animal.Id.Value, animal.Tag.Value, animal.Species, animal.DateOfBirth);

    }
}
