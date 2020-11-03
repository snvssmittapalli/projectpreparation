using System;
using EmployeeSalary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingDll
{
    class Employee
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.Addition(5, 6);
            Console.WriteLine("addition is {0}", calculator.Addition(5, 6));
            Console.Read();
        }
    }
}
