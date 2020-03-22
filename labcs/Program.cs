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
            int n;
            Console.WriteLine("Enter the number of triangles");
            n = Convert.ToInt32(Console.ReadLine());

            Triangle[] triangle = new Triangle[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("NUMBER: " + (i + 1));
                triangle[i] = new Triangle();
                triangle[i].PrintPoints();
                triangle[i].SideLength();
                triangle[i].Exists();
                triangle[i].GetAngles();

                Console.WriteLine("Perimeter = " + triangle[i].GetPerimeter());
                Console.WriteLine("Suare = " + triangle[i].GetSquare());
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("Equal triangles: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    bool isEqual = true;
                    for (int k = 0; k < 3; k++)
                    {
                        if (triangle[i].side[k] != triangle[j].side[k])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        Console.WriteLine($"{i + 1} {j + 1}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
