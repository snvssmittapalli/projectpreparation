using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class standard
    {
        protected string rules= "please follow iso standards";

       
    }
    class annauni:standard
    {
        internal int universityno = 123;
        internal int totalnoofseats = 500;

       internal void Getdetails()
        {
            Console.WriteLine("university numbers is {0}, total no of seats {1},rules are {2}", universityno, totalnoofseats, rules);
        }


    }
    class mumbaiuni:standard
    {
        internal int unino = 999;
        internal int totalseats = 450;
        internal void Getd()
        {
            Console.WriteLine("university numbers is {0}, total no of seats {1},rules are {2}", unino, totalseats, rules);
        }
    }
    
    class Inheritancepract
    {
        static void Main()
        {
            mumbaiuni mumbai = new mumbaiuni();
            annauni anna = new annauni();
            mumbai.totalseats = 110;
            anna.totalnoofseats = 300;
            Console.Read();
        }
    }
}
