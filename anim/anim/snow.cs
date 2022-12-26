using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace anim
{
    internal class snow
    {
        int diametr;
        int speed;
        double angle;

        public int X { get; private set; }
        public int Y { get; private set; }

        public snow (int diametr, int speed, double angle, int x, int y)
        {

            this.diametr = diametr;
            this.speed = speed;
            this.angle = angle;
            X = x;
            Y = y;
        }

        
    }
}
