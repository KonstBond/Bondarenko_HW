using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Figure
    {
        Point p1, p2, p3, p4, p5;

        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4):this(p1, p2, p3)
        {
            this.p4 = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5): this(p1,p2,p3,p4)
        {
            this.p5 = p5;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double rez;
            if (p5 != null)
            {
                rez = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);      
            }
            else if(p4 != null)
            {
                rez = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
            }
            else
            {
                rez = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
            }
            return rez;
        }
    }
}
