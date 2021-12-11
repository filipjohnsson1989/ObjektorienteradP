using ObjektorienteradP.DL;

namespace ObjektorienteradP.BL;

public class PersonHandler
{
    #region Inkapsling2
    public void SetAge(Person person, uint age) => person.Age = age;
    #endregion 

    #region Inkapsling3
    public Person CreatePerson(uint age, string fName, string lName, double height, double weight) =>
        new Person(age: age, fName: fName, lName: lName, height: height, weight: weight);
    #endregion 

    #region Inkapsling4
    public void SetFName(Person person, string fName) => person.FName = fName;

    public void SetLName(Person person, string lName) => person.LName = lName;

    public void SetHeight(Person person, double height) => person.Height = height;

    public void SetWeight(Person person, double weight) => person.Weight = weight;

    /// <summary>
    /// It edits info of desire person.
    /// </summary>
    /// <param name="person">Object of the desire person</param>
    /// <param name="age">Set desire age otherwise leave it null to have current data.</param>
    /// <param name="fName">Set desire first name otherwise leave it null to have current data.</param>
    /// <param name="lName">Set desire last name otherwise leave it null to have current data.</param>
    /// <param name="height">Set desire height otherwise leave it null to have current data.</param>
    /// <param name="weight">Set desire weight otherwise leave it null to have current data.</param>
    public void SetPerson(Person person, uint? age, string? fName, string? lName, double? height, double? weight)
    {
        if(age.HasValue) SetAge(person, age.Value);
        if(fName is not null) SetFName(person, fName);
        if(lName is not null) SetLName(person, lName);
        if(height.HasValue) SetHeight(person, height.Value);
        if(weight.HasValue) SetWeight(person, weight.Value);
    }
    #endregion 
}
