using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class Schedule : BaseEntity<Guid>
    {
        public Guid? OwnerId { get; set; } // person / org id
        public Guid? VehicleId { get; set; }   // optional link to vehicle
        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }
        public ScheduleType Type { get; set; }
        public ScheduleStatus Status { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
