using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _qoq
{
    class Location
    {
        private int x_form1;
        private int y_form1;

        public int X_form1
        {
            get
            {
                return x_form1;
            }

            set
            {
                x_form1 = 500;
            }
        }

        public int Y_form1
        {
            get
            {
                return y_form1;
            }

            set
            {
                y_form1 = 500;
            }
        }

        public Location(int x, int y)
        {
            this.X_form1 = x;
            this.Y_form1 = y;
        }

       

        /*     public static bool operator ==(Location l1, Location l2)
             {
                 return (l1.X == l2.X && l1.Y == l2.Y);
             }

             public static bool operator !=(Location l1, Location l2)
             {
                 return (l1.X != l2.X || l1.Y != l2.Y);
             }
       */
    }

}
