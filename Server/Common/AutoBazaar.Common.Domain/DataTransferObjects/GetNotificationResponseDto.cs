using AutoBazaar.Common.Domain.Entities;

namespace AutoBazaar.Common.Domain.DataTransferObjects
{
    public class GetNotificationResponseDto
    {
        public List<Notification> Notifications { get; set; }
        public int totalCount { get; set; }
    }
}
