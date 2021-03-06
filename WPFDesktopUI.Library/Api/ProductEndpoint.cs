﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WPFDesktopUI.Library.Models;

namespace WPFDesktopUI.Library.Api
{
    public class ProductEndpoint : IProductEndpoint
    {
        private IAPIHelper _apiHelper { get; }
        public ProductEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<ProductModel>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("api/Product"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<ProductModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
