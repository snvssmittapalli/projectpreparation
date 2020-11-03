using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assignment
{
    abstract class Student
    {
        string name = "swaroop";
            int Studentid = 1001;
        internal float Grade=75.3f;
        public abstract bool Ispassed();
    }
    class Undergraduate:Student
    {
        public override bool Ispassed()
        {
            if (Grade > 70)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    class Graduate : Student
    {
        public override bool Ispassed()
        {
            if (Grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
    class StudentDetails
    {
        static void Main()
        {
          
            
            Undergraduate undergraduate = new Undergraduate();
           Console.WriteLine("grade for undergraduate is{0}", undergraduate.Ispassed());

            Graduate graduate = new Graduate();
            Console.WriteLine("grade for graduate is{0}",graduate.Ispassed());
            Console.Read();
        }
    }
}
