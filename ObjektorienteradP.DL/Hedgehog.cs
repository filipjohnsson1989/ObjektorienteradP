namespace ObjektorienteradP.DL;

public class Hedgehog : Animal
{
    public uint NrOfSpikes { get; }
    public Hedgehog(string name, uint age, double weight, uint NrOfSpikes) : base(name, age, weight)
    {
        this.NrOfSpikes = NrOfSpikes;
    }

    public override void DoSound()
    {
        Console.WriteLine("Igelkotts låten");

    }
}
