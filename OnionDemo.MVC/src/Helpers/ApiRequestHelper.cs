﻿using Newtonsoft.Json;
using System.Text.Json;
using System.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Net.Http.Headers;
using System.Net.Http;
using System;

namespace OnionDemo.MVC.src.Helpers
{
    public class ApiRequestHelper : IApiRequestHelper
    {
        private readonly HttpClient client;

        public ApiRequestHelper(HttpClient client)
        {     
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            this.client = new HttpClient(clientHandler);
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await this.client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(data);
                return result;
            }

            throw new Exception("API request failed");
        }

        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var bodyJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(bodyJson, Encoding.UTF8, "application/json");
           
            HttpResponseMessage response = await this.client.PostAsync(endpoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(responseData);
                return result;
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"API request failed with status code {response.StatusCode}: {errorMessage}");
            }

            throw new Exception("API request failed");
        }
    }
}
