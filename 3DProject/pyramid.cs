using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class Pyramid : Shape
    {
        public Pyramid(double size)
        {
            points.Add(new Point3D(0,size,0));
            points.Add(new Point3D(size,-size,size));
            points.Add(new Point3D(-size,-size,size));
            points.Add(new Point3D(-size,-size,-size));
            points.Add(new Point3D(size,-size,-size));

            couples.Add((1, 2));
            couples.Add((1, 3));
            couples.Add((1, 4));
            couples.Add((1, 5));
            couples.Add((3, 2));
            couples.Add((5, 2));
            couples.Add((4, 3));
            couples.Add((5, 4));
        }
    }
}
