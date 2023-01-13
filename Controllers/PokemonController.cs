using Microsoft.AspNetCore.Mvc;
using pokemon_api_net6.IRepository;
using pokemon_api_net6.Models;
using System.ComponentModel.DataAnnotations;

namespace pokemon_api_net6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PokemonController : Controller
    {
        private readonly IRepositoryPokemon _iRepositoryPokemon;

        public PokemonController(IRepositoryPokemon iRepositoryPokemon)
        {
            _iRepositoryPokemon = iRepositoryPokemon;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Pokemon>))]
       
        public IActionResult GetPokemons()
        {
            var result = _iRepositoryPokemon.GetPokemons();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
              
            return Ok(result);
        }

    }
}
