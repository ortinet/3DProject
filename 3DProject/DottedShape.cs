using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class DottedShape : Cube
    {
        public DottedShape(int size) : base(size) { }


        protected void DrawPoints(Graphics gr, Pen pen)
        {
            foreach (Point3D point in projectedPoints)
            {
                point.Draw(gr, pen);
            }
        }

        public override void Draw(Graphics gr, Pen pen, Point3D interPoint, Plane plane, Vector2 offset = default)
        {
            base.Draw(gr, pen, interPoint, plane, offset);

            DrawPoints(gr, pen);
        }

        
    }
}
