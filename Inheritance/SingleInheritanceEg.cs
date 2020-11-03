using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Organization    //parent class or base  class
    {
        protected string orgname = "LTI";
        protected string location;


        protected void DispalyOrg()
        {
            Console.WriteLine("orgname is {0}||location {1}", orgname, location);
        }
    }

    //inheritance
    class Employee : Organization //employee child or derived class
    {
        int Eid = 1001;
        float Salaryperhour = 3200.7f;

        protected void DisplayEmployee()
        {
            Console.WriteLine("eid {0}|| salary {1}||orgname {2}", Eid, Salaryperhour, orgname);

        }
    
        static void Main()
        {
            Employee employee = new Employee();
            employee.location = "chennai";
            employee.DispalyOrg();
            employee.DisplayEmployee();
           
            Console.Read();

        }
    }

    class SingleInheritanceEg
    {

    }
}
