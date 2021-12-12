namespace ObjektorienteradP.DL;

public class Bird : Animal
{
    public double WingSpan { get; }
    // F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, ivilken klass bör vi lägga det?
    // ToDo: Det nya attributet till samtliga fåglar bör lägga i den här klassen.
    //public double NewBirdProperty { get; }

    //public Bird(string name, uint age, double weight, double wingSpan, double newBirdProperty) : base(name, age, weight)
    public Bird(string name, uint age, double weight, double wingSpan) : base(name, age, weight)
    {
        this.WingSpan = wingSpan;
        //this.NewBirdProperty = newBirdProperty;
    }

    public override void DoSound()
    {
        Console.WriteLine("Fågels låten");
    }
}
