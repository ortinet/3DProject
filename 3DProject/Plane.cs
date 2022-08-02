using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class Plane3D
    {
        public double A, B, C, D;
        
        public Plane3D(double _A, double _B, double _C, double _D)
        {
            A = _A;
            B = _B;
            C = _C;
            D = _D;
        }

        public void Rotate(char Axis, double speed)
        {
            switch (Axis)
            {
                case 'X':
                    {
                        B += speed * 0.05;
                        break;
                    }
                case 'Y':
                    {
                        A += speed * 0.05;
                        break;
                    }
            }
        }
    }
}
