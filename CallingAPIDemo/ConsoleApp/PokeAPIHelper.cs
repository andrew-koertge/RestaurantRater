using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PokeAPIHelper
    {
        private const string _baseURL = "https://pokeapi.co/api/v2/";
        private HttpClient httpClient = new HttpClient();

        public PokeAPIHelper()
        {
            httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<PokeAPIPokemon> GetPokemonByNameAsync(string name)
        {
            var pokemonRequest = await httpClient.GetAsync("pokemon/" + name);

            var pokemonResponse = await pokemonRequest.Content.ReadAsStringAsync();

            PokeAPIPokemon requestedPokemon = JsonConvert.DeserializeObject<PokeAPIPokemon>(pokemonResponse);

            return requestedPokemon;
        }
    }
}
