namespace Animals.Domain
{
    public interface IMakeSound
    {
        string MakeSound();
    }

    public interface ICanSwim
    {
        void Swim();
    }

    public interface ICanFly
    {
        void Fly();
    }
}