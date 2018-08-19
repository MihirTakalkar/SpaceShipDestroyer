﻿using System;
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
        int width;
        int height;
        public bool Left = false;
        public bool Right = false;
       public Rectangle hitbox { get; set; }

        public Portal(Image image, int x, int y, int speedx)
        {
            this.image = image;
            this.x = x;
            this.y = y;
            this.speedx = speedx;
            hitbox = new Rectangle(x, y, width, height);
            
        }

        public void Update()
        {
            if (Left == true)
            {
                if (x > 20)
                {
                    x -= speedx;
                }

            }

            if (Right == true)
            {
                if (x < 490)
                {
                    x += speedx;
                }

            }

            hitbox = new Rectangle(x, y, image.Width + 32, image.Height + 31);
            
        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(image, x, y);
        }

        //public void DrawHitbox(Graphics gfx)
        //{
        //    gfx.DrawRectangle(Pens.Gold, hitbox);
        //}
    }
}
