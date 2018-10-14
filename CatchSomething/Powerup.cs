using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchSomething
{
    class Powerup
    {
        public Image photo;
        int x;
        int y;
        int width;
        int height;
        int speedy;
        public Rectangle hitbox { get; set; }

        public Powerup (Image photo, int x, int y, int speedy)
        {
            this.photo = photo;
            this.x = x;
            this.y = y;
            this.speedy = speedy;

            hitbox = new Rectangle(x, y, width, height);
        }

        public void Update()
        {
            y += speedy;
            hitbox = new Rectangle(x + 10, y + 10, photo.Width + 20, photo.Height + 20);
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(photo, x, y);
        }
    }
}
