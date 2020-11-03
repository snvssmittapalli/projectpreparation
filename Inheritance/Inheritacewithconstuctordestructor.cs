using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class College
    {
        protected string id = "c101";
        protected string CollegeName;
        internal College(string CollegeName)
        {
            this.CollegeName = CollegeName;
            Console.WriteLine("college constructor");

        }
        ~College()
        {
            Console.WriteLine("college destructor");
        }
    }
    class Department : College
    {
        protected string id = "d1000";
        protected string Deptname;
        internal Department(string cname,string Deptname):base(cname)
        {
            this.Deptname = Deptname;
            Console.WriteLine("department costructor");
        }

        protected void GetDept()
        {
            Console.WriteLine("collegeid {0},deptid : {1}", base.id, id);
            Console.WriteLine("collegename :{0},deptname:{1}", CollegeName, Deptname);
        }
        ~Department()
        {
            Console.WriteLine("department constructor");
        }
    }
    class Student : Department
    {
        string stuname;
        Student(string cname,string dname,string stuname):base(cname,dname)
        {
            this.stuname = stuname;
            Console.WriteLine("student constructor");
        }
        void DisplayStuinfo()
        {
            Console.WriteLine("collegename :{0},deptname:{1},studentname {2}", CollegeName, Deptname, stuname);
        }
        static void Main()
        {
            Student student = new Student("mit","mech","sai");
            student.DisplayStuinfo();
            student.GetDept();
            GC.Collect();

            Console.Read();


       }
        ~Student()
        {
            Console.WriteLine("studnet destructor");
        }


    }
    class Inheritacewithconstuctordestructor
    {
    }
}
