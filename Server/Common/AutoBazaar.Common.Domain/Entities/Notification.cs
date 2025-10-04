using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.DataTransferObjects;
using AutoBazaar.Common.Domain.Enums;



namespace AutoBazaar.Common.Domain.Entities
{
    public class Notification : BaseEntity<Guid>
    {
        public NotificationEnum Target { get; set; }
        public bool IsRead { get; set; }
        public bool IsSeen{ get; set; }
        public Guid NotificationBodyId { get; set; }
        public NotificationBody? NotificationBody { get; set; }
        public string? UserId { get; set; }
        public UserDto? User { get; set; }
    }
}
