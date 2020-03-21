using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labcs
{
    class Triangles
    {
        Triangle[] triangles;
        internal Triangle[] Triangle_ { get => triangles; set => triangles = value; }

        public Triangles()
        { }



        public Triangles(int N)
        {
            Triangle_ = new Triangle[N];
            Random r = new Random();

            for (int i = 0; i < Triangle_.Length; ++i)
            {
                Triangle_[i] = new Triangle();
            }
        }

        public void printTriangles()
        {
            for (int i = 0; i < triangles.Length; ++i)
            {
                Console.WriteLine("T"+ Triangle.getSide());

            }
        }
        public int findWithdMaxSquare()
        {
            int min = 0;

            if (Triangle_.Length > 0)
            {
                for (int i = 1; i < Triangle_.Length; i++)
                {
                    if (Triangle_[min].getSquare() < Triangle_[i].getSquare())
                        min = i;
                }
            }
            return min;
        }

        public void printAllWithSquare(double square)
        {

            for (int i = 0; i < triangles.Length; i++)
            {
                if (triangles[i].getSquare() == square)
                {
                    triangles[i].printTriangles();
                    Console.WriteLine($", [{i + 1}]");
                }
            }
            /*
            foreach (Quadrant quadrant in Quadrants_)
            {
                if (quadrant.getSquare() == square)
                    quadrant.printQuadrant();
            }
            */
        }

    }
} 
