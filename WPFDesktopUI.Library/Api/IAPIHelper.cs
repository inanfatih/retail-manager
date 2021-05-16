using System.Net.Http;
using System.Threading.Tasks;
using WPFDesktopUI.Models;

namespace WPFDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}
