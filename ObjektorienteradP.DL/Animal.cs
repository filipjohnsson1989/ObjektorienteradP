namespace ObjektorienteradP.DL;

public abstract class Animal
{
    public string Name { get; }
    public uint Age { get; }
    public double Weight { get; }

    public Animal(string name, uint age, double weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight = weight;
    }
    public abstract void DoSound();
}
