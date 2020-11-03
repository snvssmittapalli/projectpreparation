using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface INormalCalculator
    {
        int Add(int a, int b);
        String CalcName();

    }
    class Computing:INormalCalculator,IscientificCalculator
        
    {
        public int Add( int a, int b)
        {
            return a + b;
        }
        internal string GetName()
        {
            return "computing";
        }
        string INormalCalculator.CalcName()
        {
            return "inormalcalculator";
        }
        string IscientificCalculator.CalcName()
        {
            return "iscienticficcalculator";
        }
    }

    class InterfaceEg
    {
        static void Main()
        {
            Computing computing = new Computing();
            Console.WriteLine("adition is {0}", computing.Add(9, 7));
            Console.WriteLine("class name {0}",computing.GetName());
            IscientificCalculator s = new Computing();
            Console.WriteLine(s.CalcName());
            INormalCalculator r = new Computing();
            Console.WriteLine(r.CalcName());

            Console.Read();
        }
    }
}
