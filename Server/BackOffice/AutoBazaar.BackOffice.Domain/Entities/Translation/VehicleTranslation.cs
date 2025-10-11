using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities.Translation
{
    public class VehicleTranslation : BaseEntityTranslation<Vehicle, Guid>
    {
        public string Name { get; set; } = null!;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        // maybe: SEO fields, specs localized text, etc.
    }

}
