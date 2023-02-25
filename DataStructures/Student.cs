namespace DataStructures;

public struct Student
{
    //Struct - Constructor
    public Student(int number, string firstName, string lastName, string gender="Erkek")
    {
        Number = number;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
    }

    public int Number { get; set; } //Property
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }

    //Override
    public override string ToString()
    {
        return $"{Number} {FirstName} {LastName} {Gender}";
    }
}