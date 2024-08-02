using _3_MVCApiCLient.DTO;
using _3_MVCApiCLient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace _3_MVCApiCLient.ApiClients
{
    public class ApiUser
    {
        private string BASE_URL = "http://localhost:49280/api/";

        //Pour la méthode ReadAsAsync : installer le package Microsoft.AspNet.WebApi.Client
        //AllUsers
        public async Task<List<User>> AllUsers()
        {
            using (HttpResponseMessage reponse = await ApiTools.httpClient.GetAsync(BASE_URL + "Users"))
            {
                if (reponse.IsSuccessStatusCode)
                {
                    //pour un projet Winform - installer package AspNet.webApi.client
                    List<User> lst = await reponse.Content.ReadAsAsync<List<User>>();
                    return lst;
                }
                else
                {
                    throw new Exception(reponse.ReasonPhrase);
                }
            }
        }

        //AddUser
        public async Task<Uri> AddUser(User u)
        {
            using (HttpResponseMessage reponse = await ApiTools.httpClient.PostAsJsonAsync(BASE_URL + "Users", u))
            {
                reponse.EnsureSuccessStatusCode(); //cette méthode lève une exception en cas d'échec de la requête

                //retourne l'URI du contact crée
                return reponse.Headers.Location;
            }
        }

        //UpdateUser
        public async Task<HttpStatusCode> UpdateUser(User u)
        {
            using (HttpResponseMessage reponse = await ApiTools.httpClient.PutAsJsonAsync(BASE_URL + $"Users", u))
            {
                return reponse.StatusCode;
            }
        }

        //DeleteUser
        public async Task<HttpStatusCode> DeleteUser(int id)
        {
            using (HttpResponseMessage reponse = await ApiTools.httpClient.DeleteAsync(BASE_URL + $"Users/"+id))
            {
                return reponse.StatusCode;
            }
        }

        //GetById
        public async Task<User> GetById(int id)
        {
            using (HttpResponseMessage reponse = await ApiTools.httpClient.GetAsync(BASE_URL + "Users/" + id))
            {
                if (reponse.IsSuccessStatusCode)
                {
                    //pour un projet Winform - installer package AspNet.webApi.client
                    User u = await reponse.Content.ReadAsAsync<User>();
                    return u;
                }
                else
                {
                    throw new Exception(reponse.ReasonPhrase);
                }
            }
        }

        //CheckLogin
        public async Task<HttpStatusCode> CheckLogin(UserDTO dto)
        {
            using (HttpResponseMessage reponse = await ApiTools.httpClient.PostAsJsonAsync(BASE_URL + "check-login", dto))
            {
                return reponse.StatusCode;
            }
        }
    }
}