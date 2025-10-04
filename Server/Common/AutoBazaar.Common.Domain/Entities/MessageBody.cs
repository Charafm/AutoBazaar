using AutoBazaar.Common.Domain.BaseEntities;

namespace AutoBazaar.Common.Domain.Entities
{
    public class MessageBody : BaseEntity<Guid>
    {
        public string? Subject { get; set; }
        public string Content { get; set; }
        public List<Message>? Messages { get; set; }
    }
}