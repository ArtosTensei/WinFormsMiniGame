using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gamePanel.Visible = false;
        }

        private void showPanel()
        {
            if (gamePanel.Visible == false)
                gamePanel.Visible = true;
            else
                gamePanel.Visible = false;
        }

        private void showGamePanel()
        {
            if (userControl11.Visible == false)
                userControl11.Visible = true;
            else
                userControl11.Visible = false;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            showPanel();
        }

        private void newGame_Click_1(object sender, EventArgs e)
        {
            showGamePanel();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
