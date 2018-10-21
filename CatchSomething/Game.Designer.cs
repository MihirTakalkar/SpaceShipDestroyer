namespace CatchSomething
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.ShipSpawn = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PowerSpawn = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Poower = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawTimer
            // 
            this.DrawTimer.Enabled = true;
            this.DrawTimer.Interval = 2;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.Font = new System.Drawing.Font("Pericles", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Transparent;
            this.Score.Location = new System.Drawing.Point(12, 61);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(73, 21);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score:  ";
            // 
            // ShipSpawn
            // 
            this.ShipSpawn.Enabled = true;
            this.ShipSpawn.Interval = 2000;
            this.ShipSpawn.Tick += new System.EventHandler(this.ShipSpawn_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Motorwerk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spaceship\r\nDestroyer";
            // 
            // PowerSpawn
            // 
            this.PowerSpawn.Enabled = true;
            this.PowerSpawn.Interval = 10000;
            this.PowerSpawn.Tick += new System.EventHandler(this.PowerSpawn_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CatchSomething.Properties.Resources.wallpaper2you_28630__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 1058);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Poower
            // 
            this.Poower.Enabled = true;
            this.Poower.Interval = 15000;
            this.Poower.Tick += new System.EventHandler(this.Poower_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 1058);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer ShipSpawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer PowerSpawn;
        private System.Windows.Forms.Timer Poower;
    }
}

