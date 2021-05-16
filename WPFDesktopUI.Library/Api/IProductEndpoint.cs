using System.Collections.Generic;
using System.Threading.Tasks;
using WPFDesktopUI.Library.Models;

namespace WPFDesktopUI.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}