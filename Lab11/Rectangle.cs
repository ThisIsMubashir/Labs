using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    //1. Define delegate
    public delegate void RectDelegate (double x, double y);

    class Program
    {
        public void GetArea(double width, double height) 
        {
            Console.WriteLine(width * height);
         }

        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine(2*(width+ height));
        }

        static void Main(string[] args)
        {
            Program rect = new Program();

            //2. Create an instance 
            RectDelegate myrect = new RectDelegate(rect.GetArea);
            myrect += rect.GetPerimeter;


            
            rect.GetArea(11.3, 12.0);
            rect.GetPerimeter(11.3, 12.0);

            Console.WriteLine("I am going to execute a delegate");
            myrect.Invoke(11.3, 12.0);

            Console.ReadLine();

        }
    }
}
