using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLength
    {
        public static void cal_len()
        {
            double Leng = 0.0;
            System.Console.WriteLine("Calculating length of two points of x,y Co-ordinates : \n");
            System.Console.WriteLine("Enter x1 value of first point : ");
            double x1=Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter y1 value of first point : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter x2 value of second point : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter y2 value of second point : ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("\nThe length of two points is: ");
            Leng = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            System.Console.WriteLine(Leng);
        }
    }
}
