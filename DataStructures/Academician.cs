using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Academician
    {
        public int RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }

        public Academician()
        {
        }
        public Academician(int registrationNumber = 0, string firstName = null, string lastName = null, bool gender = false)
        {
            
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }


        public override string ToString()
        {
            return $"{RegistrationNumber,-5} {FirstName,-10} {LastName,-10}" +
                   string.Format("{0,-8}",Gender == true ? "Erkek" : "Kadın");
        }


        public static void Print(List<Academician> list)
        {
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
