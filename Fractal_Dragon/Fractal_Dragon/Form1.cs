using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Fractal_Dragon
{
        public partial class Form1 : Form
        {
            public Graphics g; //�������
            public Bitmap map; //������
            public Pen p; //�����

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                map = new Bitmap(pictureBox1.Width, pictureBox1.Height);//���������� ������
                g = Graphics.FromImage(map); //���������� �������
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//�������� �����������
                p = new Pen(Color.Blue); //����� �����

                //������ ���������� ������ ��������
                float x0 = pictureBox1.Width / 16;
                float y0 = pictureBox1.Height - x0;

                int len = 1; //������ ����������� �����

                //����� ������� ��������� ��������
                drawFiboWord(x0, y0, len, 23);

                //����� ������������� �� ������� �� picturebox
                pictureBox1.BackgroundImage = map;

            }

            //������� ��������� ��������
            public void drawFiboWord(float x0, float y0, float a, int iter)
            {

                String s;
                String s1 = "1";
                String s2 = "0";

                // �������� ������ ��������� �� iter ��������
                for (int i = 0; i < iter - 2; i++)
                {
                    s = s2 + s1;
                    s1 = s2;
                    s2 = s;
                }

                //���� ���� ���� ��������, ����� ���� ������ = "1", ����� �� �������� ������ ������ s �� s2
                if (iter == 1) s = "1";
                else s = s2;

                //��������� ������ � ������ char, ����� �������� � ������ ��������
                char[] schar = new char[50];
                schar = s.ToCharArray();

                float vx = 0, vy = -1;// ��������� ������ (0,-1) �� ���� �����
                float x1 = x0;
                float y1 = y0;
                float x2, y2, temp;

                for (int i = 0; i < s.Length; i++)
                {
                    //�������� ������� ����� � � ����������� ������� (vx,vy)
                    x2 = x1 + a * vx;
                    y2 = y1 + a * vy;

                    //���������� �����
                    g.DrawLine(p, x1, y1, x2, y2);

                    //�������������� ����������
                    x1 = x2;
                    y1 = y2;

                    if (schar[i] == '0')
                    {
                        // ������� ������ ������� �������� - {{0,-1},{1,0}}
                        if (i % 2 == 0)
                        {
                            temp = vx;
                            vx = -1 * vy;
                            vy = temp;
                        }
                        // ������� ������� ������� �������� - {{0,1},{-1,0}}
                        else
                        {
                            temp = vx;
                            vx = vy;
                            vy = -1 * temp;
                        }
                    }
                }
            }
        }
    }