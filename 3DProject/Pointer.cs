using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.Math;
using System.Drawing;
using System.Windows.Forms;

namespace _3DProject
{
    class Pointer : Shape
    {
        public Pointer(double size = 1)
        {
            points.Add(new Point3D(0, 0, 0));
            points.Add(new Point3D(size, 0, 0));
            points.Add(new Point3D(0, -size, 0));
            points.Add(new Point3D(0, 0, size));

            couples.Add((1, 2));
            couples.Add((1, 3));
            couples.Add((1, 4));
        }

        protected override void DrawLines(Graphics gr, Pen pen)
        {
            gr.DrawLine(new Pen(Color.Red), (float)projectedPoints[couples[0].Item1 - 1].x, (float)projectedPoints[couples[0].Item1 - 1].y, (float)projectedPoints[couples[0].Item2 - 1].x, (float)projectedPoints[couples[0].Item2 - 1].y);
            gr.DrawLine(new Pen(Color.Blue), (float)projectedPoints[couples[1].Item1 - 1].x, (float)projectedPoints[couples[1].Item1 - 1].y, (float)projectedPoints[couples[1].Item2 - 1].x, (float)projectedPoints[couples[1].Item2 - 1].y);
            gr.DrawLine(new Pen(Color.Green), (float)projectedPoints[couples[2].Item1 - 1].x, (float)projectedPoints[couples[2].Item1 - 1].y, (float)projectedPoints[couples[2].Item2 - 1].x, (float)projectedPoints[couples[2].Item2 - 1].y);
        }

        //public override void Rotate(string axis, double speed){  }
    }
}
