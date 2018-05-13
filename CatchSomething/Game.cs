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

        private void Game_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
           //gfx = CreateGraphics();
            gfx = Graphics.FromImage(bitmap);
            portal = new Portal(Properties.Resources.Portal, 0, 0, 5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            gfx.DrawImage(Properties.Resources.Background3, 0, 0, ClientSize.Width, ClientSize.Height);

            portal.Draw(gfx);

            pictureBox1.Image = bitmap;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
