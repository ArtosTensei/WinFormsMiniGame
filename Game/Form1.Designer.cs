
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl11 = new Game.UserControl1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.newGame = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // userControl11
            // 
            resources.ApplyResources(this.userControl11, "userControl11");
            this.userControl11.Cursor = System.Windows.Forms.Cursors.Default;
            this.userControl11.Name = "userControl11";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.BackgroundImage = global::Game.Properties.Resources.logo;
            this.panel2.Name = "panel2";
            // 
            // play
            // 
            resources.ApplyResources(this.play, "play");
            this.play.BackColor = System.Drawing.SystemColors.Desktop;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.play.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.play.Name = "play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // gamePanel
            // 
            resources.ApplyResources(this.gamePanel, "gamePanel");
            this.gamePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gamePanel.Controls.Add(this.newGame);
            this.gamePanel.Controls.Add(this.button3);
            this.gamePanel.Name = "gamePanel";
            // 
            // newGame
            // 
            resources.ApplyResources(this.newGame, "newGame");
            this.newGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.newGame.FlatAppearance.BorderSize = 0;
            this.newGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGame.Name = "newGame";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click_1);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gamePanel);
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.gamePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private UserControl1 userControl11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

