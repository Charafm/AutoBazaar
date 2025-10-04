namespace AutoBazaar.Common.Domain.BaseEntities
{
    public interface IMultiLingualEntity<TTranslation>
        where TTranslation : class, IEntityTranslation
    {
        List<TTranslation> Translations { get; set; }
    }
}