using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortmuyeshlik
{
    class tortmuyesh
    {

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public bool Check()
        {
            return ((A + B + C) > D && (A + C + D) > B && (A + B + D) > C && (B + C + D) > A);
        }
        public double tuwritortmuyeshlik()
        {

            double l = Math.Sqrt(Math.Pow(D,2) - Math.Pow(B,2));
            return l * B; 
        }
        public double parallelogram()
        {
         
        }

        public int Kvadrat()
        {
            return A + B + C + D;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
