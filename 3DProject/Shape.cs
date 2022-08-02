using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.Math;
using System.Drawing;

namespace _3DProject
{
    class Point3D        
    {
        public double x, y, z, size;
        protected Color color;

        public Point3D(double _x, double _y, double _z, double _size = 7)
        {
            x = _x;
            y = _y;
            z = _z;
            size = _size;
            color = Color.LightBlue;
        }

        public bool IsMe(double _x, double _y)
        {
            if (Sqrt(_x * _x + _y * _y) < size)
            {
                if (color == Color.LightBlue)
                    color = Color.Red;
                else
                    color = Color.LightBlue;

                return true;
                
            }
            else
                return false;
        }

        public void Draw(Graphics gr, Pen pen)
        {
            Brush brush = new SolidBrush(color);
            gr.FillEllipse(brush, (float)(x - size / 2.0), (float)(y - size / 2.0), (float)size, (float)size);
            gr.DrawEllipse(pen, (float)(x - size / 2.0), (float)(y - size / 2.0), (float)size, (float)size);
        }
    }

    class Shape : ShapeInterface
    {
        public List<Point3D> points;
        public List<(int,int)> couples;
        protected List<Point3D> projectedPoints;
        
        public Shape()
        {
            points = new List<Point3D>();
            couples = new List<(int,int)>();
            projectedPoints = new List<Point3D>();
        }

        public Shape(List<Point3D> _points, List<(int,int)> _couples)
        {
            points = _points;
            couples = _couples;
        }

        public virtual void AddLine((int, int) couple)
        {
            if (couple.Item1 <= points.Count && couple.Item2 <= points.Count)
                couples.Add(couple);
            else
                throw new IndexOutOfRangeException();
        }

        public virtual void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public virtual void Offset(double dx, double dy, double dz)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i].x += dx;
                points[i].y += dy;
                points[i].z += dz;
            }
        }

        public virtual void Rotate(string axis, double speed)
        {
            double x, y, z; 

            switch (axis)
            {
                case "X":
                    {
                        foreach (Point3D point in points)
                        {
                            y = point.y;
                            z = point.z;
                            point.y = y * Cos(speed) + z * Sin(speed);
                            point.z = -y * Sin(speed) + z * Cos(speed);
                        }
                        break;
                    }
                case "Y":
                    {
                        foreach (Point3D point in points)
                        {
                            x = point.x;
                            z = point.z;
                            point.x = x * Cos(speed) + z * Sin(speed);
                            point.z = -x * Sin(speed) + z * Cos(speed);
                        }
                        break;
                    }
            }          
        }

        public void Scale(double k)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i].x *= k;
                points[i].y *= k;
                points[i].z *= k;
            }
        }

        protected void AxisOffset(Point3D point, Vector2 offset)
        {
            point.x += offset.X;
            point.y += offset.Y;
        }

        protected Point3D ProjectPoint(Point3D point, Point3D interPoint, Plane plane)
        {
            double t0 = -(plane.Normal.X * point.x + plane.Normal.Y * point.y + plane.Normal.Z * point.z) /
                (plane.Normal.X * (interPoint.x - point.x) + plane.Normal.Y * (interPoint.y - point.y) + plane.Normal.Z * (interPoint.z - point.z));
            return new Point3D(
                t0 * (-point.x + interPoint.x) + point.x,
                t0 * (-point.y + interPoint.y) + point.y,
                t0 * (-point.z + interPoint.z) + point.z
                );
        }

        protected virtual void ProjectPoints(Point3D interPoint, Plane plane, Vector2 offset = default)
        {
            foreach (Point3D point in points)
            {
                Point3D projectedPoint = ProjectPoint(point, interPoint, plane);

                projectedPoints.Add(projectedPoint);

                AxisOffset(projectedPoint, offset);
            }
        }

        protected virtual void DrawLines(Graphics gr, Pen pen)
        {
            foreach ((int, int) couple in couples)
            {
                gr.DrawLine(pen, (float)projectedPoints[couple.Item1 - 1].x, (float)projectedPoints[couple.Item1 - 1].y, (float)projectedPoints[couple.Item2 - 1].x, (float)projectedPoints[couple.Item2 - 1].y);
            }
        }

        public virtual void Draw(Graphics gr, Pen pen, Point3D interPoint, Plane plane, Vector2 offset = default)
        {
            projectedPoints.Clear();

            ProjectPoints(interPoint, plane, offset);

            DrawLines(gr, pen);
        }

        public virtual int WhatPointClicked(int x, int y)
        {
            for (int i = 0; i < projectedPoints.Count; i++)
            {
                if (projectedPoints[i].IsMe(x, y))
                    return i;
            }

            return -1;
        }
    }
}
