using AutoBazaar.Common.Domain.Enums;

namespace AutoBazaar.Common.Domain.DataTransferObjects
{
    public class GetAllNotificationsByCriteriaRequestDTO
    {
        public NotificationEnum? Target { get; set; }
        public string UserId{ get; set; }
        public bool? IsRead { get; set; }
        public bool? IsSeen { get; set; }
    }
    public class GetAllNotificationsByCriteriaResponseDTO
    {
        public List<AutoBazaar.Common.Domain.Entities.Notification> Notifications { get; set; }
        public int totalCount { get; set; }

    }

}
