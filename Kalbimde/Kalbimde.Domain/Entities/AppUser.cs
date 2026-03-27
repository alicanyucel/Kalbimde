using Microsoft.AspNetCore.Identity;

namespace Kalbimde.Domain.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join(' ', FirstName, LastName);
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpires { get; set; }
        public virtual ICollection<ProfilePhoto> Photos { get; set; } = new List<ProfilePhoto>();
        public virtual ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public virtual ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
        public virtual ICollection<Like> LikesGiven { get; set; } = new List<Like>();
        public virtual ICollection<Like> LikesReceived { get; set; } = new List<Like>();
    }
}
