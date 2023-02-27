using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Array.CreateInstance(typeof(int), 5);
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                numbers.SetValue(rnd.Next(1,11), i);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("numbers[{0}] = {1}",i,numbers.GetValue(i));

            }
        }
    }
}
