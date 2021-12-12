using System;
using System.Collections.Generic;
using System.Linq;
namespace ObjektorienteradP.DL;

public class Worm : Animal
{
    public bool IsPoisonous { get; }
    public Worm(string name, uint age, double weight, bool isPoisonous) : base(name, age, weight)
    {
        this.IsPoisonous = isPoisonous;
    }

    public override void DoSound()
    {
        Console.WriteLine("Masks låten");
    }
}
