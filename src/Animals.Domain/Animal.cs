using System;

namespace Animals.Domain
{
    public abstract class Animal
    {
        public Guid Id { get; init; }
        public string Name { get; protected set; }

        protected Animal(Guid id, string name)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            Name = string.IsNullOrWhiteSpace(name) 
                ? throw new ArgumentException("Name cannot be empty.", nameof(name)) 
                : name.Trim();
        }
    }
}