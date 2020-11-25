using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SWAPIHelper
    {
        private const string _baseURL = "https://swapi.dev/api/";
        private HttpClient httpClient = new HttpClient();
        public SWAPIHelper()
        {
            httpClient.BaseAddress = new Uri(_baseURL);
        }
        
        public async Task<SWAPIPerson> GetPersonByIDAsync(int id)
        {
            
            var nameRequest = await httpClient.GetAsync("people/" + id);

            var responseBody = await nameRequest.Content.ReadAsStringAsync();

            SWAPIPerson requestedPerson = JsonConvert.DeserializeObject<SWAPIPerson>(responseBody);

            return requestedPerson;
        }

        public async Task<SWAPIVehicle> GetVehicleByIDAsync(int id)
        {
            var vehicleRequest = await httpClient.GetAsync("vehicles/" + id);

            var vehicleResponse = await vehicleRequest.Content.ReadAsStringAsync();

            SWAPIVehicle requestedVehicle = JsonConvert.DeserializeObject<SWAPIVehicle>(vehicleResponse);

            return requestedVehicle;
        }
    }
}
