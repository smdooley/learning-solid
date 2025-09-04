using System;

namespace Animals.Domain
{
    public class Cat : Animal, IMakeSound
    {
        public Cat(Guid id, string name) : base(id, name) { }
        public string MakeSound() => "Meow!";
    }

    public class Cow : Animal, IMakeSound
    {
        public Cow(Guid id, string name) : base(id, name) { }
        public string MakeSound() => "Moo!";
    }

    public class Dog : Animal, IMakeSound, ICanSwim
    {
        public Dog(Guid id, string name) : base(id, name) { }
        public string MakeSound() => "Bark!";
        public void Swim() => Console.WriteLine($"{Name} is swimming.");
    }

    public class Sheep : Animal, IMakeSound
    {
        public Sheep(Guid id, string name) : base(id, name) { }
        public string MakeSound() => "Baa!";
    }
}