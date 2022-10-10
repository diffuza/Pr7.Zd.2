using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("s= ");
            float s = float.Parse(Console.ReadLine());
            double r = Math.Sqrt(s / Math.PI);
            Console.WriteLine("r= Радиус окружности составляет:{0:N4}", r);
        }
    }
}
