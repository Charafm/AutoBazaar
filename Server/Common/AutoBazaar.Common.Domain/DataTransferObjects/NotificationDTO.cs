namespace AutoBazaar.Common.Domain.DataTransferObjects
{
    public class NotificationDTO
    {
        public Guid NotificationId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    
}
