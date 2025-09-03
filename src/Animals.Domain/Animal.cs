namespace Animals.Domain

public abstract class Animal
{
    public Guid Id { get; init; }
    protected string Name { get; set; }

    protected Animal(Guid id, string name)
    {
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
        Name = string.IsNullOrWhiteSpace(name) 
            ? throw new ArgumentException("Name cannot be empty.", nameof(name)) 
            : name.Trim();
    }
}