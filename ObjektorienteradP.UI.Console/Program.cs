// See https://aka.ms/new-console-template for more information
using ObjektorienteradP.BL;
using ObjektorienteradP.DL;


Console.WriteLine("Objektorienterad programmering!");

#region Inkapsling1
// Kommer du direktåt variablerna?
Person filip = new() { Age = 32, FName = "Filip", LName = "Johnsson" };

// Man kammer inte åt de variabelen som privata fält.
//person.age = 2; // Compiler Error: 'Person.age' is inaccessible due to its protection level

// Man kammer bara direkt åt publika properties.
filip.Height = 172.5;
Console.WriteLine(filip.Height); // Output: 172.5

try
{
    person.Age = 0;
    //person.FName = string.Empty;
    //person.LName = "";
}
catch (ArgumentException ex) when (ex.ParamName == "Ålder")
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(filip.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion Inkapsling1


#region Inkapsling2
// abstraherat med två lager
PersonHandler personHandler = new();
personHandler.SetAge(filip, 32);
Console.WriteLine(filip.ToString());
#endregion Inkapsling2


#region Inkapsling3
var filippa = personHandler.CreatePerson(age : 35, fName : "filippa", lName : "johnsson", height: 164.5, weight: 64.5);
Console.WriteLine(filippa.ToString());
#endregion Inkapsling3

#region Inkapsling5
personHandler.SetAge(filippa, 34);
personHandler.SetFName(filippa, "Filippa");
personHandler.SetLName(filippa, "Johnsson");
personHandler.SetHeight(filippa, 164);
personHandler.SetWeight(filippa, 64);
Console.WriteLine(filippa.ToString());
#endregion Inkapsling5


Console.ReadLine();
