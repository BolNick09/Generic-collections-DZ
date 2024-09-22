using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    public class Line2D<T>
    {
        public Point2D<T> Point1 { get; set; }
        public Point2D<T> Point2 { get; set; }

        public Line2D(Point2D<T> point1, Point2D<T> point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public Line2D(T x1, T y1, T x2, T y2)
        {
            Point1 = new Point2D<T>(x1, y1);
            Point2 = new Point2D<T>(x2, y2);
        }

        public override string ToString()
        {
            return $"Линия от {Point1} до {Point2}";
        }
    }
}
