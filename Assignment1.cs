using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Ravi",98765,5);
            Employee emp2 = new Employee("Ravi", 12345);
            Employee emp3 = new Employee("Ravi");
            Employee emp4 = new Employee();

            Console.WriteLine("1 =" + emp1.Empno);
            Console.WriteLine("2 =" + emp2.Empno);
            Console.WriteLine("3 =" + emp3.Empno);
            Console.WriteLine("4 =" + emp4.Empno);
            Console.WriteLine("4 =" + emp4.Deptno);
            Console.WriteLine("4 =" + emp4.Basic);


            Console.WriteLine(emp4.Empno);
            Console.WriteLine(emp3.Empno);
            Console.WriteLine(emp2.Empno);
            Console.WriteLine(emp1.Empno);
            Console.ReadLine();
        }
    }

    public class Employee
    {

        private string name;
        public string Name
        {
            set
            {
                if (value !=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be Empty");
                    return ;
                }
            }
            get
            {
                return name;
            }
        }
        private int empno;

        public int Empno
        {
            set
            {
                empno = value;

            }
            get
            {
                return empno;
            }
        }

        private decimal basic;

        public decimal Basic
        {
            set
            {
                if(value>10000 && value < 100000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Inavlid basic");
                    return;
                }
            }
            get
            {
                return basic;
            }
        }
        private short deptno;
        public short Deptno
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("DeptNo must be greater than zero");
                    return;
                }
            }
            get
            {
                return deptno;
            }
        }

        public static int count=0;
      
        public Employee(string name = null, decimal basic = 0 , short deptno=0)
        {
            count++;
            Name = name;
            Basic = basic;
            Deptno = deptno;
            Empno = Employee.count;
        }
        
        public decimal GetNetSalary()
        {
            decimal Salary;
            Salary = basic * 10;
            return Salary;
        }
    }
}