namespace Fractsls_Three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw_Fractal(int x, int y, int length, double angle, PaintEventArgs e)
            //координаты, длина, угол, метод отрисовки
        {
            Graphics g = e.Graphics;
            //рисуем
            double x1, y1;
            x1 = x + length * Math.Sin(angle * Math.PI * 2 / 360);
            y1 = y + length * Math.Cos(angle * Math.PI * 2 / 360);
            //координаты , строим функции

            g.DrawLine(new Pen(Color.Black, length / 15), x, panel1.Height - y, (int)x1, panel1.Height - (int)y1);
            //строим линию
            if (length > 2)//20
                //length px
            {
                Draw_Fractal((int)x1, (int)y1, (int)(length / 1.6), angle + 40, e);
                //вызываем рекурсию пока длинна не будет меньше length px
                Draw_Fractal((int)x1, (int)y1, (int)(length / 1.6) , angle - 40, e);

                Draw_Fractal((int)x1, (int)y1, (int)(length / 1.6), angle + 10, e);
                //вызываем рекурсию пока длинна не будет меньше length px
                Draw_Fractal((int)x1, (int)y1, (int)(length / 1.6), angle - 10, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw_Fractal(panel1.Width / 2, panel1.Height / 2, 70, 0, e);
            //Console.ReadLine();
            Draw_Fractal(panel1.Width / 2, 0, 200, 0, e);

            //Thread.Sleep(40000);
            Console.ReadLine();
        }
    }
}