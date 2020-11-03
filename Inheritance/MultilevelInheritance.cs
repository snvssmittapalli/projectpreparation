using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class College
    {
        protected string CollegeName = "MIT";

    }
    class Department : College
    {
        protected string Deptname = "CSE";

        protected void GetDept()
        {
            Console.WriteLine("collegename :{0},deptname:{1}", CollegeName, Deptname);
        }
    }
    class StudentDetails:Department
    {
        string stuname = "mani";
        void DisplayStuinfo()
        {
            Console.WriteLine("collegename :{0},deptname:{1},studentname {2}", CollegeName, Deptname, stuname);
        }
        static void Main()
        {
            StudentDetails student = new StudentDetails();
            student.DisplayStuinfo();
            student.GetDept();
           
          
            Console.Read();
            

        }
        

    }
    class MultilevelInheritance
    {
    }
}
