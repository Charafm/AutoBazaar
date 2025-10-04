using AutoBazaar.Common.Domain.BaseEntities;

namespace AutoBazaar.Common.Domain.Entities
{
    public class Message : BaseEntity<Guid>
    {
        public Guid SenderId { get; set; }
        public Guid TargetId { get; set; }
        public MessageBody Body { get; set; }
    }
}
