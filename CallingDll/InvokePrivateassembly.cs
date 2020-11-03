using System;
using EmployeeSalary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingDll
{
    class InvokePrivateassembly
    {
static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.Addition(5, 6);
            Console.WriteLine();
        }
    }
}
