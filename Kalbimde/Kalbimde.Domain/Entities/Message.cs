using Kalbimde.Domain.Abstractions;

namespace Kalbimde.Domain.Entities;

public class Message : Entity
{
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }

    public Guid SenderId { get; set; }
    public virtual AppUser? Sender { get; set; }

    public Guid ReceiverId { get; set; }
    public virtual AppUser? Receiver { get; set; }
}
