namespace AutoBazaar.Common.Domain.BaseEntities
{
    public interface IDeletableEntity
    {
        public bool? IsDeleted { get; set; }
    }
}