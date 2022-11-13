using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Москва", 50, 0, 30);
            Console.WriteLine(building.Print());

            MultiBuilding mulibuilding = new MultiBuilding("Сочи", 700, 36, 50, 12);
            Console.WriteLine(mulibuilding.Print());

            Console.ReadKey();
        }
    }
}
