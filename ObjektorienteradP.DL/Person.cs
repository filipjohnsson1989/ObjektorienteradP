using System.Diagnostics.CodeAnalysis;

namespace ObjektorienteradP.DL;

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

    private int height;
    public int Height
    {
        get => height;
        set => height = value;
    }

    private int weight;
    public int Weight
    {
        get => weight;
        set => weight = value;
    }

    public Person(uint age, string fName, string lName)
    {
        Age = age;
        FName = fName;
        LName = lName;
    }

    public override string ToString()
    {
        return $"{this.Name} är {Age} år gammal, {height}cm lång och {weight} kilo";
    }
}
