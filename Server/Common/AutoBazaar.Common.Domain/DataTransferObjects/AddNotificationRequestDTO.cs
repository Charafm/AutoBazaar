//using SchoolSaas.Domain.Backoffice.Entities;
using AutoBazaar.Common.Domain.Enums;

namespace AutoBazaar.Common.Domain.DataTransferObjects;
public class AddNotificationRequestDTO
{

    public NotificationEnum Target { get; set; }
    public string UserId { get; set; }
    public int Status { get; set; }
}



