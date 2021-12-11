namespace ObjektorienteradP.DL;

//Inkapsling1
public class Person
{
    private uint age;
    public uint Age
    {
        get => this.age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Ålder kan bara tilldelas ett värde större än 0", "Ålder");

            this.age = value;
        }
    }

    private string? fName;
    public string? FName
    {
        get => this.fName;
        set
        {
            if (value is null || value.Length < 2 || value.Length > 10)
                throw new ArgumentException("Förnamn kan bara vara mellan 2 och 10 tecken");

            this.fName = value;
        }
    }

    private string? lName;
    public string? LName
    {
        get => this.lName;
        set
        {
            if (value is null || value.Length < 3 || value.Length > 15)
                throw new ArgumentException("Efternamn kan bara vara mellan 3 och 15 tecken");

            this.lName = value;
        }
    }

    public string Name { get => $"{FName} {lName}"; }

    private double height;
    public double Height
    {
        get => height;
        set => height = value;
    }

    private double weight;
    public double Weight
    {
        get => weight;
        set => weight = value;
    }

    public Person()
    {

    }

    public Person(uint age, string fName, string lName, double height, double weight)
    {
        Age = age;
        FName = fName;
        LName = lName;
        Height = height;
        Weight = weight;
    }

    public override string ToString() =>
        $"{this.Name} är {Age} år gammal, {height.ToString("0.0")}cm lång och {weight.ToString("0.0")} kilo";

}
