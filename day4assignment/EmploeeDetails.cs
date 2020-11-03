using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace day4assignment
{
    class Employee
    {
        protected string Empname;
        protected int Empnid;
        internal float Salaryperhour;
       internal Employee(string Empname, int Empnid, float Salaryperhour)
        {
            this.Empname = Empname;
            this.Empnid = Empnid;
            this.Salaryperhour = Salaryperhour;

        }
    }
        class ParttimeEmployee : Employee
    {
        protected float Hoursofworking;
       internal  ParttimeEmployee(string Empname, int Empnid, float Salaryperhour, float Hoursofworking):base(Empname, Empnid, Salaryperhour)
        {
            this.Hoursofworking = Hoursofworking;
        }
        
        internal float CalculateSalary()

        {
            return Hoursofworking * Salaryperhour;
        }
        static void Main()
        {
            ParttimeEmployee parttimeemployee = new ParttimeEmployee("swaroop",1001,92.33f,10.2f);
           Console.WriteLine( "Salary is {0}",parttimeemployee.CalculateSalary());
            Console.Read();

        }
    }
        class EmploeeDetails
    {
    }
}
