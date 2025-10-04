using AutoBazaar.Common.Domain.BaseEntities;

namespace AutoBazaar.Common.Domain.Entities
{
    public class CommentBody : BaseEntity<Guid>
    {
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }

}
