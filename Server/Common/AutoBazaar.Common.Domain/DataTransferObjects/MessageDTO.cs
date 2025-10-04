namespace AutoBazaar.Common.Domain.DataTransferObjects
{
    public class MessageDTO
    {

        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string? Subject { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
    }
}
