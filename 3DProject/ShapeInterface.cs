using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    interface ShapeInterface
    {
        void Rotate(string axis, double speed);
        void Scale(double k);
        void Offset(double dx, double dy, double dz);
        void AddPoint(Point3D point);
        void AddLine((int,int) couple); 
    }
}
