using System;
using AutoMapper;
using FarmManagement.Application.Animals.Dtos;
using FarmManagement.Application.Animals.Queries;
using FarmManagement.Domain.Animals.Aggregate;
using FarmManagement.Domain.Animals.ValueObjects;
using FarmManagement.SharedKernel.Interfaces;
using MediatR;

namespace FarmManagement.Application.Animals.Handler;

public class GetAnimalByIdHandler : IRequestHandler<GetAnimalByIdQuery, AnimalDto?>
{
    private readonly IRepository<Animal, AnimalId> _repo;
    private readonly IMapper _mapper;

    public GetAnimalByIdHandler(IRepository<Animal, AnimalId> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<AnimalDto?> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
    {
        var data = await _repo.GetById(new AnimalId(request.Id));

        return data is not null ? _mapper.Map<AnimalDto>(data) : null;

    }
}
