using Animals.Domain;

namespace Animals.Application.Abstractions
{
    public interface IAnimalRepository
    {
        // Task<Animal?> GetByIdAsync(Guid id);
        Task<IEnumerable<Animal>> GetAllAsync();
        // Task AddAsync(Animal animal);
        // Task UpdateAsync(Animal animal);
        // Task DeleteAsync(Guid id);
    }
}
