using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public struct Dots
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        //This is Default Constructor but Default Constructor doesn't at struct. default constructor convert to constructor when described parameter 
        //public Dots( )
        //{
            
        //}

        public Dots(int x, int y)
        {
            X = x ;
            Y = y ;
        }

        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }

        public void Excahnge()
        {
            var ms = X;
            X = Y;
            Y = ms;
        }
    }
}
