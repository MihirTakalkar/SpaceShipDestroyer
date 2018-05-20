using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchSomething
{
    class Portal
    {
        Image image;
        int x;
        int y;
        int speedx;
        public bool Left = false;
        public bool Right = false;

        public Portal(Image image, int x, int y, int speedx)
        {
            this.image = image;
            this.x = x;
            this.y = y;
            this.speedx = speedx;
        }

        public void Update()
        {
            if (Left == true)
            {
                if (x > 0)
                {
                    x -= speedx;
                }

            }

            if (Right == true)
            {
                if (x < 830)
                {
                    x += speedx;
                }

            }
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(image, x, y);
        }

    }
}
