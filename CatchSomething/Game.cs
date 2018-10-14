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
        Bitmap bitmap;
        Graphics gfx;
        Random rand;
        Random rando;
        List<SpaceShip> spaceShipList;
        List<Powerup> powerUpList;
        int shipsMissed = 0;
        int score = 0;


        private void Game_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            gfx = Graphics.FromImage(bitmap);
            spaceShipList = new List<SpaceShip>();
            spaceShipList.Add(new SpaceShip(Properties.Resources.SpaceShip, 0, 0, 30));
            powerUpList = new List<Powerup>();
            powerUpList.Add(new Powerup(Properties.Resources.Shield_in_Sonic_Runners1,0 ,0 , 10));
            portal = new Portal(Properties.Resources.Portal, 425, 910, 40);
            rand = new Random();
            rando = new Random();
            
        }

        private void ShipSpawn_Tick(object sender, EventArgs e)
        {
          
            if (ShipSpawn.Interval < 500)
            {
                ShipSpawn.Interval = 500;
            }
                ShipSpawn.Interval = ShipSpawn.Interval - (score / 2 + 10);
                spaceShipList.Add(new SpaceShip(Properties.Resources.SpaceShip, rand.Next(0, 600), 0, 30));
           
        }

        private void PowerSpawn_Tick(object sender, EventArgs e)
        {
           powerUpList.Add(new Powerup(Properties.Resources.Shield_in_Sonic_Runners1, rando.Next(0, 600), 0, 30));
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {

            Score.Text = $"Score: {score}";

            for (int i = 0; i < spaceShipList.Count; i++)
            {
                if (spaceShipList[i].hitbox.IntersectsWith(portal.hitbox))
                {
                    score++;
                    spaceShipList.Remove(spaceShipList[i]);
                    continue;

                }

                if (spaceShipList[i].hitbox.Top > bitmap.Height)
                {
                    spaceShipList.Remove(spaceShipList[i]);
                    shipsMissed++;
                }
            
            }
            for (int i = 0; i < powerUpList.Count; i++)
            {
                if (powerUpList[i].hitbox.IntersectsWith(portal.hitbox))
                {
                    if (shipsMissed > 0 && shipsMissed < 3)
                    {
                        shipsMissed--;
                    }
                    powerUpList.Remove(powerUpList[i]);
                    continue;

                }

                if (powerUpList[i].hitbox.Top > bitmap.Height)
                {
                    powerUpList.Remove(powerUpList[i]);
                }

            }


            if (shipsMissed >= 3)
            {
                this.Close();
                EndScreen screen = new EndScreen();
                screen.Show();
            }
            gfx.Clear(Color.White);
            gfx.DrawImage(Properties.Resources.wallpaper2you_28630__1_, 0, 0, ClientSize.Width, ClientSize.Height);
            if (shipsMissed == 0)
            {
                gfx.DrawImage(Properties.Resources.heart_sprite_png_4, 16, 102, 47, 33);
                gfx.DrawImage(Properties.Resources.heart_sprite_png_4, 65, 102, 47, 33);
                gfx.DrawImage(Properties.Resources.heart_sprite_png_4, 114, 102, 47, 33);
            }
            if (shipsMissed == 1)
            {
                gfx.DrawImage(Properties.Resources.heart_sprite_png_4, 16, 102, 47, 33);
                gfx.DrawImage(Properties.Resources.heart_sprite_png_4, 65, 102, 47, 33);
 
            }
            if (shipsMissed == 2)
            {
                gfx.DrawImage(Properties.Resources.heart_sprite_png_4, 16, 102, 47, 33);
               
            }
            portal.Update();
            portal.Draw(gfx);
            

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

            for (int i = 0; i < powerUpList.Count; i++)
            {
                powerUpList[i].Update();

            }
            for (int i = 0; i < powerUpList.Count; i++)
            {
                powerUpList[i].Draw(gfx);

            }
            for (int i = 0; i < powerUpList.Count; i++)
            {
                powerUpList[i].Draw(gfx);
            }


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
