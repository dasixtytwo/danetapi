using System.Threading.Tasks;
using DaNetApi.Models;

namespace DaNetApi.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
    }
}
