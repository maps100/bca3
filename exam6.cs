using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication2
{
    class Salary
    {
        int empno;
        decimal basic;
        public string dob, empname;

        public Salary(int eno, string name, string db, decimal sal)
        {
            empno = eno;
            basic = sal;
            dob = db;
            empname = name;
        }

        public void calculate()
        {
            decimal da = 0, hra = 0, pf = 0, gross = 0, netpay = 0, pt = 0;
            if (basic <= 20000)
            {
                da = basic * 40 / 100;
                hra = basic * 10 / 100;
                gross = basic + da + hra;
                pf = gross * 12 / 100;
                pt = 100;
                netpay = gross - pt - pf;
            }
            else
            {
                da = basic * 50 / 100;
                hra = basic * 15 / 100;
                gross = basic + da + hra;
                pf = gross * 12 / 100;
                pt = 150;
                netpay = gross - pt - pf;
            }

            Console.WriteLine("Employee NO: " + empno);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Employee DOB: " + dob);
            Console.WriteLine("Basic Salary: " + basic);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("PF: " + pf);
            Console.WriteLine("PT: " + pt);
            Console.WriteLine("Gross Salary: " + gross);
            Console.WriteLine("Net Pay: " + netpay);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int eno;
            decimal sal;
            string dob, ename;

            Console.WriteLine("Emp number:");
            eno = int.Parse(Console.ReadLine());

            Console.WriteLine("Emp name:");
            ename = Console.ReadLine();

            Console.WriteLine("Emp dob:");
            dob = Console.ReadLine();

            Console.WriteLine("Emp salary:");
            sal = decimal.Parse(Console.ReadLine());

            Salary s1 = new Salary(eno, ename, dob, sal);
            s1.calculate();
            Console.ReadKey();
        }
    }
}
