using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandabstractclass
{
    class Circle : Shape
    {
        public double pi = 3.1416;
        public double length;

        public Circle(double length)
        {
            setLength(length);
        }

        public void setLength(double length)
        {
            this.length = length;
        }

       public override void calcArea()
        {
            base.area = (length / 2) * (length / 2) * pi;
        }

        public override void calcPerimeter()
        {
            base.perimeter = pi * length; ;
        }


    }
}
