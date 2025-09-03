
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Animals.Domain;

namespace Animals.Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly List<Animal> _animals;

        public AnimalService()
        {
            // Initialize any dependencies here
            _animals = new List<Animal>
            {
                new Cat("Whiskers"),
                new Cow("Bessie"),
                new Dog("Rex"),
                new Sheep("Dolly")
            };
        }

        public IEnumerable<Animal> GetAll()
        {
            return _animals;
        }

        public async Task<IEnumerable<Animal>> GetAllAsync()
        {
            return await Task.FromResult(_animals);
        }
    }
}