using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proy_Final_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Console.WriteLine("X: " + x.ToString() + " Y: " + y.ToString());
        }

        private void bnQuitar_Click(object sender, EventArgs e)
        {
            Cuadro.Visible = false;
        }

        private void bnPoner_Click(object sender, EventArgs e)
        {
            Cuadro.Visible = true;
        }

        //Codigo Del Dibujo
        Pen LapizA = new Pen(Color.Black, 2);
        Graphics Dibujo; //Objeto Graphics
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Dibujo = e.Graphics; //Para poder dibujar
            //Lado Izquierdo, Esquina Inferior
            Point A = new Point(99,718);
            Point B = new Point(94,306);
            Dibujo.DrawLine(LapizA, A, B);
        }

    }
}


