using ObjektorienteradP.Common;

namespace ObjektorienteradP.DL;

public abstract class Animal
{
    public string Name { get; }
    public uint Age { get; }
    public double Weight { get; }
    // F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    // ToDo: Det nya attributet om alla djur bör lägga i den här klassen.
    //public double NewAnimalProperty { get; }

    //public Animal(string name, uint age, double weight, double newAnimalProperty)
    public Animal(string name, uint age, double weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight = weight;
        //this.NewAnimalProperty = newAnimalProperty;
    }
    public abstract void DoSound();

    public virtual string Stats() => $"Name:{Name} Age:{Age} Weight:{Weight}";
}
