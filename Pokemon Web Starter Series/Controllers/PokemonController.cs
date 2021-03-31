using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Web_Starter_Series
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public List<Pokemon> Get()
        {
            var MyList = new List<Pokemon>();

            var Bulbasaur = new Pokemon();
            Bulbasaur.Number = 1;
            Bulbasaur.Name = "Bulbasaur";

            MyList.Add(Bulbasaur);

            return MyList;
        }
    }
}
