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
        //Codigo Del Dibujo
        Pen LapizA = new Pen(Color.Red, 2);
        SolidBrush BrochaA = new SolidBrush(Color.Brown);
        Graphics Dibujo; //Objeto Graphics

        private void Cuadro_Paint(object sender, PaintEventArgs e)
        {
            Dibujo = e.Graphics; //Para poder dibujar
            //Lado Izquierdo, Esquina Inferior, Primer rectangulo, lado uno
            Point A = new Point(99, 718);
            Point B = new Point(94, 305);
            Dibujo.DrawLine(LapizA, A, B);
            Point p1 = new Point(204, 312);//Lado Izquierdo, Esquina Inferior, Primer rectangulo, lado dos
            Point p2 = new Point(209, 493);//Mitad de la linea
            Dibujo.DrawLine(LapizA, p1, p2);
            Dibujo.DrawLine(LapizA, p2, new Point(216, 715));//Segunda mitad
            Dibujo.DrawLine(LapizA, new Point(94, 305), new Point(204, 312));//Union de ambos lados
        }

    }
}


