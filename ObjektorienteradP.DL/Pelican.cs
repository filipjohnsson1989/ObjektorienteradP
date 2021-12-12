namespace ObjektorienteradP.DL;

public class Pelican : Bird
{
    public double PelicansUniquePeroperty { get; }
    public Pelican(string name, uint age, double weight, double wingSpan, int pelicansUniquePeroperty) : base(name, age, weight, wingSpan)
    {
        this.PelicansUniquePeroperty = pelicansUniquePeroperty;
    }

    public override void DoSound()
    {
        Console.WriteLine("Pelikans låten");
    }
}
