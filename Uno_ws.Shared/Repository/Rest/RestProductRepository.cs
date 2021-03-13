//  ---------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  ---------------------------------------------------------------------------------

using Uno_ws.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uno_ws.Repository.Rest
{
    /// <summary>
    /// Contains methods for interacting with the products backend using REST. 
    /// </summary>
    public class RestProductRepository : IProductRepository
    {
        private readonly HttpHelper _http;

        public RestProductRepository(string baseUrl)
        {
            _http = new HttpHelper(baseUrl);
        }

        public async Task<IEnumerable<Product>> GetAsync() =>
            await _http.GetAsync<IEnumerable<Product>>("product"); 

        public async Task<Product> GetAsync(Guid id) => 
            await _http.GetAsync<Product>($"product/{id}");

        public async Task<IEnumerable<Product>> GetAsync(string search) =>
            await _http.GetAsync<IEnumerable<Product>>($"product/search?value={search}");
    }
}
