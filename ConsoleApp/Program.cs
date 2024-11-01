using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int num_1=int.Parse(Console.ReadLine());
            int num_2=int.Parse(Console.ReadLine());
            int sum=num_1+num_2;
            Console.WriteLine(sum);

            Console.Write("side=");
            int side=Convert.ToInt32(Console.ReadLine());
            int perimetr = 4 * side;
            Console.WriteLine($"perimetr={perimetr}");

            Console.Write("R=");
            int radius=int.Parse(Console.ReadLine());
            double area=Math.PI*Math.Pow(radius, 2);
            Console.WriteLine($"S={area:f2}");
            Console.ReadLine();
        }
    }
}
