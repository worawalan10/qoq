using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _qoq
{
    class ball
    {
        private float _x;
        private float _y;
        private float _xv;
        private float _yv;
        private float _r;
        public Brush brush;

        public float x
        {
            get { return _x; }
            set { _x = value; }
        }
        public float y
        {
            get { return _y; }
            set { _y = value; }
        }
        public float xv
        {
            get { return _xv; }
            set { _xv = value; }
        }
        public float yv
        {
            get { return _yv; }
            set { _yv = value; }
        }
        public float r
        {
            get { return _r; }
            set { _r = value; }
        }

//cons
        public ball (int width,int height, Random r)
        {
          
            this.x = r.Next(width);
            this.y = r.Next(height);
            this.xv = r.Next(5) + 5;
            this.yv = r.Next(5) + 5;
            this.r = r.Next(20) + 10;
            brush = new SolidBrush(Color.FromArgb(r.Next(127) + 127, r.Next(127) + 127, r.Next(127) + 127));
        }
        

        public void move(int width, int height)
        {
            if (_x - _r < 0 || _x + _r > width)
            {
                _xv = -_xv;
            }
            if (_y - _r < 0 || _y + _r > height)
            {
                _yv = -_yv;
            }
            _y += _yv;
        }
        public void draw(Graphics g)
        {
            //ขนาดจุด
            g.FillEllipse(brush, new RectangleF(_x - _r, _y - _r, _r * 2, _r * 2));
        }
    }
}
