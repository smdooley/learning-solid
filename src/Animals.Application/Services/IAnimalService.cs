using System;
using Animals.Domain;

namespace Animals.Application.Services
{
    public interface IAnimalService
    {
        // Define methods for animal-related operations
        IEnumerable<Animal> GetAll();
        Task<IEnumerable<Animal>> GetAllAsync();
    }
}   