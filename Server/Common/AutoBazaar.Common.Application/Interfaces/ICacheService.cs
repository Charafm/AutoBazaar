using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces
{
    public interface ICacheService
    {
        T? Get<T>(int id) where T : IdBasedEntity<int>;
        T? Get<T>(string key) where T : class;
        void Refresh(string key);
        void Refresh<T>(int id) where T : IdBasedEntity<int>;
        void Remove(string key);
        void Remove<T>(int id) where T : IdBasedEntity<int>;
        void Set(string key, object? value);
        void Set<T>(T? value) where T : IdBasedEntity<int>;
    }
}
