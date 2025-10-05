using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.BaseEntities
{
    public abstract class ValueObject
    {
        // Subclasses must yield components in stable order.
        protected abstract IEnumerable<object?> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj is null || obj.GetType() != GetType()) return false;

            var other = (ValueObject)obj;

            // Materialize to avoid double enumeration / deferred execution problems.
            var thisValues = GetEqualityComponents().ToList();
            var otherValues = other.GetEqualityComponents().ToList();

            return thisValues.SequenceEqual(otherValues);
        }

        public override int GetHashCode()
        {
            var values = GetEqualityComponents();

            var hash = new HashCode();
            foreach (var val in values)
            {
                // HashCode.Add handles nulls correctly.
                hash.Add(val);
            }

            return hash.ToHashCode();
        }

        public static bool operator ==(ValueObject? left, ValueObject? right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        public static bool operator !=(ValueObject? left, ValueObject? right) => !(left == right);
    }
}
