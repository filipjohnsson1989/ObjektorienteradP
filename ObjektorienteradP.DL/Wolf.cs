namespace ObjektorienteradP.DL;

public class Wolf : Animal
{
    public bool IsAlpha { get; }

    public Wolf(string name, uint age, double weight, bool isAlpha) : base(name, age, weight)
    {
        this.IsAlpha = isAlpha;
    }

    public override void DoSound()
    {
        Console.WriteLine("Vargs låten");
    }

    public override string Stats() => $"{base.Stats()} IsAlpha:{IsAlpha}";

}
