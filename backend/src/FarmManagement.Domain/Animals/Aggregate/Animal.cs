using FarmManagement.Domain.Animals.Entities;
using FarmManagement.Domain.Animals.ValueObjects;

namespace FarmManagement.Domain.Animals.Aggregate
{
    public class Animal
    {
        public AnimalId Id { get; private set; }
        public TagNumber Tag { get; private set; }
        public string Species { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        private readonly List<HealthRecord> _healthRecords = new();
        public IReadOnlyCollection<HealthRecord> HealthRecords => _healthRecords;

        private Animal() { }

        public Animal(AnimalId id, TagNumber tag, string species, DateTime dob)
        {
            Id = id;
            Tag = tag;
            Species = species;
            DateOfBirth = dob;
        }

        public void RecordHealth(HealthRecord record)
        {
            _healthRecords.Add(record);
        }
    }
}
