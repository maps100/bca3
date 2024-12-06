using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A7_op_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first real and imaginary number:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second real and imaginary number:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Complex c1 = new Complex(a, b);
            Complex c2 = new Complex(c, d);

            Complex c3 = c1 + c2;
            c3.Display();

            Complex c4 = c1 * c2;
            c4.Display();

            Console.ReadKey();
        }
    }

    public class Complex
    {
        int real;
        int img;

        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.real = c1.real + c2.real;
            c3.img = c1.img + c2.img;
            return c3;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.real = c1.real * c2.real - c1.img * c2.img;
            c3.img = c1.real * c2.img + c1.img * c2.real;
            return c3;
        }

        public void Display()
        {
            Console.WriteLine(real + "+i" + img);
        }
    }
}
