using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.WriteLine(triangle.getSide());
            triangle.exist();
            Console.WriteLine(triangle.getPerimeter());
            Console.WriteLine(triangle.getSquare());

            Triangles triangles = new Triangles(20);
            triangles.printTriangles();

            //int minN = triangles.findWithdMinMed();
            ////            Console.WriteLine($"Quadrant with max square: {maxN+1}");
            ////            quadrants.Quadrants_[maxN].printQuadrant();
            //Console.WriteLine("All min:");
            //triangles.printAllWithSquare(triangles.Triangles_[minN].getSquare());
        }
    }
}
