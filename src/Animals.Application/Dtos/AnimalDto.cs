namespace Animals.Application.Dtos
{
    public record AnimalDto(Guid Id, string Name, string Type, bool CanMakeSound, bool CanSwim, bool CanFly, string? Sound);
}