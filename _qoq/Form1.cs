using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _qoq
{
    public partial class Form1 : Form
    {
        List<ball> balls;
        private int _x, _y;
        //Location local1 = new Location(0, 0);
        //private int width_form1;
        //private int height_form1; 

  

        public Form1()
        {
            InitializeComponent();

            balls = new List<ball>();

            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                balls.Add(new ball(Width, Height, r));
            }
            var task = new Task(Run);
            task.Start();
            

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var ball in balls)
            {
                ball.draw(g);
            }
        }

        protected void Run()
        {
            while (true)
            {
                foreach (var ball in balls)
                {
                    ball.move(this.Width, this.Height);
                }

                // b1.move(this.Width, this.Height);
                this.Invalidate();
                //fps=60 constain
                Thread.Sleep(1000 / 60); //ความเร็ว

            }
        }

        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }
        public int y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
      
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            move_player(sender,e);
            check_location_ball();
            check_form_1();

        }
        public void move_player(object sender, KeyEventArgs e)
        {
            int x = player.Location.X;
            int y = player.Location.Y;

            if (e.KeyCode == Keys.A)
            {
                if (x >= 0)
                {
                    x -= 4;
                }
            }

            if (e.KeyCode == Keys.D)
            {
                if (x <= 315)
                {
                    x += 4;
                }

            }
            if (e.KeyCode == Keys.W)
            {
                if (y >= 5)
                {
                    y -= 4;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (0 <= y && y <= 240)
                {
                    y += 4;
                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (x <= 315 && y >= 0 && y <= 245)
                {
                    { x += 4; y -= 4; }
                }
            }
            if (e.KeyCode == Keys.Q)
            {
                if (x >= 0 && y >= -2 && y <= 245)
                {
                    { x -= 4; y -= 4; }
                }
            }

            if (e.KeyCode == Keys.Z)
            {
                if (x >= 0 && y <= 240)
                {
                    { x -= 4; y += 4; }
                }
            }
            if (e.KeyCode == Keys.X)
            {
                if (x <= 315 && y <= 240)
                {
                    { x += 4; y += 4; }
                }
            }

            player.Location = new Point(x, y);
        }

        public void check_location_ball()
        {

            int x = player.Location.X;
            int y = player.Location.Y;

            float[] dis_x_ball = new float[balls.Count];
            float[] dis_y_ball = new float[balls.Count];


            for (int a = 0; a < balls.Count; a++)
            {

                dis_x_ball[a] = Math.Abs(x - balls[a].x);
                dis_y_ball[a] = Math.Abs(y - balls[a].y);
            }


            for (int b = 0; b < balls.Count; b++)
            {

                if (dis_x_ball[b] < 30 && dis_y_ball[b] < 30)
                {
                    player.Location = new Point(0, 100);

                }
            }
        }
        public void check_form_1()        
        {
            int x = player.Location.X;
            int y = player.Location.Y;
            int i = end_1.Location.X;
            int j = end_1.Location.Y;

            int a = Math.Abs(x - i);
            int b = Math.Abs(y - j);

            if (a < 8 && b < 8)
            {
                this.Hide();
                Form form_2 = new Form2();
                form_2.Show();

            }
        }


//NoUse
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

    }
}
