﻿namespace ObjektorienteradP.DL;

public class Dog : Animal
{
    public string RegistrationNr { get; }
    public Dog(string name, uint age, double weight, string registrationNr) : base(name, age, weight)
    {
        this.RegistrationNr = registrationNr;
    }

    public override void DoSound()
    {
        Console.WriteLine("Hunds låten");
    }
}
