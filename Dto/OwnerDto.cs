using pokemon_api_net6.Models;

namespace pokemon_api_net6.Dto
{
    public class OwnerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
    }
}
