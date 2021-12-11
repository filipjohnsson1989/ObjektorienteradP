using ObjektorienteradP.DL;

namespace ObjektorienteradP.BL;

public class PersonHandler
{
    #region Inkapsling2
    public void SetAge(Person person, uint age) => person.Age = age;
    #endregion Inkapsling2

    #region Inkapsling3
    public Person CreatePerson(uint age, string fName, string lName, double height, double weight) =>
        new Person(age: age, fName: fName, lName: lName, height: height, weight: weight);
    #endregion Inkapsling3

    #region Inkapsling4
    public void SetFName(Person person, string fName) => person.FName = fName;

    public void SetLName(Person person, string lName) => person.LName = lName;

    public void SetHeight(Person person, double height) => person.Height = height;

    public void SetWeight(Person person, double weight) => person.Weight = weight;
    #endregion Inkapsling4
}
