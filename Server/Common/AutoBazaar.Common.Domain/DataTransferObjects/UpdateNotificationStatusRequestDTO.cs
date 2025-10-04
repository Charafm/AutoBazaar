namespace AutoBazaar.Common.Domain.DataTransferObjects
{
    public class UpdateNotificationStatusRequestDTO
    {
        public Guid NotificationId { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsSeen { get; set; }
    }
}
