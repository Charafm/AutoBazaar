namespace AutoBazaar.Common.Domain.DataTransferObjects
{
    public class CommentDTO
    {
        public Guid SenderId { get; set; }
        public Guid TargetEntityId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
