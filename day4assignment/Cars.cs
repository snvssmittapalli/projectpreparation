using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assignment
{
    interface ICar
    {
        string Break();
        string Engine();
    }
    class Benz : ICar
    {
        public string Break()
        {
            return "hydraulic braek";
        }
        public string Engine()
        {
            return "four stroke";
        }
        internal void BenzFunctionality()
        {
            Console.WriteLine("it supports good LED lightning system ");
        }
    }
    class Toyota : ICar
    {
        public string Break()
        {
            return "disc break";
        }
        public string Engine()
        {
            return "two stroke";
        }
        internal void ToyotaFunctionality()
        {
            Console.WriteLine("it have good seat adjustment system ");
        }
    }
    class Cars
    {
        static void Main()
        {
            Benz benz = new Benz();
            Console.WriteLine(" benz type of break {0}", benz.Break());
            Console.WriteLine("benz engine type is {0}", benz.Engine());
            benz.BenzFunctionality();

            Toyota toyota = new Toyota();
            Console.WriteLine("toyota type of break {0}", toyota.Break());
            Console.WriteLine("toyota engine type is {0}", toyota.Engine());
            toyota.ToyotaFunctionality();
            Console.Read();
        }
    }
}
