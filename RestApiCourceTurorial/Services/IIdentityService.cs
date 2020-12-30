using System;
using System.Threading.Tasks;
using RestApiCourceTurorial.Domain;

namespace RestApiCourceTurorial.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);

        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}
