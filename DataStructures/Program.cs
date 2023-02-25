using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Academician> List1 = new List<Academician>()
            {
                new Academician(10,"Ali","Biner",true),
                new Academician(11,"Mert","Gündoğan",true),
                new Academician(12,"Ayşe","Biner"),
                new Academician(13,"Şeyma","Esen")
            };

            List<Academician> List2 = List1;

            Academician.Print(List1);
            Console.WriteLine("---------");
            Academician.Print(List2);
            Console.WriteLine("---------");

            List2.Add(new Academician(14,"Derviş","Doğan",true));
            List2.RemoveAt(0);

            Console.ReadKey();

            Academician.Print(List1);
            Console.WriteLine("---------");
            Academician.Print(List2);
            Console.WriteLine("---------");

            Console.ReadKey();



        }

        //public static void Main(string[] args)
        //{
        //    Dots dt = new Dots(3,4);
        //    Console.WriteLine(dt);
        //    dt.Excahnge();
        //    Console.WriteLine(dt);

        //    Console.ReadKey();
        //}


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
