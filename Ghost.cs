using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // Added on 7th January 2025: This namespace thing will be needed.

namespace Snaccident_Dog_attempt_one_06_January_2025
{
    // Added on Monday, 6th January 2025.
    // Timestamp in the tutorial video on YouTube: 16:03

    /* 
     * The Ghost class, or rather, the Enemy class, will be used by the main Form 1.cs class to 'spawn' or create multiple instances or copies of the same ghost independently and perhaps more easily than timing them using the game timer function.
     * 
     * According to the tutorial video I am following, I may be able to assign different images to different copies of the Enemy class in the main Form1 class.
     */

    internal class enemy
    {
        // Added on Tuesday, 7th January 2025.
        // Timestamp in the tutorial video on YouTube: 48:25

        // I assume this speed variable sets how slow or fast the enemy sprites will move.
        int speed = 12;

        // When the enemy sprites go into 'seek' or 'attack' mode, these variables set a slower speed for the enemy sprites. I just imagined the dog sprite being chased by fast-moving enemy sprites hahaha! But I will control myself for now and follow the tutorial video.
        int xSpeed = /*3*/ /*16*/ 8;
        int ySpeed = /*3*/ /*16*/ 8;

        // These variables will determine the furthest positions at which the enemy sprites can go vertically and horizontally.

        // These variables were completed after following the tutorial video at 55:18 (5:21pm AEDT).



        // BUG RELATING TO THE INTERACTION BETWEEN THE ENEMY DOG SPRITES AND THE BOUNDARY SHAPES WAS FIXED. 14th March 2025.
        // I increased or decreased the values for minHeight, maxHeight, minWidth, and maxWidth.

        int minHeight = 95 /*85*/ /*75*/ /*68*/; 
        
        // I belatedly realised why the guy in the tutorial video altered some of these values and altered some myself (10:17pm).
        /*
         * Wha-hey! With curiosity and my observation skills, I succeeded in stopping the enemy sprites from leaving the game board!
         * 
         * I used the x values for one boundary shape on the left and on the right, respectively, and used the y values for one boundary
         * shape at the top and at the bottom, respectively, then added ten to the minimum values and subtracted ten from the maximum 
         * values and hey presto things worked out.
         */

        int maxHeight = 897 /*907*/ /*917*/ /*693*/;

        int minWidth = 100 /*90*/ /*80*/ /*70*/ /*63*/;
        int maxWidth = 914 /*924*/ /*934*/ /*944*/ /*894*/;

        // Notes for minimum and maximum height values: 135 (min) and 1012 (max).
        // Notes for minimum and maximum width values: 124 (min) and 1288 (max).



        // Changes to height and width values on Thursday, 23rd January 2025.
        // Notes for minimum and maximum height values: 135 (min) and 1012 (max).
        // Notes for minimum and maximum width values: 124 (min) and 1288 (max).



        // This variable will do something. This variable will generate a random number which the game will reduce to zero and then change to a different value. In my own words, int change will cause all of the enemy variables to move in random directions when they enter 'seek' mode... I think?
        int change;
        Random random = new Random();

        // A string array (yay!) will define the directions the player can move towards. Then, a single string variable will contain the default direction in which the player will move.
        string[] directions = { "left", "right", "up", "down", "seek" }; // The tutorial video said to work up to seek.

        
        
        // Added and commented out on Friday, 4th April 2025.
        // If I separate the directions into two strings...

        //string[] directionsX = { "left", "right" };
        //string[] directionsY = { "up", "down" };



        string direction = "left";

        // I think this new picture-box will show the custom image files for the enemy sprites?
        public PictureBox img = new PictureBox();

        //bool noLeft, noRight, noUp, noDown;

