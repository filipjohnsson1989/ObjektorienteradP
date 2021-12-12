namespace ObjektorienteradP.DL;

public class WolfMan : Wolf, IPerson
{
    public WolfMan(string name, uint age, double weight, bool isAlpha) : base(name, age, weight, isAlpha)
    {
    }

    public void Talk()
    {
        Console.WriteLine("Jag är vargman");
    }
}
