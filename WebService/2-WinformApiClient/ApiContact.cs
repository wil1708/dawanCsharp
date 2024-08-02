using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _2_WinformApiClient
{
    public class ApiContact
    {
        private string BASE_URI = "http://localhost:49280/api/";

        //Liste des contacts

        public async Task<List<Contact>> AllContacts()
        {
            using (HttpResponseMessage reponse = await ApiHelper.ApiClient.GetAsync(BASE_URI + "Contact"))
            {
                if (reponse.IsSuccessStatusCode)
                {
                    //pour un projet Winform - installer package AspNet.webApi.client
                    List<Contact> lst = await reponse.Content.ReadAsAsync<List<Contact>>();
                    return lst;
                }
                else
                {
                    throw new Exception(reponse.ReasonPhrase);
                }
            }
        } //appel de la méthode dispose

        //Méthode d'ajout

        public async Task<Uri> AddContact(Contact c)
        {
            using (HttpResponseMessage reponse = await ApiHelper.ApiClient.PostAsJsonAsync(BASE_URI + "Contact", c))
            {
                reponse.EnsureSuccessStatusCode(); //cette méthode lève une exception en cas d'échec de la requête

                //retourne l'URI du contact crée
                return reponse.Headers.Location;
            }
        }
        //Méthode de suppression
        public async Task<HttpStatusCode> DeleteContact(int id)
        {
            using (HttpResponseMessage reponse = await ApiHelper.ApiClient.DeleteAsync(BASE_URI + $"Contact/{id}"))
            {
                return reponse.StatusCode;
            }
        }
        //Méthode de MAJ
        public async Task<HttpStatusCode> UpdateContact(int id, Contact c)
        {
            using (HttpResponseMessage reponse = await ApiHelper.ApiClient.PutAsJsonAsync(BASE_URI + $"Contact/{id}", c))
            {
                return reponse.StatusCode;
            }
        }
    }
}
