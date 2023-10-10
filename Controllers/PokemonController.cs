using Microsoft.AspNetCore.Mvc;
using PokemonReviewAPI.Data;
using PokemonReviewAPI.Dto;
using PokemonReviewAPI.Interfaces;
using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly DataContext _context;

        public PokemonController(IPokemonRepository pokemonRepository, DataContext context)
        {
            _pokemonRepository = pokemonRepository;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }

        [HttpGet("{pokeId}")]
        [ProducesResponseType(200,Type=typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId)
        {
            if (!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();

            var pokemon = _pokemonRepository.GetPokemon(pokeId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemon);
        }



    }
}
