using AutoBazaar.Common.Domain.BaseEntities;

namespace AutoBazaar.Common.Domain.Entities
{
    public class NotificationBody : TitledEntity
    {
        public string Title {  get; set; }
        public string Description {  get; set; }
        public List<Notification>? Notifications { get; set; }
    }
}
