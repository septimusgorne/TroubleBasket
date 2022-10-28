namespace Recursion_Three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DrawFractal(int x, int y,int length, double angle, PaintEventArgs e)
            //�������� � ��������� ����������, �����, ���� � ������
        {
            Graphics g = e.Graphics;

            double x1, y1;
            //����������, ������� ���������� ������ �� ����� � ����

            x1 = x + length * Math.Sin(angle * Math.PI * 2 / 360.0);
            //� �������� ����������
            y1 = y + length * Math.Cos(angle * Math.PI * 2 / 360.0);

            g.DrawLine(new Pen(Color.Black), x, y,(int) x1, (int)y1);
            //������ �����

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawFractal(panel1.Width / 2, panel1.Height / 2, 0, 20, e);
        }
    }
}