using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Snaccident_Dog_attempt_one_06_January_2025
{
    // Added on Wednesday, 5th March 2025.

    /* 
     * The Chocolate class will be used by the main Form 1.cs class and will 'spawn' or create one instances of the chocolate bar sprite; I have not yet started designing the proper and final pixel art for said sprite as at 10th March 2025.
     * 
     * I will try to figure out what to do myself as I did with figuring out how to add things to Nathan's Snake Game, the previous game I made and my first graphical C# game, and to version 1 of this game.
     * 
     * I expect myself to feel frustrated, confused, fed up, and determined to find a way to add working code to this class.
     * 
     * As at 10th March 2025, I managed to add the chocolate bar sprite to the game board from Form 1.cs as well as a suitable game over message which appears after the game ends.
     * 
     * Now on 10th March 2025, I will try to add working code that makes the chocolate bar sprite appear at a different spot on the game board every time the Replay button is clicked. The chocolate bar sprite will always change its spot and I am glad I made this clear.
     * 
     * I will start by using the Random feature and become increasingly frustrated from there.
     * 
     * As a reward for getting the code working as intended, I will look forward to spending a weekend designing the proper and final pixel art for the chocolate bar sprite. Good luck!
     */

    internal class Chocolate
    {
        // These variables will determine the furthest positions at which the enemy sprites can go vertically and horizontally.

        // These variables were completed after following the tutorial video by Moo ICT at 55:18 (5:21pm AEDT).
        public int minHeight = 75 /*68*/;
        public int maxHeight = 917 /*693*/;

        public int minWidth = 72 /*63*/;
        public int maxWidth = 944 /*894*/;



        // Commented out sometime between February and March 2025.
        // Reintroduced on Sunday, 30th March 2025.

        // This variable will do something. This variable will generate a random number which the game will reduce to zero and then change to a different value. In my own words, int change will cause all of the enemy variables to move in random directions when they enter 'seek' mode... I think?
        //int change;
        Random random = new Random();

        int change;

        // A string array (yay!) will define the directions the player can move towards. Then, a single string variable will contain the default direction in which the player will move.
        string[] directions = { "left", "right", "up", "down" };
        string direction = "left";

        // I think this new picture-box will show the custom image files for the enemy sprites?
        public PictureBox img = new PictureBox();
        
        // Nope.
        //private Form1 form1;
        //private object x;
        //private object y;

        public Chocolate(Form game, Image Choco, int x, int y)
        {
            // The settings for the enemy sprites will be specified here.
            // The main class file (Form1) will be referenced in this Ghost function in order to allow me to add this Ghost function from the Ghost class file to Form1.

            // Create a picture-box and name it with familyFace or whatever the name given to Image above is.
            img.Image = Choco;

            // Specify how the image will be shown in the game (like specifying the same setting from the Properties panel on the right-hand-side.)

            // Updated on Saturday, 5th April 2025.
            img.SizeMode = PictureBoxSizeMode.AutoSize/*StretchImage*/;

            // Specify how wide or narrow and tall or short the image will be in the game.
            //img.Width = 85;
            //img.Height = 85;

            // Specify where or what x and y are in the game.
            img.Left = x;
            img.Top = y;

            game.Controls.Add(img);
        }

        //public Chocolate(Form1 form1, object x, object y)
        //{
        //    this.form1 = form1;
        //    this.x = x;
        //    this.y = y;
        //}

        //public void EnemyMovement(PictureBox dogSprite) // Updated picture-box name from dogSpriteAgain to dogSprite on 8th January 2025. The enemy sprites seem to be more interested in the whereabouts of the dog sprite.
        //{
        //    // Added on Tuesday, 7th January 2025.
        //    // Timestamp in the tutorial video on YouTube: 58:13

        //    // I think this is where the enemy sprites' 'seek' mode is generated.

        //    // If the dog sprite is zero (0), then this means the enemy sprites close in on the dog sprite. The enemy sprites closing in is determined by change--.
        //    if (change > 0)
        //    {
        //        change--;
        //    }



        //    // However, when the enemy sprites have closed in on the dog sprite, the enemy sprites will change direction randomly and move away from the dog sprite.
        //    else
        //    {
        //        change = random.Next(50, 100);
        //        direction = directions[random.Next(directions.Length)];
        //    }



        //    // Finally, the enemy sprites' movements will be defined by the string array containing directions created earlier. The code below looks similar to that typed up for the player's movements.

        //    switch (direction)
        //    {
        //        case "left":
        //            img.Left -= speed;
        //            break;

        //        case "right":
        //            img.Left += speed;
        //            break;

        //        case "up":
        //            img.Top -= speed;
        //            break;

        //        case "down":
        //            img.Top += speed;
        //            break;



        //        // Timestamp in the tutorial video on YouTube: 01:12:29
        //        // The guy in the video tutorial said there will be a lot of statements to type up here. Hahaha!

        //        case "seek":
        //            if (img.Left > dogSprite.Left)
        //            {
        //                img.Left -= xSpeed; // I guess the minus symbol means 'Go left.'.
        //            }

        //            if (img.Left < dogSprite.Left)
        //            {
        //                img.Left += xSpeed;
        //            }

        //            if (img.Top > dogSprite.Top)
        //            {
        //                img.Top -= ySpeed;
        //            }

        //            if (img.Top < dogSprite.Top)
        //            {
        //                img.Top -= ySpeed;
        //            }
        //            break;
        //    }



        //    // Timestamp in the tutorial video on YouTube: 01:08:27
        //    if (img.Left < minWidth)
        //    {
        //        direction = "right";
        //    }

        //    if (img.Left + img.Width > maxWidth)
        //    {
        //        direction = "left";
        //    }

        //    if (img.Top < minHeight)
        //    {
        //        direction = "down";
        //    }

        //    if (img.Top + img.Height > maxHeight)
        //    {
        //        direction = "up";
        //    }
        //}

        public void ChangeDirection()
        {
            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:17:00

            /* 
             * The guy in the tutorial video wanted his ghost sprites to change their direction when a game ends.
             * 
             * In my game, the enemy sprites will change their direction when a game ends.
             * 
             * The code is apparently as quick and simple as copying and pasting an existing line of code from the EnemyMovement() function.
             */

            if (change > 0)
            {
                change--;
            }



            //// However, when the enemy sprites have closed in on the dog sprite, the enemy sprites will change direction randomly and move away from the dog sprite.
            else
            {
                change = random.Next(50, 100);
                direction = directions[random.Next(directions.Length)];
            }

            direction = directions[random.Next(directions.Length)];

            //X = 0;
            //Y = 0;
        }


    }
}
