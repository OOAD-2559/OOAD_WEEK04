using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4
{
    class Rectangle
    {
        public static double Area(double Width, double Height)
        {
            
            return Width * Height;
        }

        static int Main()
        {
            double rectArea = Area(10, 20);
            System.Console.WriteLine("rectangle area = " + rectArea.ToString());
            System.Console.ReadKey();
            return 0;
        }
    }
}
