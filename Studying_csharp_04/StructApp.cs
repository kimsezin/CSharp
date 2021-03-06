﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
    class StructApp
    {
        public static void Main()
        {
            Point[] pts = new Point[3];
            pts[0] = new Point(100, 100);
            pts[1] = new Point(100, 200);
            pts[2] = new Point(200, 100);
            foreach (Point pt in pts)
            {
                Console.WriteLine(pt.ToString());
            }
        }
    }
}
