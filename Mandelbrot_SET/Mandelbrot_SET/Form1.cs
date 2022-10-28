namespace Mandelbrot_SET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    double a = (double)(x - (pictureBox1.Width/2)) / (double)(pictureBox1.Width / 4);
                    double b = (double)(y - (pictureBox1.Height/2)) / (double)(pictureBox1.Height / 4);

                    Complex_Number c = new Complex_Number(a, b);
                    Complex_Number z = new Complex_Number(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        z.Add(c);

                        if (z.Magnitude() > 2)
                            break;
                    }
                    while (it < 100);
                    //bmp.SetPixel(x, y, it < 100 ? Color.FromArgb(it, it, it) : Color.FromArgb(255, 255, 255));
                    //black-white color
                    bmp.SetPixel(x, y, it < 100 ? Color.FromArgb(it % 2 * 128, it % 4 * 33, it % 2 * 66) : Color.FromArgb(it, it, it));// : Color.FromArgb(255, 255, 255);
                }
                pictureBox1.Image = bmp;
                //Show picture
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}