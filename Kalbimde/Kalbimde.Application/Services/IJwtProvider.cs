using Kalbimde.Application.Features.Auth.Login;
using Kalbimde.Domain.Entities;

namespace Kalbimde.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
