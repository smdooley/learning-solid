using Animals.Application.Abstractions;
using Animals.Domain;

namespace Animals.Infrastructure.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly List<Animal> _animals = new List<Animal>
        {
            new Cat(Guid.NewGuid(), "Whiskers"),
            new Dog(Guid.NewGuid(), "Buddy"),
            new Sheep(Guid.NewGuid(), "Dolly"),
            new Cow(Guid.NewGuid(), "Bessie")
        };

        public async Task<IEnumerable<Animal>> GetAllAsync()
        {
            return await Task.FromResult<IEnumerable<Animal>>(_animals);
        }
    }
}