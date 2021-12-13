// See https://aka.ms/new-console-template for more information
using ObjektorienteradP.Common;
using ObjektorienteradP.Common.Types;
using ObjektorienteradP.DL;
using ObjektorienteradP.BL;


Console.WriteLine("Objektorienterad programmering!\n\r");

#region 1-Inkapsling
Console.WriteLine(new String('-', 20).AddString("\n\r1-Inkapsling\n\r"));

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
#endregion

#region 2-Arv
Console.WriteLine(new String('-', 20).AddString("\n\r2-Arv\n\r"));

// 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, ivilken klass bör vi lägga det?
// Det nya attributet bör lägga i den Bird klassen.
// Titta på ToDo listen eller den Bird Klassen!


// 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// Det nya attributet bör lägga i den Animal klassen.
// Titta på ToDo listen eller den Animal Klassen!

Console.WriteLine("Ej Skrivning ut");
#endregion

#region 3-Polymorfism
Console.WriteLine(new String('-', 20).AddString("\n\r3-Polymorfism\n\r"));
#region Polymorfism1-7
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
{
    Console.WriteLine(animal.GetType().Name);
    animal.DoSound();

    if (animal is WolfMan wolfMan) wolfMan.Talk();

}
#endregion

#region Polymorfism8-10
List<Dog> dogs = new();

Dog dog2 = new(name: "Hund2", age: 52, weight: 552, registrationNr: "SDIS");
dogs.Add(dog2);

Dog dog3 = new(name: "Hund3", age: 53, weight: 553, registrationNr: "TDIS");
dogs.Add(dog3);

Dog dog4 = new(name: "Hund4", age: 54, weight: 554, registrationNr: "FODIS");
dogs.Add(dog4);

// 9.F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
// Nej, det fungerar det inte. Eftersom de två klasser inte är samma typ.
// Horse klassen måste har ett arv från Dog klassen att lägga till listen annars får det inte.
// dogs.Add(hors1);

// F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
// Listen måste vara en typ av Animal Klassen för att alla klasser skall kunna lagras tillsammans.
List<Animal> animalList = new();
animalList.AddRange(dogs);
animalList.Add(hors1);

#endregion

#region Polymorfism11-18
Console.WriteLine("djurs stats\n\r");
// 11.Skriv ut samtligaAnimalsStats()genom en foreachloop.
foreach (var animal in animals) Console.WriteLine(animal.Stats());

// 12.Testa och se så det fungerar.
// Vi användar fördelar av Polymorfism.

Console.WriteLine("hunds stats\n\r");
// 14.Skriv utStats()metoden enbart för alla hundar genomen foreach på Animals.
foreach (var animal in animals)
{
    if (animal is Dog dog) Console.WriteLine(dog.Stats());

    // 15.Skapa en ny metod med valfritt namn  i klassen Dog som endast returnerar en valfri sträng.
    // Den nya metoden heter PlayString som finns i klassen Dog

    // 16.Kommer du åt den metoden frånAnimalslistan?
    // Nej, det gör jag inte.
    // Console.WriteLine(animal.PlayString());

    // 17.F: Varför inte?
    // Den nya metoden är egna method av klassen Dog.
    // Det finns inte signuture eller impelement of den metoden i klassen Animal.
    // Den metoden bör vara en metod som abstract eller virtual och sedan man kan ovrrida den metoden i klassen Dog.
    // Om vi vill, har vi access till normala methoder i animal men vi kan inte override den i derived klasser som klassen Dag.

    // 18.Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.
    // Jag kör med en ny virtual metod i klassen animal.
    // Den nya metoden är inte obligatorisk att impelementera till andra derived klasser av klassen Animal.
    // Jag overrida metoden i klassen Dog.
    // Nu har vi access till metoden
    Console.WriteLine(animal.PlayString());
}
#endregion

#endregion

#region 4-Polymorfism
Console.WriteLine(new String('-', 20).AddString("\n\r4-Polymorfism\n\r"));

List<UserError> errors = new();
errors.Add(new NumericInputError());
errors.Add(new TextInputError());
errors.Add(new DecimalInputError());

foreach (var error in errors) Console.WriteLine(error.UEMessage());

#endregion

Console.ReadLine();
