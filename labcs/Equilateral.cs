using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labcs
{
    public class Equilateral : Triangle
    {
        //point[] points; 
        Random r = new Random();
        public Equilateral(int a) : base(a) { }
        public void eq()
        {
            for (int x1 = 1; x1 < 10; x1++)
            {
                points[0].x = x1;
                for (int y1 = 1; y1 < 10; y1++)
                {
                    points[0].y = y1;
                    for (int x2 = 1; x2 < 10; x2++)
                    {
                        points[1].x = x2;
                        for (int y2 = 1; y2 < 10; y2++)
                        {
                            points[1].y = y2;
                            for (int x3 = 1; x3 < 10; x3++)
                            {
                                points[2].x = x3;
                                for (int y3 = 1; y3 < 10; y3++)
                                {
                                    points[2].y = y3;
                                    SideLength();
                                    if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]) && (side[0] != 0)) break;
                                }
                                if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]) && (side[0] != 0)) break;
                            }
                            if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]) && (side[0] != 0)) break;
                        }
                        if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]) && (side[0] != 0)) break;
                    }
                    if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]) && (side[0] != 0)) break;
                }
                if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]) && (side[0] != 0)) break;
            }
        }
        public bool IsEqualSide()
        {
            bool result = false;
            //side[0] = 1;
            //side[1] = 1;
            //side[2] = 1;
            //for (int i = 0; i < 3; i += 2)

            //do
            //{
            //    points[0].x = r.Next(-10, 10);
            //    points[0].y = r.Next(-10, 10);
            //    SideLength();
            //    //side[(i+1)%3] = Math.Sqrt(Math.Pow(points[(i + 2) % 3].x - points[(i+1)].x, 2) + Math.Pow(points[(i + 2) % 3].y - points[i+1].y, 2));
            //} while (side[0] != side[1]);

            if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]))
            {
                result = true;
            }
            return result;
            //for (int i = 0; i < 11; i++)
            //{
            //    for (int j = 0; j < 11; j++)
            //    {
            //        points[2].x = i;
            //        points[2].y = j;
            //        SideLength();
            //        if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2])) break;
            //        points[2].x = j;
            //        points[2].y = i;
            //        SideLength();
            //        if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2])) break;
            //    }
            //    if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2])) break;
            //}
            //if ((side[0] == side[1]) && (side[0] == side[2]) && (side[1] == side[2]))
            //{
            //    result = true;
            //}
            //return result;
        }
        public double GetMed()
        {
            return side[0] * Math.Sqrt(3) / 2;
        }
    }
}