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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}