        public enemy(Form game, Image familyFace, int x, int y)
        {
            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 52:37

            // The settings for the enemy sprites will be specified here.
            // The main class file (Form1) will be referenced in this Ghost function in order to allow me to add this Ghost function from the Ghost class file to Form1.

            // Create a picture-box and name it with familyFace or whatever the name given to Image above is.
            img.Image = familyFace;

            // Specify how the image will be shown in the game (like specifying the same setting from the Properties panel on the right-hand-side.)
            // Updated on Wednesday, 2nd April 2025.
            img.SizeMode = PictureBoxSizeMode.AutoSize/*StretchImage*/;

            // Specify how wide or narrow and tall or short the image will be in the game.
            //img.Width = 78;
            //img.Height = 75;

            // Specify where or what x and y are in the game.
            img.Left = x;
            img.Top = y;



            game.Controls.Add(img);
        }

        public void EnemyMovement(PictureBox dogSprite) // Updated picture-box name from dogSpriteAgain to dogSprite on 8th January 2025. The enemy sprites seem to be more interested in the whereabouts of the dog sprite.
        {
            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 58:13

            // I think this is where the enemy sprites' 'seek' mode is generated.

            // If the dog sprite is zero (0), then this means the enemy sprites close in on the dog sprite. The enemy sprites closing in is determined by change--.
            if (change > 0)
            {
                change--;
            }



            // However, when the enemy sprites have closed in on the dog sprite, the enemy sprites will change direction randomly and move away from the dog sprite.
            else
            {
                change = random.Next(20,100);
                //direction = directions[random.Next(directions.Length)];

                direction = directions[random.Next(directions.Length)];
                //direction = directionsY[random.Next(directionsY.Length)];
            }



            // Finally, the enemy sprites' movements will be defined by the string array containing directions created earlier. The code below looks similar to that typed up for the player's movements.

            switch (direction)
            {
                case "left":
                    img.Left -= speed;
                    break;

                case "right":
                    img.Left += speed;
                    break;

                case "up":
                    img.Top -= speed;
                    break;

                case "down":
                    img.Top += speed;
                    break;



                // Timestamp in the tutorial video on YouTube: 01:12:29
                // The guy in the video tutorial said there will be a lot of statements to type up here. Hahaha!

                case "seek":
                    if (img.Left > dogSprite.Left)
                    {
                        img.Left -= xSpeed; // I guess the minus symbol means 'Go left.'.
                    }

                    if (img.Left < dogSprite.Left)
                    {
                        img.Left += xSpeed;
                    }

                    if (img.Top > dogSprite.Top)
                    {
                        img.Top -= ySpeed;
                    }

                    if (img.Top < dogSprite.Top)
                    {
                        img.Top -= ySpeed;
                    }
                    break;
            }



            // Timestamp in the tutorial video on YouTube: 01:08:27
            if (img.Left < minWidth)
            {
                direction = "right";
            }

            if (img.Left + img.Width > maxWidth)
            {
                direction = "left";
            }

            if (img.Top < minHeight)
            {
                direction = "down";
            }

            if (img.Top + img.Height > maxHeight)
            {
                direction = "up";
            }
        }

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

            direction = directions[random.Next(directions.Length)];
            //direction = directionsX[random.Next(directionsX.Length)];
        }

        //public void ChangeDirectionY()
        //{
        //    direction = directionsY[random.Next(directionsY.Length)];
        //}

        //public void SlideDown(PictureBox safeSpaceLongEdge)
        //{
        //    // Added and commented out on Friday, 4th April 2025.

        //    // If I want the interaction between the enemy dog sprites and the long edges surrounding the safe space to make the former slide down the long edge instead of changing- Wait, this is the wrong function to edit. 

        //    // Just try it.
        //    if (img.Left > safeSpaceLongEdge.Left)
        //    {
        //        noLeft = true;
        //    }

        //    if (img.Left < safeSpaceLongEdge.Left)
        //    {
        //        noRight = true;
        //    }

        //    if (img.Top > safeSpaceLongEdge.Top)
        //    {
        //        noDown = true;
        //    }

        //    if (img.Top > safeSpaceLongEdge.Top)
        //    {
        //        noUp = true;
        //    }
        //}

    }
}
