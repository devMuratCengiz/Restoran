﻿namespace Restoran.WebUI.Helpers
{
    public class HttpClientInstance
    {
        public static HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7111/api/");
            return client;
        }
    }
}
