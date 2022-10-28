/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationLifes
{
    public partial class Form1 : Form
    {
        //private int currentGeneration = 0;
        private Graphics graphics;
        private int resolution;
        //private bool[,]field;
        //private int rows;
        //private int cols;

        private GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();
        }



        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            //currentGeneration = 0;// сброс счетчика с прошлой игры
            //Text = $"Generation {currentGeneration}";


            numResolution.Enabled = false;
            label2.Enabled = false;

            resolution = (int)numResolution.Value;

            gameEngine = new GameEngine
                (
                    rows: pictureBox1.Height/ resolution,
                    cols: pictureBox1.Width/ resolution,
                    density:(int)(numDensity.Minimum) + (int)(numDensity.Maximum) - (int)numDensity.Value
                );

            //rows = pictureBox1.Height / resolution;
            //cols = pictureBox1.Width / resolution;
            //field = new bool[cols, rows];


            Text = $"Generation {gameEngine.CurrentGeneration}";

            /*Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)numDensity.Value) == 0;
                }
            }


            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
            //graphics.FillRectangle(Brushes.Crimson, 0, 0, resolution, resolution);
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);
            
            var field = gameEngine.GetCurrentGeneration();//info real stats

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }
            /*var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var haslife = field[x, y];

                    if (haslife && neighboursCount == 3)
                    {
                        newField[x, y] = true;

                    }

                    else if(haslife && neighboursCount < 2 || neighboursCount > 3)

                    {
                        newField[x, y] = false;
                    }

                    else
                    {
                        newField[x, y] = field [x, y];// присваиваем те же данные
                    }

                    if (haslife) //if true
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution -1);
                    }
                }
            }
            field = newField;// присвоим новый массив

            
            

            pictureBox1.Refresh();
            Text = $"Generation {gameEngine.CurrentGeneration}";
            gameEngine.NextGeneration();
        }

        /*private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;// за край карты для расчета соседей
                    var row = (y + j + rows) % rows;
                    
                    bool isSafeChecking = col == x && row == y;
                    var hasLife = field[col, row];
                    
                    if (hasLife && isSafeChecking)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void StopGame()
        {
            if (timer1.Enabled)
                return;
            timer1.Stop();

            numResolution.Enabled = true;
            numDensity.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        //Mouse Controller
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
                return;

            if(e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.AddCell(x, y);
                /*var ValidationPassed = ValidateMousePosition(x, y);
                if (ValidationPassed)
                    field[x, y] = true;

                field [x, y] = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.RemoveCell(x, y);
                /*var ValidationPassed = ValidateMousePosition(x, y);
                if (ValidationPassed)
                    field[x, y] = false;
                field[x, y] = false;
            }
        }

        // Validation
        /*private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }
    }
}*/