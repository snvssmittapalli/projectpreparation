using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class RBI
    {
        int empno = 20;
        public abstract int Homeloan();
        public abstract int Educationloan();

        internal void RBIemployee()
        {
            Console.WriteLine("details of employees in rbi: {0}", empno);
        }

    }
    class SBI : RBI
    {
        public override int Homeloan()
        {
            return 9;
        }
        public override int Educationloan()
        {
            return 10;
        }
        class HDFC : RBI
        {
            public override int Homeloan()
            {
                return 8;
            }
            public override int Educationloan()
            {
                return 5;
            }

        }
        class AbstractionEg
        {
            static void Main()
            {
                SBI sbi = new SBI();
                sbi.Educationloan();
                sbi.Homeloan();
                Console.WriteLine("sbi houseloan {0}", sbi.Homeloan());
                Console.WriteLine("sbi educationloan {0}", sbi.Educationloan());

                HDFC hdfc = new HDFC();
                Console.WriteLine("hdfc houseloan {0}", hdfc.Homeloan());
                Console.WriteLine("hdfc educationloan {0}", hdfc.Educationloan());
                

                ///run time polymorphism
                RBI r;
                //object for SBI
                r = new SBI();
                r.RBIemployee();
                Console.WriteLine("sbi houseloan {0}", r.Homeloan());
                Console.WriteLine("sbi educationloan {0}", r.Educationloan());
                //object for HDFC
                Console.WriteLine("hdfc houseloan {0}", r.Homeloan());
                Console.WriteLine("hdfc educationloan {0}", r.Educationloan());

                Console.Read();


            }
        }
    }
}
