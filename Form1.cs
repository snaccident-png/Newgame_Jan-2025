using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Snaccident_Dog_attempt_one_06_January_2025
{
    public partial class Form1 : Form
    {
        // Added on Monday, 6th January 2025.
        // Timestamp in the tutorial video on YouTube: 17:40

        /* 
         * Apparently, here is where I will need to add a LOT of variables which, I think, will provide terms or
         * definitions for any of the functions below to call up and use.
         * 
         * Kind of like bringing out all the ingredients I need to make a curry from the refrigerator and leaving them
         * on the kitchen counter so I can return to the ingredients and pick up and prepare the ingredient(s) I need
         * at any time. Metaphors or similes!
         */

        // This bool tool provides directions for the game.
        bool goUp, goDown, goLeft, goRight;

        // This bool tool apparently makes sure that the player's sprite stops at the wall or boundary shape.
        bool noUp, noDown, noLeft, noRight;

        // Oh, lists! The things that are like arrays but easier or more efficient?
        List<PictureBox> walls = new List<PictureBox>();
        List<PictureBox> dogTreats = new List<PictureBox>();

        // This int variable assumedly controls how slow or fast the dog sprite moves during gameplay.
        int speed = 12;

        // I think I know for what purpose this int variable exists. The reason is to define the starting score?
        int score = 0;



        // Following the tutorial video on YouTube, I will add the enemy sprite code here in the near future (9:04pm AEDT).

            // Here it is and hopefully it works! (see below)

            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:02:00

            // The reason why the tutorial video showed typing up this code above the InitializeComponent() function is because from now on all of the functions can call up this code with ease. In doing so, functions do not need repeated instances of the Ghost code inside themselves.
            Ghost enemyOne, enemyTwo, enemyThree, enemyFour;

            // A new list called ghosts will be needed.
            List <Ghost> enemies = new List<Ghost>();




        public Form1()
        {
            InitializeComponent(); // Timestamp in the tutorial video: 24:44
                                   // InitializeComponent() loads everything on the Windows Form such as picture-boxes and labels.

            SetUp(); // SetUp() loads the lists and functions in this main class file such as EatFood() and GameOver().
        }

        private void KeyIsPressed(object sender, KeyEventArgs e)
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 14:05 then 27:29
            // Shorter comments please and thank you, Nathan.

            /* 
             * The KeyIsPressed() function allows the player to move the dog sprite vertically or horizontally.
             * 
             * The function uses a bool container which contains (I guess) terms or definitions for directions in which
             * the player can move the dog sprite.
             */

            /*
             * This code tells the game what the arrow keys should do when pressed or when held down.
             * 
             * I still have no idea why 'noLeft' and the rest of the 'no' terms are needed but if the tutorial video says these terms tell the player's sprite to keep moving into the same direction it was before then fine.
             */

            // But wait! There is more. Open the PlayerMovements() function...


            if (e.KeyCode == Keys.Left && !noLeft)
            {
                goRight = goDown = goUp = false;
                noRight = noDown = noUp = false;

                goLeft = true;
                dogSprite.Image = Properties.Resources.dogSprite_09_Jan_2025;
            }

            if (e.KeyCode == Keys.Right && !noRight)
            {
                goLeft = goDown = goUp = false;
                noLeft = noDown = noUp = false;

                goRight = true;
                dogSprite.Image = Properties.Resources.dogSprite_09_Jan_2025;
            }

            if (e.KeyCode == Keys.Up && !noUp)
            {
                goRight = goDown = goLeft = false;
                noRight = noDown = noLeft = false;

                goUp = true;
                dogSprite.Image = Properties.Resources.dogSprite_09_Jan_2025;
            }

            if (e.KeyCode == Keys.Down && !noDown)
            {
                goRight = goLeft = goUp = false;
                noRight = noLeft = noUp = false;

                goDown = true;
                dogSprite.Image = Properties.Resources.dogSprite_09_Jan_2025;
            }
        }

        private void ClickToStart(object sender, EventArgs e)
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 14:05 then 34:04

            /* 
             * The ClickToStart() function allows the player to click on a button that will start and run the game.
             * 
             * At some point in the near future, perhaps a function with code typed up to allow the player to replay
             * the game will be created?
             */

            /*
             * I cannot believe how dependent the KeyIsPressed(), PlayerMovements(), and GameTimerEvent() functions are on this
             * function.
             * 
             * I am not going to type up many code comments for those aforementioned functions and the same goes for this function.
             * 
             * I have had enough for one evening. Good night, Nathan.
             */

            // When the player clicks on the Start button, the panel will disappear.
            panel1.Enabled = false;
            panel1.Visible = false;
            Controls.Remove(panel1);

            // Added on 8th January 2025. I wanted the game over message to appear outside of the game title panel and so this code below may be needed and hopefully it hides after the start button is clicked on...
            gameOverMessage.Enabled = false;
            gameOverMessage.Visible = false;

            // Added on 8th January 2025. An extra panel with a replay button was added and it only appears at the end of the first game and all other games.
            replayPanel.Enabled = false;
            replayPanel.Visible = false;

            goLeft = goRight = goUp = goDown = false;
            noLeft = noRight = noUp = noDown = false;



            // The score displays the number zero as the player will be playing this game for the first time ever or for the first time in their current gameplay session.
            score = 0;

            dogSprite.Image = Properties.Resources.Red_test_sprite_06_January_2025; // Added on 8th January 2025. This code will reset the dog sprite to its starting appearance.


            // The enemy sprite code will be added in the near future.

            // Added on Wednesday, 8th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:18:35


            // This code resets the position of the enemy sprites to the starting position when the game ends.
            // The tutorial video said new Point is quite convenient for setting new locations for things.
            enemyOne.img.Location = new Point(97, 100);
                enemyTwo.img.Location = new Point(847, 100);
                enemyThree.img.Location = new Point(97, 640);
                enemyFour.img.Location = new Point(847, 640);


            // Finally, the game timer starts and the aforementioned functions finally become functional!
            gameTimer.Start();

            
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 14:05 then 33:45

            /* 
             * The gameTimerEvent() function allows the game to start and run.
             * 
             * Based on coding for my previous game, Nathan's Snake Game, and relevant tutorial videos on YouTube
             * I watched before, the game timer function will also be stopped in another function coming soon (the time is
             * 8:33pm AEDT).
             */

            // The tutorial video says that as soon as the game timer starts, the player should be able to move the Pac-Man sprite (tutorial video reference) in the defined directions.

            /*
             * And here the tutorial video said to call up PlayerMovements() and then enter code for the function equivalent to my
             * ClickToStart() function to make all of this code which I find partially redundant or unnecessary work.
             * 
             * With the click of a button.
             */

            PlayerMovements();



            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 41:19

            // I think I get why the guy in the tutorial video added PlayerMovements() to this function. The guy may have said something about adding some of the other functions to this function instead of adding all the code written for those functions to this function, making this function more tidy.

            foreach (PictureBox wall in walls)
            {
                CheckBoundaries(dogSprite, wall);
            }



            // I thought I knew what to do next for the EatFood() function and this worked!
            foreach (PictureBox food in dogTreats)
            {
                EatFood(dogSprite, food);
                this.Text = "Food eaten: " + score; // Added on 8th January 2025. The current amount of food eaten by the dog sprite now appears on the top-left corner of the application window!  
            }



            // Now, the ShowFoodAgain() function may launch and reset the number of food sprites on the game board...

            // Something is wrong with this function or the code below and I am feeling increasingly annoyed even though I do not necessarily need this function. Circle back to this annoying function.
            if (score == dogTreats.Count)
            {
                //ShowFoodAgain();
                //score = 0; // Checked again on 8th January 2025. This failed code now works! If I wanted the player to keep playing instantly as soon as the dog sprite eats all of the food sprites, I could enable this code.



                // Added on Wednesday, 8th January 2025.
                // Timestamp in the tutorial video on YouTube: 01:25:10

                GameOver("Well done! Your dog is now a very happy dog!");
                gameOverMessage.ForeColor = Color.Yellow;
            }
            else
            {
                gameOverMessage.ForeColor = Color.Red; // Added my own code on 8th January 2025. This ELSE statement changes back the colour of the game over message to red which is the case when the dog sprite runs into an enemy sprite and causes the game to end.
            }

            // With the code for the enemy sprites typed up, the sprites and their movements have been added here. Apparently each enemy sprite will dote on the dog sprite but so far in my tests no such thing has happened yet but the tutorial video playing in the background may be covering this game mechanism! (10:36pm)
            enemyOne.EnemyMovement(dogSprite);
            enemyTwo.EnemyMovement(dogSprite);
            enemyThree.EnemyMovement(dogSprite);
            enemyFour.EnemyMovement(dogSprite);



            // Added on Wednesday, 8th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:23:56

            // I just tested the game with the new FOREACH loop statement and I am still very happy to say that as soon as one of the enemy sprites met the dog sprite, the game timer ended, the panel showed up again, the custom message showed up too, and above all, the ShowFoodAgain() function is working now! I guess it will only work when the dog sprite meets an enemy sprite but who cares it works now!

            foreach (Ghost enemy in enemies)
            {
                EnemyAttack(enemy, dogSprite, enemy.img);
            }
        }

        private void SetUp()
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 25:10

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from SetUp() to CheckBoundaries().

            /* 
             * The SetUp() function allows something to happen. I will come back to this (9:22pm AEDT)
             * 
             * I still have no idea what this function does. (9:53pm)
             */

            // OK. Either the tutorial video did a terrible job of explaining what SetUp() actually does or I am just dumb. Apparently, SetUp() looks for picture-boxes with the word 'wall' or 'food' in their tag, separately and respectively, and if so, SetUp() will add those picture-boxes to the relevant list I created at the top of this main class file.

            // For example, the game will add all picture-boxes with 'wall' in their tag to the list called 'walls'.

            // Also, I remembered to note that the picture-boxes refer to the boundary shapes on each corner of the game board.

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    walls.Add((PictureBox)x);
                }

                if (x is PictureBox && x.Tag == "food")
                {
                    dogTreats.Add((PictureBox)x);
                }
            }

            // Also, this line of code displays how many wall shapes and copies of the food sprite there are on the game board which is kind of cool. These counters show up on the top-left corner of the application window? Yeah!

            // The tutorial video said to comment out the line of code as it was used to check if the FOR EACH loop was working.

            //this.Text = walls.Count + " " /* Oh that was a space! */ + dogTreats.Count;



            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:03:07

            // Each enemy sprite will be created here in SetUp() and will use the public Ghost class' parameters or settings.
            // For the initial test version of Snaccident Dog (January 2025), I will use the rainbow assortment of placeholder sprites.
            // If the initial test works well, when I choose to create version 1 later, I will swap out the placeholder sprites with the final enemy sprites and repeat this replacement process for all other placeholder sprites.

            enemyOne = new Ghost(this, Properties.Resources.Purple_violet_indigo_test_sprite_06_January_2025, 97, 100);
            enemies.Add(enemyOne);

            enemyTwo = new Ghost(this, Properties.Resources.Green_test_sprite_06_January_2025, 847, 100);
            
            // The second number representing the y-axis or vertical (upwards and downwards) space stays the same for two sprites at a time. This ensures each enemy sprite appears in their own corner and appears almost parallel (side by side but never meeting?) to the two other enemy sprites on the x- and y-axis, respectively.
            enemies.Add(enemyTwo);

            enemyThree = new Ghost(this, Properties.Resources.Orange_test_sprite_06_January_2025, 97, 640);
            enemies.Add(enemyThree);

            enemyFour = new Ghost(this, Properties.Resources.Yellow_test_sprite_06_January_2025, 847, 640);
            enemies.Add(enemyFour);
        }

        private void PlayerMovements()
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 19:54 then 32:32

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from SetUp() to CheckBoundaries().

            /* 
             * The PlayerMovements() function determines which of the arrow keys on the player's keyboard moves up, down, left, and right, respectively.
             *
             * The code below may look slightly different to the code I wrote for the keystroke function in Nathan's Snake Game.
             */

            // This code tells the game what happens when the arrow keys are pressed or held down in terms of speed.
            
            // But wait! There is more. Open the GameTimerEvent() function...

            if (goLeft) // Directions defined in one of the bool tools.
            {
                dogSprite.Left -= speed; // In my own words, dogSprite.Left measures and identifies the distance between the left-hand-side of the dog sprite and the left edge of the Windows Form.
            }

            if (goRight)
            {
                dogSprite.Left += speed;
            }

            if (goUp)
            {
                dogSprite.Top -= speed; // Likewise, dogSprite.Top measures and identifies the distance between the top side of the dog sprite and the top edge of the Windows Form.
            }

            if (goDown)
            {
                dogSprite.Top += speed; // For opposite directions like goUp and goDown, the same Top property is used and the plus or minus symbol changes to determine the direction. I could use dogSprite.Bottom which possibly exists but I will follow the tutorial video for now.
            }



            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 36:09

            /* 
             * More confusing and scary code for PlayerMovements().
             * 
             * This time, I will add code that will make the dog sprite reappear at the opposite edge to the edge where it ran past and disappears.
             */

            // DISAPPEARS ON LEFT EDGE THEN REAPPEARS ON RIGHT EDGE.
            if (dogSprite.Left < -60) // The bigger the number, the farther or further away the dog sprite runs off screen. I wanted the dog sprite to fully disappear off on the left edge and then gradually reappear from the right edge, making the appearance transition smoother which is what I wanted.
            {
                dogSprite.Left = this.ClientSize.Width - dogSprite.Width + 60; // Added my own code which was plus 60.

                // Plus 60 makes the dog sprite reappear from the right edge as if it was reappearing from a long way back which is what I wanted. ... As it turns out, plus sixty makes the code for the right side weird and makes the dog sprite loop on itself. It was sort of entertaining seeing it bob sideways. ... Never mind, I could add plus sixty back in. All worked out in the end.
            }

            // OK. Switching the values for the right direction is not so quick and simple.
            //if (dogSprite.Left > +60)
            //{
            //    dogSprite.Left = this.ClientSize.Width + dogSprite.Width + 60;
            //}

            // Messing around with the code~
            //if (dogSprite.Left < 60)
            //{
            //    dogSprite.Left = this.ClientSize.Width + dogSprite.Width - 60;
            //}



            // DISAPPEARS ON RIGHT EDGE THEN REAPPEARS ON LEFT EDGE.
            if (dogSprite.Left + dogSprite.Width > this.ClientSize.Width + 60)
            {
                dogSprite.Left = -60;
            }

            // If I change .Left to .Top...
            // It still works for goUp. I needed to adjust the numbers and having looked at the relevant code in the video tutorial which changed .Width to .Height which I did not do, surprisingly this code with .Width still works for goUp.
            //if (dogSprite.Top < -60)
            //{
            //    dogSprite.Top = this.ClientSize.Width - dogSprite.Width + -20;
            //}



            // DISAPPEARS ON TOP EDGE THEN REAPPEARS ON BOTTOM EDGE.
            if (dogSprite.Top < -60)
            {
                dogSprite.Top = this.ClientSize.Height - dogSprite.Height + 60; // Changing .Width to .Height as per tutorial video makes the dog sprite reappear from the bottom edge faster. This also works.
            }



            // DISAPPEARS ON BOTTOM EDGE THEN REAPPEARS ON TOP EDGE.
            if (dogSprite.Top + dogSprite.Width > this.ClientSize.Height + 60)
            {
                dogSprite.Top = -60;
            }
        }

        private void ShowFoodAgain()
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 19:54*

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from SetUp() to CheckBoundaries().

            /* 
             * The ShowFoodAgain() function displays all of the food sprites at the end of a game where the dog sprite has eaten all of the food sprites and may allow the player controlling the dog sprite to replay the game.
             */



            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 46:35

            // The FOREACH loop looks at every boundary shape and makes them visible again. This function will be added below the functions added to the GameTimerEvent() function so far.

            foreach (PictureBox food in dogTreats)
            {
                food.Visible = true;
                
                //if (food.Visible = false) // My alternate solution which failed.
                //{
                //    food.Visible = true;
                //}
            }
        }

        private void CheckBoundaries(PictureBox dogSprite, PictureBox wall)
            {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 19:54*

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from SetUp() to CheckBoundaries().

            /* 
             * The CheckBoundaries() function checks the interaction between the dog sprite and the walls or boundary shapes.
             * 
             * The tutorial video shows how to code a simple Pac-Man game in C# and shows how to make the Pac-Man sprite stop at the wall shapes. This is what I intend to do as well in my Snaccident Dog game.
             */



            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 39:40

            /* 
             * I have added and tested the four IF statements or formulas below for functionality beforehand.
             * 
             * They all work!
             */

            // THE DOG SPRITE STOPS AT THE RIGHT OF THE BOUNDARY SHAPE
            if (dogSprite.Bounds.IntersectsWith(wall.Bounds))
            {
                if (goLeft)
                {
                    noLeft = true; // Activate noLeft! I think I get this now; the dog sprite cannot go any further left.
                    goLeft = false; // The ability to move left also turns off.

                    dogSprite.Left = wall.Right + 2; // The tutorial video said this line of code would make the Pac-Man sprite meet the wall shapes but it did not do that. ... Now this function has been added to the GameTimerEvent() function, this probably works.

                    // Plus two creates a gap between the side of the dog sprite that meets the side of the boundary shape.
                }



                // THE DOG SPRITE STOPS AT THE LEFT OF THE BOUNDARY SHAPE
                if (goRight)
                {
                    noRight = true;
                    goRight = false;

                    dogSprite.Left = wall.Left - dogSprite.Width - 2;
                }



                // THE DOG SPRITE STOPS BELOW THE BOUNDARY SHAPE
                if (goUp)
                {
                    noUp = true;
                    goUp = false;

                    dogSprite.Top = wall.Bottom + 2;
                }



                // THE DOG SPRITE STOPS ABOVE THE BOUNDARY SHAPE
                if (goDown)
                {
                    noDown = true;
                    goDown = false;

                    dogSprite.Top = wall.Top - dogSprite.Height - 2;
                }
            }
        }

        private void EatFood(PictureBox dogSprite, PictureBox food)
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 22:22*

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from EatFood() to GameOver().

            /* 
             * The EatFood() function checks the interaction between the dog sprite and the food sprites.
             * 
             * When the dog sprite meets a food sprite, the food sprite should disappear and increment or increase the player's score by one.
             */



            // Added on Tuesday, 7th January 2025.
            // Timestamp in the tutorial video on YouTube: 44:40

            // I typed up similar code to the code I typed up in the CheckBoundaries() function and changed the IF formula inside the first IF formula.
            // I kind of understood what this will do.

            if (dogSprite.Bounds.IntersectsWith(food.Bounds))
            {
                if (food.Visible)
                {
                    food.Visible = false;
                    score ++; // Updated and added my own code on 8th January 2025. The ShowFoodAgain() function was still failing to launch when the dog sprite ate all of the food sprites and so I decided to try to this issue again.
                              
                    // Now the game shows a game over message at the end of every game and the message will show how many food sprites were eaten, I slowly realised that the score stopped increasing after one.
                              
                    // Then I replaced the original code which was 'score =+ 1' with an alternate line of code which is 'score ++;' and tested the game again. Thanks to my quick wit, the score continuously increases and when the game ends because the dog sprite ran into an enemy sprite, the game over message now shows the correct score with the correct number of dog treats eaten.

                    // Also, I wondered if this change in the code would make ShowFoodAgain() work when the dog sprite eats all of the food sprites and good news: It worked! I was glad and relieved! Hhhhhhhhhh~
                }
            }
        }

        private void EnemyAttack(Ghost g, PictureBox dogSprite, PictureBox enemy)
        {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 22:22*

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from EatFood() to GameOver().

            /* 
             * The EnemyAttack() function checks the interaction between the dog sprite and the enemy sprites.
             * 
             * When the dog sprite meets an enemy sprite, the game will end. At some point in the near future, I may add a replay game function that will display at the end of every game.
             */



            // Added on Wednesday, 8th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:22:33

            // When I saw this line of code in the tutorial video, I immediately knew what to expect to do because this line of code appeared earlier in the tutorial video.

            if (dogSprite.Bounds.IntersectsWith(enemy.Bounds))
            {
                // If this works in the game, this will have been fun to do!
                GameOver("Oh, no! Good try though. Your dog ate " +  score + " dog treats. Better luck next time.");

                // Call up the public function called ChangeDirection() in the Ghost class file.
                g.ChangeDirection();
            }
        }

        private void GameOver(string message)
            {
            // Added on Monday, 6th January 2025.
            // Timestamp in the tutorial video on YouTube: 22:22*

            // The asterisk * indicates the timestamp above applies to some of the next few functions. The timestamp applies to all functions from EatFood() to GameOver().

            /* 
             * The GameOver() function stops the game and may show the player's score as well as the option to replay the game.
             * 
             * As with the PlayerMovements() function, the code I type up for this function may be slightly different to the code I typed up for a similar function to this function in Nathan's Snake Game.
             */



            // Added on Wednesday, 8th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:20:14

            // The tutorial video showed coding for this function first.

            // Bring back the panel which will appear at game start-up.
            //panel1.Enabled = true;
            //panel1.Visible = true;

            // Added my own code on 8th January 2025. I wanted the game over message to appear outside of the game title panel and so this code below may be needed and hopefully it shows up only at the end of a game...
            gameOverMessage.Enabled = true;
            gameOverMessage.Visible = true;

            // Ah yes, this.
            gameTimer.Stop();

            // Added on 8th January 2025. An extra panel with a replay button was added and it only appears at the end of the first game and all other games.
            replayPanel.Enabled = true;
            replayPanel.Visible = true;

            ShowFoodAgain(); // The feature that does not work haha

            // This line of code resets the position of the dog sprite to the starting position. I may not want this though.
            dogSprite.Location = new Point(473, 367);

            /*
             * Adding lblInfo.Text which the guy in the tutorial video was going to use to display a custom message at the end of the game did not work for me. Then I wondered if I needed to add an extra label or something to the game board and watched a much earlier section of the tutorial video to see if the guy added something called lblInfo and he did, I think.
             * 
             * So I decided to create a copy of the instructions label, named it 'gameoverMessage', deleted the text, and then updated lblInfo with gameOverMessage. Now it works!
             * 
             * I still have no idea how the message will become customisable (10:02am).
             */

            gameOverMessage.Text = message;
            }      


    }
}
