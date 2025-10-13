using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class VehicleSpecs : ValueObject
    {
        private VehicleSpecs() { } // EF

        public string Make { get; private set; } = null!;
        public string Model { get; private set; } = null!;
        public string? Trim { get; private set; }
        public int Year { get; private set; }
        public FuelType? FuelType { get; private set; }
        public int Seats { get; private set; }
        public TransmitionType TransmitionType { get; set; }
        public VehicleSpecs(string make, string model, int year, string? trim = null, FuelType? fuel = null, int seats = 4)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model)) throw new ArgumentException("make/model required");
            Make = make.Trim();
            Model = model.Trim();
            Year = year;
            Trim = trim?.Trim();
            FuelType = fuel;
            Seats = seats;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Make;
            yield return Model;
            yield return Trim;
            yield return Year;
            yield return FuelType;
            yield return Seats;
        }
    }

}
