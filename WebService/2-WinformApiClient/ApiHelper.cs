using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _2_WinformApiClient
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient{get; set;}

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("http://localhost:49280/api"); //à faire uniquement si le client pointe vers une seule api
            //Fixer le format des données renvoyées par le serveur - uniquement format JSON
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
