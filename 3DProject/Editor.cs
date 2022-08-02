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
    partial class Editor : Form1
    {
        Shape pointer;        

        public Editor()
        {
            InitializeComponent();
            pointer = new Pointer(30);
            shape = new Shape();
        }

        protected override void DrawShape()
        {
            graph.Clear(Color.Transparent);
            shape.Draw(graph, pen, interPoint, projectionPlane, axisOffset);
            
            pointer.Draw(graph, pen, interPoint, projectionPlane, axisOffset);
            UpdateImage();
        }


        private void Editor_Load(object sender, EventArgs e)
        {
            //DrawShape();
        }

        protected override void Rotate(Vector2 delta)
        {
            base.Rotate(delta);
            pointer.Rotate("Y", 0.007 * delta.X);
            pointer.Rotate("X", 0.007 * delta.Y);

            DrawShape();
        }

        protected override void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.pictureBox1_MouseMove(sender, e);
        }

        protected override void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shape.WhatPointClicked(e.X, e.Y);
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
