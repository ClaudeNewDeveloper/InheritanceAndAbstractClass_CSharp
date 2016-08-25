using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandabstractclass
{
    class Rectangle : Shape
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            setLength(length);
            setWidth(width);
        }

       public override void calcArea()
        {
            base.area = length * width;
        }

         public override void calcPerimeter()
        {
            base.perimeter = 2 * (this.length + this.width);
        }

        protected void setLength(double length)
        {
            this.length = length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }
    
    }

}
