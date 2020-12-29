using RMWPFDesktopUI.Models;
using System.Threading.Tasks;

namespace RMWPFDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}