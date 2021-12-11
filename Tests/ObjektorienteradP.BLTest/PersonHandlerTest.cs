using Xunit;
using ObjektorienteradP.BL;
using System;

namespace ObjektorienteradP.BLTest;

public class PersonHandlerTest
{
    [Fact]
    public void SetAge_InValid0_ShouldError()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        var expected = "Ålder kan bara tilldelas ett värde större än 0 (Parameter 'Ålder')";
        // Act & Assert
        uint invalidAge = 0;
        var ex = Assert.Throws<ArgumentException>(() => personHandler.SetAge(person, invalidAge));
        var actual = ex.Message;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetAge_Valid()
    {
        // Arrange
        PersonHandler personHandler = new();
        var person = personHandler.CreatePerson(age: 32, fName: "Filip", lName: "Johnsson", height: 172.5, weight: 96.5);

        uint expected = 33;

        // Act
        personHandler.SetAge(person, expected);
        var actual = person.Age;

        // Assert
        Assert.Equal(expected, actual);
    }
}
