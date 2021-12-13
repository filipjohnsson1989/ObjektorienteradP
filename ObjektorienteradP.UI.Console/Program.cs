// See https://aka.ms/new-console-template for more information
using ObjektorienteradP.BL;
using ObjektorienteradP.Common.Types;
using ObjektorienteradP.DL;
//using ObjektorienteradP.DL;


Console.WriteLine("Objektorienterad programmering!");

#region Inkapsling1
// Kommer du direktåt variablerna?
// Avkomentera också konstruktoren!!!
//Person filip = new() { Age = 32, FName = "Filip", LName = "Johnsson" };

// Man kammer inte åt de variabelen som privata fält.
//person.age = 2; // Compiler Error: 'Person.age' is inaccessible due to its protection level

// Man kammer bara direkt åt publika properties.
//filip.Height = 172.5;
//Console.WriteLine(filip.Height); // Output: 172.5

//try
//{
//    //filip.Age = 0;
//    //person.FName = string.Empty;
//    //person.LName = "";
//}
//catch (ArgumentException ex) when (ex.ParamName == "Ålder")
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(filip.ToString());
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
#endregion 


try
{
    #region Inkapsling2
    // abstraherat med två lager
    PersonHandler personHandler = new();
    //personHandler.SetAge(filip, 32);
    //Console.WriteLine(filip.ToString());
    #endregion 

    #region Inkapsling3
    var filippa = personHandler.CreatePerson(age: 35, fName: "filippa", lName: "johnsson", height: 164.5, weight: 64.5);
    Console.WriteLine(filippa.ToString());
    #endregion 

    #region Inkapsling5
    personHandler.SetAge(filippa, 34);
    personHandler.SetFName(filippa, "Filippa");
    personHandler.SetLName(filippa, "Johnsson");
    personHandler.SetHeight(filippa, 164);
    personHandler.SetWeight(filippa, 64);
    Console.WriteLine(filippa.ToString());

    personHandler.SetPerson(filippa, age: 33, fName: "Ms Filippa", lName: null, height: 165, weight: null);
    Console.WriteLine(filippa.ToString());
    #endregion 

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


#region Arg
// 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, ivilken klass bör vi lägga det?
// Det nya attributet bör lägga i den Bird klassen.
// Titta på ToDo listen eller den Bird Klassen!


// 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// Det nya attributet bör lägga i den Animal klassen.
// Titta på ToDo listen eller den Animal Klassen!
#endregion


List<Animal> animals = new();

Bird bired1 = new(name: "Fågel1", age: 1, weight: 11, wingSpan: 1.1);
animals.Add(bired1);

Flamingo flamingo1 = new(name: "Flamingo1", age: 2, weight: 22, wingSpan: 1.2, flamingosUniqueProperty: 1);
animals.Add(flamingo1);

Swan swan1 = new(name: "Svan1", age: 3, weight: 33, wingSpan: 1.3, swansUniqueProperty: 2);
animals.Add(swan1);

Pelican pelikan1 = new(name: "Pelikan1", age: 4, weight: 44, wingSpan: 1.4, pelicansUniquePeroperty: 3);
animals.Add(pelikan1);


Dog dog1 = new(name: "Hund1", age: 5, weight: 55, registrationNr: "FDIS");
animals.Add(dog1);

Hedgehog hedgehog1 = new(name: "Hedgehog1", age: 6, weight: 66, NrOfSpikes: 666);
animals.Add(hedgehog1);

Horse hors1 = new(name: "Häst1", age: 7, weight: 77, horseshoe: Horseshoe.Steel);
animals.Add(hors1);

Wolf wolf1 = new(name: "Varg1", age: 8, weight: 88, isAlpha: false);
animals.Add(wolf1);

WolfMan wolfMan1 = new(name: "Vargman1", age: 9, weight: 99, isAlpha: true);
animals.Add(wolfMan1);

Worm worm1 = new(name: "Mask1", age: 10, weight: 100, isPoisonous: true);
animals.Add(worm1);

foreach (var animal in animals)
    Console.WriteLine(animal.Stats());

Console.ReadLine();
