using Kalbimde.Domain.Abstractions;

namespace Kalbimde.Domain.Entities;

public class ProfilePhoto : Entity
{
    public string Url { get; set; } = string.Empty;
    public bool IsMain { get; set; }

    public Guid AppUserId { get; set; }
    public virtual AppUser? AppUser { get; set; }
}
