using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchSomething
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Portal portal;
        SpaceShip spaceship;
        Bitmap bitmap;
        Graphics gfx;

        private void Game_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            gfx = Graphics.FromImage(bitmap);
            spaceship = new SpaceShip(Properties.Resources.SpaceShip, 0, 0, 30);
            portal = new Portal(Properties.Resources.Portal, 425, 910, 40);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(spaceship.hitbox.IntersectsWith(portal.hitbox))
            {
               timer1.Enabled = false;
                MessageBox.Show("You got the spaceship!");

            }
            gfx.Clear(Color.White);
            gfx.DrawImage(Properties.Resources.wallpaper2you_28630__1_, 0, 0, ClientSize.Width, ClientSize.Height);

            portal.Update();
            portal.Draw(gfx);
           //portal.DrawHitbox(gfx);

            spaceship.Update();
            spaceship.Draw(gfx);
            //spaceship.drawHitbox(gfx);

            pictureBox1.Image = bitmap;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                portal.Right = true; 
            }

           if (e.KeyCode == Keys.Left)
            {
                portal.Left = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                portal.Right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                portal.Left = false;
            }
        }
    }
}
