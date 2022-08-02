using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using static System.Math;

namespace _3DProject
{
    partial class Form1 : Form
    {
        protected Point oldMousePosition;
        protected Vector2 axisOffset;
        protected Plane projectionPlane;
        protected Point3D interPoint;
        protected Shape shape;
        protected Graphics graph;
        protected Bitmap bitmap;
        protected Pen pen;
        protected Brush brush;    
              
        public Form1()
        {
            InitializeComponent();

            axisOffset.X = this.Size.Width / 2 - 20;
            axisOffset.Y = this.Size.Height / 2 - 60;

            projectionPlane = new Plane(0, 0, 1, - 800); 

            interPoint = new Point3D(0,0,-projectionPlane.D);

            bitmap = new Bitmap(this.Size.Width, this.Size.Height);
            graph = Graphics.FromImage(bitmap);          
            brush = new SolidBrush(Color.Blue);
            pen = new Pen(brush);
           
            this.MouseWheel += new MouseEventHandler(this_MouseWheel);

            shape = new DottedShape(100);
        }

        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                shape.Scale(1.2);
            else
                shape.Scale(0.8);

            DrawShape();
        }

        private void пирамидуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = new Pyramid(50);
            DrawShape();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            oldMousePosition = e.Location;
        }

        protected virtual Vector2 CalcDelta(MouseEventArgs e)
        {
            return new Vector2(e.Location.X - oldMousePosition.X, e.Location.Y - oldMousePosition.Y);
        }

        protected virtual void Rotate(Vector2 delta)
        {
            shape.Rotate("Y", 0.007 * delta.X);
            shape.Rotate("X", 0.007 * delta.Y);
        }

        protected virtual void Offset(Vector2 delta)
        {
            shape.Offset(delta.X, delta.Y, 0);
        }

        protected virtual void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Vector2 delta = CalcDelta(e);

            if (e.Button == MouseButtons.Left)
            {
                Rotate(delta);                       
            }
            if (e.Button == MouseButtons.Right)
            {
                Offset(delta);
            }

            DrawShape();
            oldMousePosition = e.Location;
        }

        private void кубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = new Cube(100);
            DrawShape();
        }

        private void OtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = new Dodecahedron(100);
            DrawShape();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.Show();

            //shape = new Shape();
            //DrawShape();
        }

        protected void UpdateImage()
        {
            pictureBox1.Image = bitmap;
        }

        protected virtual void DrawShape()
        {
            graph.Clear(Color.Transparent);
            shape.Draw(graph, pen, interPoint, projectionPlane, axisOffset);
            UpdateImage();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void восстановитьПлоскостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Size.Width;
            pictureBox1.Height = this.Size.Height;

            bitmap = new Bitmap(bitmap, new Size(this.Size.Width, this.Size.Height));
            graph = Graphics.FromImage(bitmap);

            axisOffset.X = this.Size.Width / 2 - 20;
            axisOffset.Y = this.Size.Height / 2 - 60;

            DrawShape();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            DrawShape();
        }

        protected virtual void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
