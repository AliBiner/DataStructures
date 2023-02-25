using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Struct - Defining
    public class Program
    {
        public static void Main(string[] args)
        {
            Dots dt = new Dots(3,4);
            Console.WriteLine(dt);
            dt.Excahnge();
            Console.WriteLine(dt);
            
            Console.ReadKey();
        }


        ////Struct - Using
        //public static void Main(string[] args)
        //{
        //    //Student std = new Student();
        //    //std.Number = 10;
        //    //std.FirstName = "Ali";
        //    //std.LastName = "Biner";
        //    //std.Gender = "Erkek";

        //    //Student std2 = new Student()
        //    //{
        //    //    Number = 20,
        //    //    FirstName = "Zehra",
        //    //    LastName = "Kardelen",
        //    //    Gender = "Kadın"
        //    //};

        //    //Student std3 = new Student(30,"Mert","Derviş","Erkek");

        //    //Method using with non-override
        //    //Console.WriteLine($"{std.Number} {std.FirstName} {std.LastName} {std.Gender}" );
        //    //Console.WriteLine($"{std2.Number} {std2.FirstName} {std2.LastName} {std2.Gender}" );
        //    //Console.WriteLine($"{std3.Number} {std3.FirstName} {std3.LastName} {std3.Gender}" );

        //    //Method using with override
        //    //Console.WriteLine(std);
        //    //Console.WriteLine(std2);
        //    //Console.WriteLine(std3);

        //    List<Student> stdList = new List<Student>()
        //    {
        //        new Student(10,"Ali","Biner"),
        //        new Student(20,"Ayşe","Demir","Kadın"),
        //        new Student(30,"Mert","Derviş","Erkek")
        //    };

        //    foreach (var VARIABLE in stdList)
        //    {
        //        Console.WriteLine(VARIABLE);
        //    }

        //    stdList.ForEach(o=> Console.WriteLine(o));

        //    Console.ReadKey();
        //}
    }
}
