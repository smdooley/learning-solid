namespace Animal.Domain

public class Cat : Animal, IMakeSound
{
    public Cat(string name) : base(name) { }
    public string MakeSound() => "Meow!";
}

public class Dog : Animal, IMakeSound, ICanSwim
{
    public Dog(string name) : base(name) { }
    public string MakeSound() => "Bark!";
    public void Swim() => Console.WriteLine($"{Name} is swimming.");
}

public class Shark : Animal, ICanSwim
{
    public Shark(string name) : base(name) { }
    public void Swim() => Console.WriteLine($"{Name} is swimming.");
}