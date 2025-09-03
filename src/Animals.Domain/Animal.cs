using System;

namespace Animals.Domain
{
    public abstract class Animal
    {
        public string Name { get; protected set; }

        protected Animal(string name)
        {
            Name = string.IsNullOrWhiteSpace(name) 
                ? throw new ArgumentException("Name cannot be empty.", nameof(name)) 
                : name.Trim();
        }
    }
}