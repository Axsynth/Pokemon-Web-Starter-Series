using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Web_Starter_Series
{
    public class PokemonData
    {

        public PokemonData()
        {
            // Creating a list of Pokemon.
            List<Pokemon> Pokemon = new List<Pokemon>();

            Pokemon.Add(new Pokemon()
            {
                Number = 1,
                Name = "Bulbasaur",
                Type1 = "Grass",
                Type2 = "Poison" 
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 2,
                Name = "Ivysaur",
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 3,
                Name = "Venusaur",
                Type1 = "Grass",
                Type2 = "Poison"
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 4,
                Name = "Charmander",
                Type1 = "Fire",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 5,
                Name = "Charmeleon",
                Type1 = "Fire",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 6,
                Name = "Charmander",
                Type1 = "Fire",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 7,
                Name = "Squirtle",
                Type1 = "Water",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 8,
                Name = "Wartortle",
                Type1 = "Water",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 9,
                Name = "Blastoise",
                Type1 = "Water",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 10,
                Name = "Caterpie",
                Type1 = "Water",
                Type2 = "Bug",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 11,
                Name = "Metapod",
                Type1 = "Water",
                Type2 = "Bug",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 12,
                Name = "Butterfree",
                Type1 = "Bug",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 13,
                Name = "Weedle",
                Type1 = "Bug",
                Type2 = "Poison",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 14,
                Name = "Kakuna",
                Type1 = "Bug",
                Type2 = "Poison",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 15,
                Name = "Beedrill",
                Type1 = "Bug",
                Type2 = "Poison",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 16,
                Name = "Pidget",
                Type1 = "Normal",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 17,
                Name = "Pidgeotto",
                Type1 = "Normal",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 18,
                Name = "Pidgeot",
                Type1 = "Normal",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 19,
                Name = "Rattata",
                Type1 = "Normal",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 20,
                Name = "Raticate",
                Type1 = "Normal",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 21,
                Name = "Spearow",
                Type1 = "Normal",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 22,
                Name = "Fearow",
                Type1 = "Normal",
                Type2 = "Flying",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 23,
                Name = "Ekans",
                Type1 = "Poison",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 24,
                Name = "Arbok",
                Type1 = "Poison",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 25,
                Name = "Pikachu",
                Type1 = "Electric",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 26,
                Name = "Raichu",
                Type1 = "Electric",
                Type2 = "",
            });
            Pokemon.Add(new Pokemon()
            {
                Number = 133,
                Name = "Eevee",
                Type1 = "Normal",
                Type2 = "",
            });
        }
    }
}
