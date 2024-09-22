using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    public class Point2D<T>
    {
        public T x { get; set; }
        public T y { get; set; }

        public Point2D(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D()
        {
            x = default(T);
            y = default(T);
        }
    }

    public class Point3D<T> : Point2D<T>
    {
        public T z { get; set; }

        public Point3D(T x, T y, T z) : base(x, y)
        {
            this.z = z;
        }

        public Point3D() : base()
        {
            z = default(T);
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
