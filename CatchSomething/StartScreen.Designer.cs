namespace CatchSomething
{
    partial class StartScreen
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
            this.Title = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Pericles", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(80, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 94);
            this.Title.TabIndex = 0;
            this.Title.Text = "Spaceship\r\nDestroyer";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Pericles", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.Lime;
            this.PlayButton.Location = new System.Drawing.Point(198, 287);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(146, 40);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Pericles", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Red;
            this.QuitButton.Location = new System.Drawing.Point(29, 287);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(144, 40);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Pericles", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(48, 203);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(283, 17);
            this.Description.TabIndex = 3;
            this.Description.Text = "Eliminate Spaceships Using Your Portal";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatchSomething.Properties.Resources.Background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Title);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label Description;
    }
}