﻿using System.Threading.Tasks;
using WPFDesktopUI.Models;

namespace WPFDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}
