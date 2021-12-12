using Xunit;
using ObjektorienteradP.BL;
using System;
using ObjektorienteradP.DL;

namespace ObjektorienteradP.BLTest;

public class PersonHandlerTest
{
    #region CreatePerson
    [Fact]
    public void CreatePerson_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        const uint expectedAge = 32;
        const string expectedFName = "Filip";
        const string expectedLName = "Johnsson";
        const double expectedHeight = 172.5;
        const double expectedWeight = 96.5;

        // Act
        var person = personHandler.CreatePerson(age: expectedAge,
                                                    fName: expectedFName,
                                                    lName: expectedLName,
                                                    height: expectedHeight,
                                                    weight: expectedWeight);
        uint actualAge = person.Age;
        string? actualFName = person.FName;
        string? actualLname = person.LName;
        double actualHeight = person.Height;
        double actualWeight = person.Weight;

        // Assert
        Assert.Equal(expectedAge, actualAge);
        Assert.Equal(expectedFName, actualFName);
        Assert.Equal(expectedLName, actualLname);
        Assert.Equal(expectedHeight, actualHeight);
        Assert.Equal(expectedWeight, actualWeight);
    }
    #endregion

    #region SetAge
    [Fact]
    public void SetAge_InValid_0_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Ålder kan bara tilldelas ett värde större än 0 (Parameter 'Ålder')";
        uint invalidAge = 0;

        // Act & Assert
        var testCode = () => personHandler.SetAge(person, invalidAge);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetAge_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const uint expected = 33;

        // Act
        personHandler.SetAge(person, expected);
        var actual = person.Age;

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region SetFName
    [Fact]
    public void SetFName_InValid_LessThan2Characters_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Förnamn kan bara vara mellan 2 och 10 tecken";
        string invalidFName = "F";

        // Act & Assert
        var testCode = () => personHandler.SetFName(person, invalidFName);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetFName_InValid_EmptyString_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Förnamn kan bara vara mellan 2 och 10 tecken";
        string invalidFName = string.Empty;

        // Act & Assert
        var testCode = () => personHandler.SetFName(person, invalidFName);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetFName_InValid_Null_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Förnamn kan bara vara mellan 2 och 10 tecken";
        string? invalidFName = null;

        // Act & Assert
        var testCode = () => personHandler.SetFName(person, invalidFName!);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetFName_InValid_MoreThan10Characters_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Förnamn kan bara vara mellan 2 och 10 tecken";
        string invalidFName = "FilipFilipF";

        // Act & Assert
        var testCode = () => personHandler.SetFName(person, invalidFName);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetFName_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Filippa";

        // Act
        personHandler.SetFName(person, expected);
        var actual = person.FName;

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region SetLName
    [Fact]
    public void SetLName_InValid_LessThan3Characters_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Efternamn kan bara vara mellan 3 och 15 tecken";
        string invalidLName = "Jo";

        // Act & Assert
        var testCode = () => personHandler.SetLName(person, invalidLName);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetLName_InValid_EmptyString_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Efternamn kan bara vara mellan 3 och 15 tecken";
        string invalidLName = string.Empty;

        // Act & Assert
        var testCode = () => personHandler.SetLName(person, invalidLName);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetLName_InValid_Null_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Efternamn kan bara vara mellan 3 och 15 tecken";
        string? invalidLName = null;

        // Act & Assert
        var testCode = () => personHandler.SetLName(person, invalidLName!);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetLName_InValid_MoreThan10Characters_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Efternamn kan bara vara mellan 3 och 15 tecken";
        string invalidLName = "JohnssonJohnsson";

        // Act & Assert
        var testCode = () => personHandler.SetLName(person, invalidLName);
        var ex = Assert.Throws<ArgumentException>(testCode);
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetLName_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const string expected = "Nilsson";

        // Act
        personHandler.SetLName(person, expected);
        var actual = person.LName;

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region SetHeight
    [Fact]
    public void SetHeight_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const double expected = 173.5;

        // Act
        personHandler.SetHeight(person, expected);
        var actual = person.Height;

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region SetWeight
    [Fact]
    public void SetWeight_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const double expected = 0.5;

        // Act
        personHandler.SetWeight(person, expected);
        var actual = person.Weight;

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region SetPerson
    [Fact]
    public void SetPerson_Valid_ChangeAll()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        const uint expectedAge = 35;
        const string expectedFName = "Filippa";
        const string expectedLName = "Nilsson";
        const double expectedHeight = 164.5;
        const double expectedWeight = 84.5;

        // Act
        personHandler.SetPerson(person: person,
                                age: expectedAge,
                                fName: expectedFName,
                                lName: expectedLName,
                                height: expectedHeight,
                                weight: expectedWeight);

        uint actualAge = person.Age;
        string? actualFName = person.FName;
        string? actualLname = person.LName;
        double actualHeight = person.Height;
        double actualWeight = person.Weight;

        // Assert
        Assert.Equal(expectedAge, actualAge);
        Assert.Equal(expectedFName, actualFName);
        Assert.Equal(expectedLName, actualLname);
        Assert.Equal(expectedHeight, actualHeight);
        Assert.Equal(expectedWeight, actualWeight);
    }

    [Fact]
    public void SetPerson_Valid_ChangeNothing()
    {
        // Arrange
        PersonHandler personHandler = new();
        const uint expectedAge = 32;
        const string expectedFName = "Filip";
        const string expectedLName = "Johnsson";
        const double expectedHeight = 172.5;
        const double expectedWeight = 96.5;

        var person = personHandler.CreatePerson(age: expectedAge,
                                                    fName: expectedFName,
                                                    lName: expectedLName,
                                                    height: expectedHeight,
                                                    weight: expectedWeight);

        // Act
        personHandler.SetPerson(person: person,
                                age: null,
                                fName: null,
                                lName: null,
                                height: null,
                                weight: null);

        uint actualAge = person.Age;
        string? actualFName = person.FName;
        string? actualLname = person.LName;
        double actualHeight = person.Height;
        double actualWeight = person.Weight;

        // Assert
        Assert.Equal(expectedAge, actualAge);
        Assert.Equal(expectedFName, actualFName);
        Assert.Equal(expectedLName, actualLname);
        Assert.Equal(expectedHeight, actualHeight);
        Assert.Equal(expectedWeight, actualWeight);
    }
    #endregion
}
