using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class Cube : Shape
    {
        public Cube(double size)
        {
            size /= 2;
            points.Add(new Point3D(size,-size, size));
            points.Add(new Point3D(size, size, size));
            points.Add(new Point3D(-size, size, size));
            points.Add(new Point3D(-size, -size, size));
            points.Add(new Point3D(size, -size, -size));
            points.Add(new Point3D(size, size, -size));
            points.Add(new Point3D(-size, size, -size));
            points.Add(new Point3D(-size, -size, -size));

            couples.Add((1, 5));
            couples.Add((1, 4));
            couples.Add((1, 2));
            couples.Add((8, 4));
            couples.Add((8, 5));
            couples.Add((8, 7));
            couples.Add((6, 5));
            couples.Add((6, 7));
            couples.Add((6, 2));
            couples.Add((3, 4));
            couples.Add((3, 7));
            couples.Add((3, 2));
        }
    }
}
