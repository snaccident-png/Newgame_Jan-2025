using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snaccident_Dog_attempt_one_06_January_2025
{
    public partial class splashScreenSD : Form
    {
        public splashScreenSD()
        {
            InitializeComponent();
        }

        private void TimerStop(object sender, EventArgs e)
        {
            // Added on Wednesday, 12th February 2025.
            // I tested my ability to remember code I saw in a tutorial video on YouTube for making a splash screen operational or functional. On the one hand, I managed to get the splash screen showing up. On the other hand, the timer does not work. I will have a look at the code I wrote for Nathan's Snake Game.

            /*
             * My first attempt, blind coding (Kind of like the Look, Cover, Write, Look Again thing I may or may not have learnt at primary school.)
             * 
             * timerSD.Start();
            
            progressBar.Enabled = true;
            progressBar.Value = 0;
            progressBar.Increment(2);

            if (progressBar.Value == 100)
            {
                timerSD.Stop();

                Form form = new Form();
                
                this.Hide();
                form.Show();
            }
            */

            // My second attempt, using the code I wrote for Nathan's Snake Game.

            // I thought I needed to enable and disable the splash screen itself but having looked over my code for the splash screen for Nathan's Snake Game, I actually needed to enable and disable the timer.
            timerSD.Enabled = true;

            // I was right with this except for the value at the end.
            progressBar.Increment(1);


            // I was almost spot on but I used the wrong property. Instead of 'timerSD.Stop()', I should have entered 'timerSD.Enabled... ()'.
            if (progressBar.Value == 100)
            {
                timerSD.Enabled = false;

                Form1 gameSD = new Form1();

                this.Hide();
                gameSD.Show();
            }
        }
    }
}
