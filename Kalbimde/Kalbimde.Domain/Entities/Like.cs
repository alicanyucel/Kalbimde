using Kalbimde.Domain.Abstractions;

namespace Kalbimde.Domain.Entities;

public class Like : Entity
{
    public DateTime LikedAt { get; set; }

    public Guid LikerId { get; set; }
    public virtual AppUser? Liker { get; set; }

    public Guid LikedUserId { get; set; }
    public virtual AppUser? LikedUser { get; set; }
}
