using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Struct - Defining
    public struct Student
    {
        //Struct - Constructor
        public Student(int number, string firstName, string lastName, string gender)
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
    }
    public class Program
    {
        //Struct - Using
        public static void Main(string[] args)
        {
            Student std = new Student();
            std.Number = 10;
            std.FirstName = "Ali";
            std.LastName = "Biner";
            std.Gender = "Erkek";

            Student std2 = new Student()
            {
                Number = 20,
                FirstName = "Zehra",
                LastName = "Kardelen",
                Gender = "Kadın"
            };

            Student std3 = new Student(30,"Mert","Derviş","Erkek");

            Console.WriteLine($"{std.Number} {std.FirstName} {std.LastName} {std.Gender}" );
            Console.WriteLine($"{std2.Number} {std2.FirstName} {std2.LastName} {std2.Gender}" );
            Console.WriteLine($"{std3.Number} {std3.FirstName} {std3.LastName} {std3.Gender}" );
            Console.ReadKey();
        }
    }
}
