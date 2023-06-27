
using MongoDB.Bson.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FetchApiSirene.DataAccess.Models.Dto;
using FetchApiSirene.DataAccess.Models;

namespace FetchApiSirene.BusinessLogic.Services
{
    public class EstablishmentsServices
    {
        public async Task<EstablishmentsDto> GetEstablishmentsDataAsync()
        {
            using (var client = new HttpClient())
            {
                var url = "https://api.insee.fr/catalogue/site/themes/wso2/subthemes/insee/pages/item-info.jag?name=Sirene&version=V3&provider=insee#!/Etablissement/findSiretByQ";

                client.DefaultRequestHeaders.Add("Authorization", "799acb30-0560-3826-a941-375cf6d0bd83");

                HttpResponseMessage response = await client.GetAsync(url);


                if (response.IsSuccessStatusCode == true)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var vehicles = Newtonsoft.Json.JsonConvert.DeserializeObject<EstablishmentsDto>(content);

                    var Adresse = vehicles.Adresse.ToString();
                    var Establishments = vehicles.Denomination.ToString();
                    Console.WriteLine($"Nom du véhicule: {Adresse}, Modèle: {Establishments}");
                }
                else
                {
                    Console.WriteLine("Erreur lors de la récupération des données.");
                }
            }
            return new EstablishmentsDto();
        }
    }
}