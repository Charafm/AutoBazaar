using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class GeoLocation : ValueObject
    {
        private GeoLocation() { } // EF

        public double Latitude { get; private set; }  // decimal degrees
        public double Longitude { get; private set; }

        public GeoLocation(double lat, double lon)
        {
            if (lat < -90 || lat > 90) throw new ArgumentOutOfRangeException(nameof(lat));
            if (lon < -180 || lon > 180) throw new ArgumentOutOfRangeException(nameof(lon));
            Latitude = lat;
            Longitude = lon;
        }

        public double DistanceInMetersTo(GeoLocation other)
        {
            // Haversine formula
            double R = 6371000; // meters
            var dLat = DegreesToRadians(other.Latitude - Latitude);
            var dLon = DegreesToRadians(other.Longitude - Longitude);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(DegreesToRadians(Latitude)) * Math.Cos(DegreesToRadians(other.Latitude)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private static double DegreesToRadians(double d) => d * Math.PI / 180.0;

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Latitude;
            yield return Longitude;
        }
    }

}
