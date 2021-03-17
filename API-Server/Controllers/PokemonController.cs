using System.Dynamic;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Server.Controllers
{

    [ApiController]
    [Route("api/Pokemon")]
    public class PokemonController: ControllerBase
    {
        static List<Pokemon> pokeList = new List<Pokemon>(){
            new Pokemon(){Name = "Pikachu"},
            new Pokemon(){Name = "Lickytounge"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokeList[0]);
        }
    }
}
