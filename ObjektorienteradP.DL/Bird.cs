namespace ObjektorienteradP.DL;

public class Bird : Animal
{
    public double WingSpan { get; }

    public Bird(string name, uint age, double weight, double wingSpan) : base(name, age, weight)
    {
        this.WingSpan = wingSpan;
    }

    public override void DoSound()
    {
        Console.WriteLine("Fågels låten");
    }
}
