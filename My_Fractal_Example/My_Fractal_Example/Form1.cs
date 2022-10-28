namespace My_Fractal_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw(int x, int y, int length,double angle, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            double x1, y1, x2, y2;

            x1 = x + length * Math.Sin(angle * Math.PI * 2/ 360.0);
            y1 = y + length * Math.Cos(angle * Math.PI * 2/ 360.0);

            x2 = x1 + length * Math.Sin((angle + 90) * Math.PI * 2 / 360.0);
            y2 = y1 + length * Math.Cos((angle + 90) * Math.PI * 2 / 360.0);



            g.DrawLine(new Pen(Color.Black), x, panel1.Height - y, (int) x1, panel1.Height - (int)y1);
            //g.DrawLine(new Pen(Color.Black), (int)x1, panel1.Height - (int)y1, (int)x2, panel1.Height - (int)y2);
            /*if (length > 10)
            {
                Draw((int)x1, (int)y1, length /2 , angle + 45, e);
                Draw((int)x1, (int)y1, length /2 , angle - 45, e);
            }*/



            if (length > 7)
            {
                Draw((int)x1, (int)y1, length / 2, 90, e);
                Draw((int)x1, (int)y1, length / 2, -90, e);
                Draw((int)x1, (int)y1, length / 2, 45, e);
                Draw((int)x1, (int)y1, length / 2, -45, e);

                // Draw((int)x2, (int)y2, length / 2, 90, e);


                //Draw((int)x2, (int)y2, length / 2, -90, e);
            }
        }

        public void DrawTriangle(Graphics gr, int level,
    PointF top_point, PointF left_point, PointF right_point)
        {
            // Посмотрим, остановимся ли мы.
            if (level == 0)
            {
                // Заполните треугольник.
                PointF[] points =
                {
            top_point, right_point, left_point
        };
                gr.FillPolygon(Brushes.Red, points);
            }
            else
            {
                // Найти граничные точки.
                PointF left_mid = new PointF(
                    (top_point.X + left_point.X) / 2f,
                    (top_point.Y + left_point.Y) / 2f);
                PointF right_mid = new PointF(
                    (top_point.X + right_point.X) / 2f,
                    (top_point.Y + right_point.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (left_point.X + right_point.X) / 2f,
                    (left_point.Y + right_point.Y) / 2f);

                // Рекурсивно рисуем меньшие треугольники.
                DrawTriangle(gr, level - 1,
                    top_point, left_mid, right_mid);
                DrawTriangle(gr, level - 1,
                    left_mid, left_point, bottom_mid);
                DrawTriangle(gr, level - 1,
                    right_mid, bottom_mid, right_point);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Draw(panel1.Width/2, 0 , 300, 0, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //break;
            Console.Clear();

        }
    }
}