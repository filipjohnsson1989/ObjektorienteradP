namespace ObjektorienteradP.DL;

public class Swan : Bird
{
    public int SwansUniqueProperty { get; }
    public Swan(string name, uint age, double weight, double wingSpan, int swansUniqueProperty) : base(name, age, weight, wingSpan)
    {
        this.SwansUniqueProperty = swansUniqueProperty;
    }

    public override void DoSound()
    {
        Console.WriteLine("Svans låten");
    }
}
