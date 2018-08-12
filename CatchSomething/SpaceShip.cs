using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchSomething
{
    class SpaceShip
    {
        public Image picture;
        int x;
        int y;
        int width;
        int height;
        int speedy;
        Rectangle hitbox;

        public SpaceShip(Image picture, int x, int y, int speedy)
        {
            this.picture = picture;
            this.x = x;
            this.y = y;
            this.speedy = speedy;
        
            hitbox = new Rectangle(x, y, width, height);
        }

        public void Update()
        {
            hitbox.X = x;
            hitbox.Y = y;
            hitbox.Width = picture.Width;
            hitbox.Height = picture.Height;


            y += speedy;
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(picture, x, y);
        }
    }
}
