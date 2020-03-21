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
    class Triangle
    {
        point[] points;
        public double[] side = new double[3];
        public double[] angle = new double[3];
        Random r = new Random();
        public void coordinates()
        {
            this.points = new point[3];
            for (int i = 0; i < points.Length; ++i)
            {
                points[i].x = r.Next(5);
                points[i].y = r.Next(5);
            }
        }
        public Tuple <double, double, double> getSide()
        {
            for (int i = 0; i < side.Length; ++i)
            {
                if (i == side.Length - 1) side[i] = Math.Sqrt(Math.Pow(points[i].x - points[0].x, 2) + Math.Pow(points[i].y - points[0].y, 2));
                else side[i] = Math.Sqrt(Math.Pow(points[i + 1].x - points[i].x, 2) + Math.Pow(points[i + 1].y - points[i].y, 2));
            }
            return Tuple.Create(side[0], side[1], side[2]);

        }
        public void exist()
        {
            if ((side[0] + side[1]) > side[2])
                if ((side[0] + side[2]) > side[1])
                    if ((side[2] + side[1]) > side[0]) Console.WriteLine("exist");
                    else Console.WriteLine("doesn't exist");
        }
        public double getPerimeter()
        {
            return side[0] + side[1] + side[2];
        }
        public double getSquare()
        {
            double p = getPerimeter() / 2;
            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
        }
        public Tuple<double, double, double> angles()
        {
            angle[0] = Math.Acos(Math.Pow(side[1], 2) + Math.Pow(side[2], 2) - Math.Pow(side[0], 2) / 2 * side[1] * side[2]);
            angle[1] = Math.Acos(Math.Pow(side[0], 2) + Math.Pow(side[2], 2) - Math.Pow(side[1], 2) / 2 * side[0] * side[2]);
            angle[2] = 180 - (angle[0] + angle[1]);
            return Tuple.Create(angle[0], angle[1], angle[2]);
        }
    }
}
