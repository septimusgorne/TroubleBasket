using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot_SET
{
    class Complex_Number
    {
        public double a;//real
        public double b;//imaginary

        public Complex_Number(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        //Complex_Number SQUARE
        public void Square()
        {
            double temp = (a * a) - (b * b);
            b = 2.0 * a * b;//imaginary
            a = temp;//real
        }

        //Complex_Number MOD
        public double Magnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        //Complex_Number_SUM
        public void Add(Complex_Number c)
        {
            a += c.a;
            b += c.b;
        }


    }
}
