using Kalbimde.Domain.Abstractions;

namespace Kalbimde.Domain.Entities
{
    public class Match : Entity
    {
        public DateTime MatchedAt { get; set; }

        public Guid User1Id { get; set; }
        public virtual AppUser? User1 { get; set; } 

        public Guid User2Id { get; set; }
        public virtual AppUser? User2 { get; set; } = null;
    }
}
