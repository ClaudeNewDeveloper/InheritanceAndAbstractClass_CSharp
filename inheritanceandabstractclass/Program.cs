using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandabstractclass
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the radius of a circle [1 to 10]: ");
      
            Int32 userInputRadiusOfCircle = Convert.ToInt32(Console.ReadLine());
       
            Console.Write("Enter the length of a rectangle [1 to 10]: ");
            int userInputLengthOfRectangle  = Convert.ToInt32(Console.ReadLine());
       
            Console.Write("Enter the width of a rectangle [1 to 10]: ");
            int userInputWidthOfRectangle = Convert.ToInt32(Console.ReadLine());

            double radius = 2 * userInputRadiusOfCircle;

            Circle circle = new Circle(radius);
       
            Rectangle rectangle = new Rectangle(userInputLengthOfRectangle,userInputWidthOfRectangle );

            Console.WriteLine();
       
       
            Console.WriteLine("Circle:");
            circle.calcArea();      
            circle.calcPerimeter();

            Console.WriteLine("Area:  {0:F3}", circle.getArea());
            Console.WriteLine("Perimeter:  {0:F3}", circle.getPerimeter());

            Console.WriteLine();
       
            Console.WriteLine("Rectangle:");
            rectangle.calcArea();
            rectangle.calcPerimeter();
            
            Console.WriteLine("Area:  {0:F3}", rectangle.getArea());
            Console.WriteLine("Perimeter:  {0:F3}", rectangle.getPerimeter());

            Console.ReadKey();
        }
    }
}
