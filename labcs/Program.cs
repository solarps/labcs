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
            int n,m;
            Console.WriteLine("Enter the number of triangles");
            n = Convert.ToInt32(Console.ReadLine());
            Triangle[] triangle = new Triangle[n];
            int seed = 0;
            for (int i = 0; i < n; i++)
            {
                do
                {
                    triangle[i] = new Triangle(seed++);
                    triangle[i].SideLength();
                    triangle[i].GetAngles();
                } while (!triangle[i].IsExists());
                Console.WriteLine("NUMBER: " + (i + 1));
                triangle[i].PrintInfo();
            }
            Console.WriteLine("Equal triangles: ");
            int q = 0;
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
                        q++;
                        Console.WriteLine($"{i + 1} {j + 1}");
                    }
                }
            }
            if(q==0) Console.WriteLine("No equal triangles");


            Console.WriteLine("Enter the number of equilateral triangles");
            m = Convert.ToInt32(Console.ReadLine());
            Equilateral[] equilaterals = new Equilateral[m];

            for (int i = 0; i < m; i++)
            {
                do
                {
                    equilaterals[i] = new Equilateral(seed++);
                    equilaterals[i].eq();
                    equilaterals[i].SideLength();
                } while (!equilaterals[i].IsEqualSide() || !equilaterals[i].IsExists());
                Console.WriteLine("NUMBER: " + (i + 1));
                Console.WriteLine("Median = " + equilaterals[i].GetMed());
                equilaterals[i].PrintInfo();
            }
            if (m != 0)
            {
                double min = 1000000000;
                int l = 0;
                Console.WriteLine("Smaller median triangle: ");
                for (int i = 0; i < m; i++)
                {
                    if (equilaterals[i].GetMed() < min)
                    {
                        min = equilaterals[i].GetMed();
                        l = i;
                    }
                }
                Console.WriteLine("NUMBER: " + (l + 1));
                Console.WriteLine("Median = " + equilaterals[l].GetMed());
                equilaterals[l].PrintInfo();
            }
            Console.ReadLine();
        }
    }
}
