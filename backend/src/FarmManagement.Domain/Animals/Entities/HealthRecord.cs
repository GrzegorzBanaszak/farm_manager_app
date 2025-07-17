namespace FarmManagement.Domain.Animals.Entities
{
    public class HealthRecord
    {
        public Guid Id { get; private set; }
        public DateTime CheckDate { get; private set; }
        public string Notes { get; private set; }

        public HealthRecord(DateTime checkDate, string notes)
        {
            Id = new Guid();
            CheckDate = checkDate;
            Notes = notes ?? throw new ArgumentNullException(nameof(notes), "Notes cannot be null");
        }
    }
}
