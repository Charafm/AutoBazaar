namespace AutoBazaar.Common.Domain.BaseEntities
{
    public abstract class TitledMultiLingualEntity<TTranslation, TId> : BaseMultiLingualEntity<TTranslation, TId>,
        IMultiLingualEntity<TTranslation>
        where TTranslation : class, IEntityTranslation
    {
        public virtual string? Title { get; set; }
        public virtual string? Description { get; set; }
    }
}