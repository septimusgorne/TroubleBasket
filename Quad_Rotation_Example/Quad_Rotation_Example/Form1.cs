namespace Quad_Rotation_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //создаем отображение PictureBox
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int x1 = 0, y1 = 0;
        int alfa = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            alfa++;
            //каждый раз когда выполняется таймер мы инкрементим
            //угол альфа
            int a90 = alfa + 90;
            int a180 = alfa + 180;
            int a270 = alfa + 270;

            int rad1 = 150;
            int rad2 = 300;

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            //получаем график
            int rad = 250;
            SolidBrush b = new SolidBrush(Color.White);
            g.FillRectangle(b, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Pen pens = new Pen(Color.Crimson);


            //Quad-Qube realisation Up-Down-----------------------------------------------------------
            int x0 = (int)(rad1 * Math.Sin(alfa * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y0 = (int)(rad2 * Math.Cos(alfa * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            int x1 = (int)(rad1 * Math.Sin(a90 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y1 = (int)(rad2 * Math.Cos(a90 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            int x2 = (int)(rad1 * Math.Sin(a180 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y2 = (int)(rad2 * Math.Cos(a180 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            int x3 = (int)(rad1 * Math.Sin(a270 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y3 = (int)(rad2 * Math.Cos(a270 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            //Quad-Qube realisation Left-Rigth-----------------------------------------------------------
            int x00 = (int)(rad1 * Math.Cos(alfa * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y00 = (int)(rad2 * Math.Sin(alfa * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            int x11 = (int)(rad1 * Math.Cos(a90 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y11 = (int)(rad2 * Math.Sin(a90 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;

            int x22 = (int)(rad1 * Math.Cos(a180 * 2 * Math.PI / 360)) + pictureBox1.Width / 2;
            int y22 = (int)(rad2 * Math.Sin(a180 * 2 * Math.PI / 360)) + pictureBox1.Height / 2;


            //Drawing-Qube--------------------------------------------------------------------
            g.DrawLine(pens, x0 - 150, y0, x1 - 150, y1);
            g.DrawLine(pens, x1 - 150, y1, x2 - 150, y2);
            g.DrawLine(pens, x2 - 150, y2, x3 - 150, y3);
            g.DrawLine(pens, x3 - 150, y3, x0 - 150, y0);

            g.DrawLine(pens, x0 + 150, y0, x1 + 150, y1);
            g.DrawLine(pens, x1 + 150, y1, x2 + 150, y2);
            g.DrawLine(pens, x2 + 150, y2, x3 + 150, y3);
            g.DrawLine(pens, x3 + 150, y3, x0 + 150, y0);

            g.DrawLine(pens, x0 - 150, y0, x0 + 150, y0);
            g.DrawLine(pens, x1 - 150, y1, x1 + 150, y1);
            g.DrawLine(pens, x2 - 150, y2, x2 + 150, y2);
            g.DrawLine(pens, x3 - 150, y3, x3 + 150, y3);

            //Drawing-Triangle------------------------------------------------------------------
            //
            g.DrawLine(pens, x00 - 150, y00, x11 - 150, y11);
            g.DrawLine(pens, x11 - 150, y11, x22 - 150, y22);
            g.DrawLine(pens, x22 - 150, y22, x00 - 150, y00);

            g.DrawLine(pens, x00 + 150, y00, x11 + 150, y11);
            g.DrawLine(pens, x11 + 150, y11, x22 + 150, y22);
            g.DrawLine(pens, x22 + 150, y22, x00 + 150, y00);

            g.DrawLine(pens, x00 - 150, y00, x00 + 150, y00);
            g.DrawLine(pens, x11 - 150, y11, x11 + 150, y11);
            g.DrawLine(pens, x22 - 150, y22, x22 + 150, y22);





            pictureBox1.Invalidate();

        }
    }
}