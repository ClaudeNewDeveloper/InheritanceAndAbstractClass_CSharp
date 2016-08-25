using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandabstractclass
{
    public abstract class Shape
    {
        protected double area;
        protected double perimeter;

        public Shape()
        {
            area = 0.0;
            perimeter = 0.0;

        }

        public  abstract void calcArea();

        public  abstract void calcPerimeter();

        public  double getPerimeter()
        {
            return perimeter;
        }

        public double getArea()
        {
            return area;
        }
       

    }
}
