
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Animals.Domain;
using Animals.Application.Abstractions;

namespace Animals.Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public IEnumerable<Animal> GetAll()
        {
            return _animalRepository.GetAllAsync().Result;
        }

        public async Task<IEnumerable<Animal>> GetAllAsync()
        {
            return await _animalRepository.GetAllAsync();
        }
    }
}