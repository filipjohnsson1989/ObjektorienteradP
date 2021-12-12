namespace ObjektorienteradP.DL;

public class Flamingo : Bird
{
    public double FlamingosUniqueProperty { get; }
    public Flamingo(string name, uint age, double weight, double wingSpan, int flamingosUniqueProperty) : base(name, age, weight, wingSpan)
    {
        this.FlamingosUniqueProperty = flamingosUniqueProperty;
    }

    public override void DoSound()
    {
        Console.WriteLine("Felamingos låten");
    }
}
