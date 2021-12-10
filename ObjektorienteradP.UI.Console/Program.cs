// See https://aka.ms/new-console-template for more information
using ObjektorienteradP.DL;

Console.WriteLine("Objektorienterad programmering!");

#region Inkapsling 1.1
// Kommer du direktåt variablerna?
Person person = new(age: 32, fName: "Filip", lName: "Johnsson");

// Man kammer inte åt de variabelen som privata fält.
//person.age = 2; // Compiler Error: 'Person.age' is inaccessible due to its protection level

// Man kammer bara direkt åt publika properties.
person.Height = 172.5;
Console.WriteLine(person.Height); // Output: 172.5

try
{
    person.Age = 0;
    //person.FName = string.Empty;
    //person.LName = "";

}
catch (ArgumentException ex) when (ex.ParamName == "Ålder")
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(person.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

#endregion Inkapsling1

Console.ReadLine();
