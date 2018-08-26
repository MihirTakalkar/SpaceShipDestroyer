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
        int score = 0;
        Random rand;
        List<SpaceShip> spaceShipList;

        private void Game_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            gfx = Graphics.FromImage(bitmap);
            spaceShipList = new List<SpaceShip>();
          
            spaceShipList.Add(new SpaceShip(Properties.Resources.SpaceShip, 0, 0, 30));
            portal = new Portal(Properties.Resources.Portal, 425, 910, 40);
            rand = new Random();
            
        }

        private void ShipSpawn_Tick(object sender, EventArgs e)
        {
            ShipSpawn.Interval = ShipSpawn.Interval - (score / 2 + 10);
            spaceShipList.Add(new SpaceShip(Properties.Resources.SpaceShip, rand.Next(0,600), 0, 30));
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            Score.Text = $"Score: {score}";

            for (int i = 0; i < spaceShipList.Count; i++)
            {
                if (spaceShipList[i].hitbox.IntersectsWith(portal.hitbox))
                {
                    score++;
                    //remove the spaceship that intersected
                    spaceShipList.Remove(spaceShipList[i]);
                    //DrawTimer.Enabled = false;

                }
            
            }
            gfx.Clear(Color.White);
            gfx.DrawImage(Properties.Resources.wallpaper2you_28630__1_, 0, 0, ClientSize.Width, ClientSize.Height);

            portal.Update();
            portal.Draw(gfx);
            //portal.DrawHitbox(gfx);

            for (int i = 0; i < spaceShipList.Count; i++)
            {
                spaceShipList[i].Update();
            }
            for (int i = 0; i < spaceShipList.Count ; i++)
            {
                spaceShipList[i].Draw(gfx);
            }
               for (int i = 0; i < spaceShipList.Count; i++)
            {
                spaceShipList[i].Update();
            }
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
