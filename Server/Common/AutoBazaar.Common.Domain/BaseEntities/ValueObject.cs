using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.BaseEntities
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object?> GetEqualityComponents();


        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            var vo = (ValueObject)obj;
            return GetEqualityComponents().SequenceEqual(vo.GetEqualityComponents());
        }


        public override int GetHashCode()
        {
            return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate(0, (a, b) => HashCode.Combine(a, b));
        }
    }
}
