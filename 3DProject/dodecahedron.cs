using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class Dodecahedron : Shape
    {
        public Dodecahedron(double size)
        {
            points.Add(new Point3D(0.809*size, 0.5*size, 0.588*size));
            points.Add(new Point3D(0.309*size, -0.5*size, 0.951*size));
            points.Add(new Point3D(-0.309*size, 0.5*size, 0.951*size));
            points.Add(new Point3D(-0.809*size, -0.5*size, 0.588*size));
            points.Add(new Point3D(-size, 0.5*size, 0));
            points.Add(new Point3D(-0.809*size, -0.5*size, -0.588*size));
            points.Add(new Point3D(-0.309*size, 0.5*size, -0.951*size));
            points.Add(new Point3D(0.309*size, -0.5*size, -0.951*size));
            points.Add(new Point3D(0.809*size, 0.5*size, -0.588*size));
            points.Add(new Point3D(size, -0.5*size, 0));
            points.Add(new Point3D(0, 1.118*size, 0));
            points.Add(new Point3D(0, -1.118*size, 0));

            couples.Add((1, 11));
            couples.Add((1, 3));
            couples.Add((3, 11));
            couples.Add((3, 5));
            couples.Add((5, 11));
            couples.Add((7, 11));
            couples.Add((7, 5));
            couples.Add((7, 9));
            couples.Add((9, 11));
            couples.Add((1, 2));
            couples.Add((2, 3));
            couples.Add((3, 4));
            couples.Add((2, 4));
            couples.Add((4, 5));
            couples.Add((4, 6));
            couples.Add((5, 6));
            couples.Add((5, 7));
            couples.Add((6, 7));
            couples.Add((7, 8));
            couples.Add((6, 8));
            couples.Add((8, 9));
            couples.Add((8, 10));
            couples.Add((9, 10));
            couples.Add((1, 10));
            couples.Add((2, 10));
            couples.Add((2, 12));
            couples.Add((6, 12));
            couples.Add((8, 12));
            couples.Add((10, 12));
            couples.Add((4, 12));
            couples.Add((1, 9));
        }
    }
}
