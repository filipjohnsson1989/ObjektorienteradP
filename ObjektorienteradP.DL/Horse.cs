using ObjektorienteradP.Common.Types;

namespace ObjektorienteradP.DL;

public class Horse : Animal
{
    public Horseshoe Horseshoe { get; }
    public Horse(string name, uint age, double weight, Horseshoe horseshoe) : base(name, age, weight)
    {
        this.Horseshoe = horseshoe;
    }

    public override void DoSound()
    {
        Console.WriteLine("Hästs låten");
    }

    public override string Stats() => $"{base.Stats()} Horseshoe:{Horseshoe}";

}
