using pokemon_api_net6.Data;
using pokemon_api_net6.Dto;
using pokemon_api_net6.IRepository;
using pokemon_api_net6.Models;

namespace pokemon_api_net6.Repository
{
    public class PokemonRepositorylmpl : IRepositoryPokemon
    {
        private readonly DataContext _dataContext;

        public PokemonRepositorylmpl(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public bool DeletePokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemon(int id)
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemon(string name)
        {
            throw new NotImplementedException();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pokemon> GetPokemons()
        {
           return _dataContext.Pokemon.ToList();
        }

        public Pokemon GetPokemonTrimToUpper(PokemonDto pokemonCreate)
        {
            throw new NotImplementedException();
        }

        public bool PokemonExists(int pokeId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
