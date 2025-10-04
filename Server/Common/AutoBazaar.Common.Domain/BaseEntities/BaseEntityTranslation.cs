using AutoBazaar.Common.Domain.Constants;
using System.Text.Json.Serialization;

namespace AutoBazaar.Common.Domain.BaseEntities
{
    public abstract class BaseEntityTranslation<TEntity, TId> : BaseEntity<TId>,
        IEntityTranslation<TEntity>
    {
        [JsonIgnore]
        public virtual TEntity? Parent { get; set; }
        public virtual TId? ParentId { get; set; }

        public string LanguageCode { get; set; } = CoreConstants.DefaultLanguageCode;
    }
}