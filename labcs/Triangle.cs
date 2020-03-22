using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labcs
{
    public struct point
    {
        public int x;
        public int y;
    };
    public class Triangle
    {
        
        point[] points;
        public double[] side;
        public double[] angle = new double[3];
        Random r = new Random();
        public Triangle()
        {
            points = new point[3];
            for (int i = 0; i < points.Length; ++i)
            {
                points[i].x = r.Next(0, 5);
                points[i].y = r.Next(0, 5);
            }
        }

        public void PrintPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x}\t Y = {points[i].y}");

            }
        }
        public void SideLength()
        {
            side = new double[3];
            for (int i = 0; i < 3; i++)
            {
                side[i] = Math.Sqrt(Math.Pow(points[(i + 1) % 3].x - points[i].x, 2) + Math.Pow(points[(i + 1) % 3].y - points[i].y, 2));
                Console.WriteLine((i + 1) + " side length = " + side[i]);
            }
        }

        public void Exists()
        {
            if ((side[0] + side[1]) > side[2])
            {
                if ((side[0] + side[2]) > side[1])
                {
                    if ((side[2] + side[1]) > side[0]) Console.WriteLine("exist");
                }
            }
            else Console.WriteLine("doesn't exist");
        }
        public double GetPerimeter()
        {
            return side[0] + side[1] + side[2];
        }
        public double GetSquare()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
        }

        public void GetAngles()
        {
            angle[0] = Math.Cos((Math.Pow(side[0], 2) + Math.Pow(side[2], 2) - Math.Pow(side[1], 2)) / (2 * side[0] * side[2])) * 180 / Math.PI;
            angle[1] = Math.Cos((Math.Pow(side[0], 2) + Math.Pow(side[1], 2) - Math.Pow(side[2], 2)) / (2 * side[0] * side[1])) * 180 / Math.PI;
            angle[2] = 180 - angle[0] - angle[1];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(angle[i]);
            }
        }
    }
}
