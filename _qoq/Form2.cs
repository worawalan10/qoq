using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _qoq
{
    public partial class Form2 : Form
    {
        private int _count;
        public int count2 
        {
            get { return _count; }
            set { _count = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            move_player(sender, e);
            check_location_ball();
            check_form_1();
        }

        public void check_location_ball()
        {
            //ดูบอลอีกทีว่าจะกำหนดยังไง
        }

        public void check_form_1()
        {
            int x = player2.Location.X;
            int y = player2.Location.Y;
            int i = item_2.Location.X;
            int j = item_2.Location.Y;
            int e = end_2.Location.X;
            int f = end_2.Location.Y;

            int dx = distance(x, i);
            int dy = distance(y, j);

            if(dx<10 && dy < 10)
            {
                count2 = count2 + 1;
                item_2.Hide();
            }

            int ix = distance(x, e);
            int iy = distance(y, f);

            if(ix<5&& iy < 5 && count2>=1)
            {
                this.Hide();
                Form f3 = new Form3();
                f3.ShowDialog();
            }

          
        }
        public int distance(int a, int b)
        {
            return Math.Abs(a - b);
        }

        public void move_player(object sender, KeyEventArgs e)
        {
            int x = player2.Location.X;
            int y = player2.Location.Y;

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

            player2.Location = new Point(x, y);
        }



    }
}
