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
        int speedy;

        public SpaceShip(Image picture, int x, int y, int speedy)
        {
            this.picture = picture;
            this.x = x;
            this.y = y;
            this.speedy = speedy;
        }

        public void Update()
        {

        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(picture, x, y);
        }
    }
}
