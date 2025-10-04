using AutoBazaar.Common.Domain.BaseEntities;

namespace AutoBazaar.Common.Domain.Entities
{
    public class Comment : BaseEntity<Guid>
    {
      
        public Guid? TargetEntityId { get; set; } 
        public List<CommentBody> Body { get; set; }
    }
}
