using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Employee e1 = new Manager("Ravi", 1, "CEO", 10000);
            Employee e2 = new GeneralManager("Rushi", 2, "Tech Manager", "Manager", 8000);
            Employee e3 = new CEO("Udit", 5, 5000);
            Console.WriteLine(e3.CalacNetSalary());
            Console.WriteLine(e2.CalacNetSalary());

            Console.WriteLine(e1.CalacNetSalary());

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private String name;
        public String Name
        {
            set 
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }

            get 
            {
                return name;
            }
        }

        private static int LastEmpNo = 0;

        private int empNo;
        public int EmpNo
        {
            get 
            {
                return empNo;
            }

            private set
            {
                empNo = value;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid DeptNo");
            }

            get
            {
                return deptNo;
            }
        }

        public Employee(String Name = "noname", short DeptNo = 1, decimal Basic = 10000)
        {
            empNo = ++LastEmpNo;
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
        }

        private decimal basic;
        public abstract decimal Basic
        {
            set;
            get;
        }

        public abstract decimal CalacNetSalary();
    }

    public class Manager : Employee
    {
        private String designation;
        public String Designation
        {
            set
            {
                if (value != null)
                    designation = value;
                else
                    Console.WriteLine("Invalid Designation");
            }

            get
            {
                return designation ;
            }
        }

        private decimal basic;
        public override decimal Basic
        {
            set { basic = value; }

            get { return basic; }
        }

        public override decimal CalacNetSalary()
        {
            return basic;
        }

        public Manager(String Name, short DeptNo, String Designation = "Manager", decimal Basic = 10000) : base(Name,DeptNo,Basic)
        {
            this.Designation = Designation;
            this.Basic = Basic;
        }
    }

    public class GeneralManager : Manager
    {
        private String perks;
        public String Perks
        {
            set { perks = value; }

            get { return perks; }
        }

        private decimal basic;
        public override decimal Basic
        {
            set { basic = value; }

            get { return basic; }
        }

        public GeneralManager(String Name = "noname", short DeptNo = 10, String Designation = "GM", String Perks = "none", decimal Basic = 10000) : base(Name, DeptNo, Designation, Basic)
        {
            this.Designation = Designation;
            this.Basic = Basic;
            this.Perks = Perks;
        }

        public override decimal CalacNetSalary()
        {
            return basic;
        }
    }

    public class CEO : Employee
    {
        private decimal basic;
        public override decimal Basic
        {
            set { basic = value; }

            get { return basic; }
        }

        public sealed override decimal CalacNetSalary()
        {
            return basic;
        }

        public CEO(String Name, short DeptNo, decimal Basic, String Designation = "CEO") : base(Name, DeptNo, Basic)
        {
            this.Basic = Basic;
        }
    }

}