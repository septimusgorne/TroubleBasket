using System;
using System.Drawing;

namespace Line_Experimental_ImitationRoads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Point click;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();//create object class
            g.Clear(Color.AliceBlue);
            g.DrawEllipse(Pens.Goldenrod, 100  , 100, 300, 200);
            g.DrawRectangle(Pens.Red, 300, 300, 300, 200);
            g.DrawLine(Pens.Black, 600, 600, 700, 600);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;//e - object click mouse
            g.DrawRectangle(Pens.Black, click.X, click.Y, 300, 300);
        }
    }
}