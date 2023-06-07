using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBird_Move(object sender, EventArgs e)
        {

        }

        private void FlappyBird_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
           FlappyBird.Top += gravity;
            pipebottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            sc.Text = "score: " +score;
            if (pipebottom.Left < -150)
            {
                pipebottom.Left += 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left += 950;
                score++;
            }
            if(FlappyBird.Bounds.IntersectsWith(pipebottom.Bounds)|| 
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || 
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < 25
                )
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 12;

            }
          
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }

        }

        

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }

        }
        private void endGame()
        {
            gameTimer.Stop();
            sc.Text += " Game Over!!!";
        }

    }
}
