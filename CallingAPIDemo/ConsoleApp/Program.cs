using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PokeAPIHelper pokeAPIHelper = new PokeAPIHelper();
            SWAPIHelper swapiHelper = new SWAPIHelper();
            //SWAPI
            //create method in helper that gets a vehicles name, mass, cost by id
            SWAPIVehicle vehicle = swapiHelper.GetVehicleByIDAsync(8).Result;
            Console.WriteLine("Name: " + vehicle.Name);
            Console.WriteLine("Crew: " + vehicle.Crew);
            Console.WriteLine("Model: " + vehicle.Model);
            Console.WriteLine("");
            //PokeAPI
            //pokemons name, height, weight by name
            PokeAPIPokemon pokemon = pokeAPIHelper.GetPokemonByNameAsync("tyranitar").Result;
            Console.WriteLine("Name: " + pokemon.Name);
            Console.WriteLine("Height: " + pokemon.Height);
            Console.WriteLine("Weight: " + pokemon.Weight);
            Console.ReadKey();        

            //SWAPIPerson lukesName = swapiHelper.GetPersonByIDAsync(1).Result;
            //get people and starships by ID
            //Console.WriteLine("Name: " + lukesName.Name);
            //Console.WriteLine("Height: " + lukesName.Height);
            //Console.WriteLine("Mass: " + lukesName.Mass);
        }
    }
}
