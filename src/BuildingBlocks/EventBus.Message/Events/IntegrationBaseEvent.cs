namespace EventBus.Message.Events
{
    public class IntegrationBaseEvent
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public IntegrationBaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }
    }
}
