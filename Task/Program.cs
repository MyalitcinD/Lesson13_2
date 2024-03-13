using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("улица пушкина дом колотушкина", 15, 25, 10);
            Console.WriteLine(building.Print());
            MultiBuilding multibuilding = new MultiBuilding("Кронверский проспект", 25, 45, 15, 5);
            Console.WriteLine();
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }
    }
}
