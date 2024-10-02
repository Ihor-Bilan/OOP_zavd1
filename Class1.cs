using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class TTriangle
    {
        protected double a, b, c;
        public TTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("The side may be positive");
            }; if (!IsExist(a, b, c))
            {
                throw new Exception("TTriangle");

            }
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool IsExist(double a, double b, double c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        public double A
        {
            get { return a; }
            set
            {
                if (IsExist(value, b, c))
                { a = value; }
                else
                {
                    throw new Exception("Bad side");
                }

            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (IsExist(a, value, c))
                { b = value; }
                else
                {
                    throw new Exception("Bad side");
                }

            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (IsExist(a, b, value))
                { c = value; }
                else
                {
                    throw new Exception("Bad side");
                }

            }
        }
        public double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public double Area(double a, double b, double c)
        {
            return Math.Sqrt(((a + b + c)/2) * (((a + b + c)/2) - a) * (((a + b + c)/2) - b ) * (((a + b + c)/2) - c));
        }


    }
}