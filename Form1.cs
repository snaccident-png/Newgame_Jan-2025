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

using System.Threading; // Added on Sunday, 12th January 2025.

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



        // Added on Wednesday, 5th March 2025.
        // Oh good! The Chocolate class is working again! For unknown reasons, the Chocolate class became weird. But then I opened this project however long ago earlier this evening and, as if by magic, the reference to the class started working again.
        Chocolate chocolateBar;

        // My attempted remedy for fixing the following issue: Argument 1: cannot convert from 'Snaccident_Dog_attempt_one_06_January_2025.Chocolate' to 'System.Windows.Forms.PictureBox'
        List<Chocolate> choco = new List<Chocolate>();



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
                dogSprite.Image = Properties.Resources.Dog_sprite_FACE_ONLY_left_side_13_January_2025;
            }

            if (e.KeyCode == Keys.Right && !noRight)
            {
                goLeft = goDown = goUp = false;
                noLeft = noDown = noUp = false;

                goRight = true;
                dogSprite.Image = Properties.Resources.Dog_sprite_FACE_ONLY_right_side_13_January_2025;
            }

            if (e.KeyCode == Keys.Up && !noUp)
            {
                goRight = goDown = goLeft = false;
                noRight = noDown = noLeft = false;

                goUp = true;
                dogSprite.Image = Properties.Resources.Dog_sprite_FACE_ONLY_back_side_13_January_2025;
            }

            if (e.KeyCode == Keys.Down && !noDown)
            {
                goRight = goLeft = goUp = false;
                noRight = noLeft = noUp = false;

                goDown = true;
                dogSprite.Image = Properties.Resources.Dog_sprite_face_12_January_2025;
            }
        }

        private void ReplayGame(object sender, EventArgs e)
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

            //dogSprite.Image = Properties.Resources.Red_test_sprite_06_January_2025; // Added on 8th January 2025. This code will reset the dog sprite to its starting appearance.

            dogSprite.Image = Properties.Resources.Dog_sprite_face_12_January_2025;


            dogSprite.Size = new Size(55, 55);
            dogSprite.Location = new Point(484, 473);
            
            
            
            // Added on 14th January 2025. This weirdly fixed the bug or issue. If I tried this fix beforehand on 10th January then I must have fudged something or did something wrong.


            // The enemy sprite code will be added in the near future.



            // Added on Wednesday, 8th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:18:35


            // This code resets the position of the enemy sprites to the starting position when the game ends.
            // The tutorial video said new Point is quite convenient for setting new locations for things.

            // Updated on Thursday, 23rd January 2025.
            enemyOne.img.Location = new Point(95 /*97*/, 100);
            enemyTwo.img.Location = new Point(867 /*847*/, 100);
            enemyThree.img.Location = new Point(95, 840 /*97, 640*/);
            enemyFour.img.Location = new Point(867, 840 /*847, 640*/);



            // Added on Wednesday, 5th March 2025.
            chocolateBar.img.Location = new Point(95, 100);



            // Finally, the game timer starts and the aforementioned functions finally become functional!
            gameTimer.Start();
        }

        private void OpenInstructions(object sender, EventArgs e)
        {
            gameInstructions.ForeColor = Color.Yellow;
            instructionsVisual.Show();
        }

        private void CloseInstructions(object sender, EventArgs e)
        {
            gameInstructions.ForeColor = Color.White;
            instructionsVisual.Hide();
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
             * I cannot believe how dependent the KeyIsPressed(), PlayerMovements(), and GameTimerEvent() functions are on this function.
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

            //dogSprite.Image = Properties.Resources.Red_test_sprite_06_January_2025; // Added on 8th January 2025. This code will reset the dog sprite to its starting appearance.

            dogSprite.Image = Properties.Resources.Dog_sprite_face_12_January_2025;

            
            //dogSprite.Size = new Size(55, 55);
            //// Added on 10th January 2025.


            // The enemy sprite code will be added in the near future.

            // Added on Wednesday, 8th January 2025.
            // Timestamp in the tutorial video on YouTube: 01:18:35


            // This code resets the position of the enemy sprites to the starting position when the game ends.
            // The tutorial video said new Point is quite convenient for setting new locations for things.
            //enemyOne.img.Location = new Point(97, 100);
            //    enemyTwo.img.Location = new Point(847, 100);
            //    enemyThree.img.Location = new Point(97, 640);
            //    enemyFour.img.Location = new Point(847, 640);

            // Updated on Thursday, 23rd January 2025.
            enemyOne.img.Location = new Point(95 /*97*/, 100);
            enemyTwo.img.Location = new Point(867 /*847*/, 100);
            enemyThree.img.Location = new Point(95, 840 /*97, 640*/);
            enemyFour.img.Location = new Point(867, 840 /*847, 640*/);

            //// Added and commented out on Thursday, 23rd January 2025.
            //label4.ForeColor = Color.FromArgb(0,0,0,0);



            // Added on Wednesday, 5th March 2025.
            chocolateBar.img.Location = new Point(95, 100);



            // Finally, the game timer starts and the aforementioned functions finally become functional!
            gameTimer.Start();
        }

        private void OpenInformation(object sender, EventArgs e)
        {
            // Added on Friday, 24th January 2025.
            
            /*
             * Woohoo! I succeeded in making the game information label change colour and display the game information. This works when a player moves their mouse to the label and hovers over it.
             */
            
            label5.ForeColor = Color.IndianRed;
            gameInfoMessage.Show();
            //GameInformation("Snaccident Dog:" +
            //    Environment.NewLine + 
            //    "Try to get your dog to eat all the dog treats before they get caught." +
            //    Environment.NewLine +
            //    Environment.NewLine +
            //    "Game created by Nathan Ng (Nathan Tries To Make Games)" +
            //    Environment.NewLine +
            //    "Feel free to view and download the code for Snaccident Dog on GitHub (snaccident-png)." +
            //    Environment.NewLine +
            //    Environment.NewLine +
            //    "Many thanks for playing." + 
            //    Environment.NewLine +
            //    "Nathan Tries To Make Games | 2025");

            GameInformation("Snaccident Dog - A hopefully simple and easy-to-play game which may be a little bit stressful at times. Good luck!" +
                Environment.NewLine +
                Environment.NewLine +
                "Special thanks to Moo ICT for inspiring me to make this game." +
                Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                "Nathan Tries To Make Games | 2024 - 2025");
        }

        private void CloseInformation(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;

            gameInfoMessage.Hide();
        }

        //private void ReturnToStartPage(object sender, EventArgs e)
        //{
        //    //gameTimer.Stop();

        //    //panel1.Enabled = true;
        //    //panel1.Visible = true;

        //    //replayPanel.Enabled = false;
        //    //replayPanel.Visible = false;

        //    //ShowFoodAgain();



        //    // This sort of worked but after clicking on the start page button and then clicking on the start button, the game timer seems to cut off earlier and earlier and one dog treat is treated as two treats, three treats, four treats and so on in every other game afterwards.

        //    // I tried to find a solution on the internet and I was aware my wording in my questions may have sounded like my questions wanted a different response.

        //    // I watched one video on YouTube which showed how to open a new form from one form but that is not my aim. I would like to return to the startup screen for Snaccident Dog from the replay panel.

        //    // Maybe my aim is just impossible to achieve?

        //    //gameTimer.Stop();
        //    //this.Controls.Clear();

        //    //this.InitializeComponent();
        //    //this.SetUp();



        //    // This line of code does nothing.
        //    //Form1 form = new Form1();



        //    /*
        //     * OK, well, this also worked.
        //     * 
        //     * With these lines of code below, clicking on the start page button will open a new window showing Snaccident Dog from the start page again. During gameplay, the game timer seems to be unproblematic (the game timer runs for as long as gameplay is happening, woohoo!) but I have to close the current window then close all of the other windows.
        //     * 
        //     * Good effort, Nathan, but maybe you should stop trying to achieve the impossible.
        //     */
        //    //this.Controls.Clear();

        //    //Form1 form1 = new Form1();
        //    //form1.Show();

        //}

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
                // this.Text = "Food eaten: " + score; // Added on 8th January 2025. The current amount of food eaten by the dog sprite now appears on the top-left corner of the application window!  
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

                dogSprite.Image = Properties.Resources.dogSprite_with_faster_animation; // Added on 10th January 2025.

                dogSprite.Size = new Size(300, 300);
                dogSprite.Location = new Point(367, 305);

                //pictureBox73.Enabled = true;
                //pictureBox73.Visible = true;



                // Added on Saturday, 18th January 2025.
                
                /* 
                 * I fixed the dog sprite change issue that happens when I press on
                 * the arrow keys partially. Now, at the end of the first successful
                 * game, the arrow keys do nothing and the enlarged dog sprite stays
                 * on screen.
                 * 
                 * Unfortunately, I was unable to fix this issue at the end of the first unsuccessful game. I deleted the two lines of code below from the ELSE statement already but when the code was in the statement and when I started the game and tested the code, the dog sprite became unplayable which brought back dreadful feelings I felt during development on Nathan's Snake Game, version 3.
                 * 
                 * I think for the first unsuccessful game I may leave the bug in and treat it as a fun, little thing players can do like they can on a webpage window on Google Chrome when the internet is offline.
                 */
                goLeft = goRight = goDown = goUp = false;
                noLeft = noRight = noDown = noUp = true;
            }
            else
            {
                gameOverMessage.ForeColor = Color.Red; // Added my own code on 8th January 2025. This ELSE statement changes back the colour of the game over message to red which is the case when the dog sprite runs into an enemy sprite and causes the game to end.

                //dogSprite.Image = Properties.Resources.dogSprite_09_Jan_2025;
                //dogSprite.Size = new Size(100, 100);

                // Added on 10th January 2025.

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



            // Added on Wednesday, 5th March 2025.
            // This did not work.
            foreach (Chocolate chocolate in choco)
            {
                ChocolateToxic(chocolate, dogSprite);
            }



        }

        // Added on Thursday, 6th March 2025.
        
        /*
         * I clicked on a suggested solution provided by Visual Studio for solving the 'cannot convert' issue I 
         * struggling to solve and it seemed to work. The issue was eliminated, I was able to launch the game
         * and I got past the splash screen and saw the homepage. However, once I clicked on Start, the game
         * crashed and Visual Studio told me the NotImplementedException class thing was not implemented.
         * 
         * I may post this issue to GitHub and see if any strangers can help.
         */
        
        //private void ChocolateToxic(Chocolate chocolate, PictureBox dogSprite)
        //{
        //    throw new NotImplementedException();
        //}

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

            // Updated on 10-January-2025. I replaced the ... No idea as to what I wanted to record here.



            // However, ... today is Thursday, 23rd January 2025 and earlier this morning I updated the X and Y coordinates for the enemy sprites following the re-sizing event of the 23rd of January 2025.

            // This afternoon, I want to figure out why the bottom two enemy sprites start at their new positions below then immediately appear at what may be their previous starting positions which are higher.

            // I think I found where the issue is and how to fix it. I am also aware that I have spent the past six minutes typing on the screen so I will get to bug fixing or whatever I will do now and show rather than tell.



            enemyOne = new Ghost(this, Properties.Resources.Dachshund_sprite_22_January_2025 
                /*Mum_face_sprite_09_January_2025*/
                /*Purple_violet_indigo_test_sprite_06_January_2025*/, 95, 100);
            enemies.Add(enemyOne);

            enemyTwo = new Ghost(this, Properties.Resources.Black_Labrador_sprite_22_January_2025
                /*Dad_face_sprite_09_January_2025*/
                /*Green_test_sprite_06_January_2025*/, 867, 100);
            enemies.Add(enemyTwo);

            enemyThree = new Ghost(this, Properties.Resources.Rottweiler_sprite_22_January_2025
                /*Brother_face_sprite_09_January_2025*/
                /*Orange_test_sprite_06_January_2025*/, 95, 840);
            enemies.Add(enemyThree);

            enemyFour = new Ghost(this, Properties.Resources.Yorkshire_Terrier_sprite_22_January_2025
                /*Other_brother_face_sprite_09_January_2025*/
                /*Yellow_test_sprite_06_January_2025*/, 867, 840);
            enemies.Add(enemyFour);

            // The second number representing the y-axis or vertical (upwards and downwards) space stays the same for two sprites at a time. This ensures each enemy sprite appears in their own corner and appears almost parallel (side by side but never meeting?) to the two other enemy sprites on the x- and y-axis, respectively.

            // Added on Friday, 10th January 2025. I successfully made the panel that shows up on startup semi-transparent. If I tried doing this before and it failed then I have found the solution this evening.

            panel1.BackColor = Color.FromArgb(50,0,0,0);



            // Added on Wednesday, 5th March 2025.
            chocolateBar = new Chocolate(this, Properties.Resources.Blue_test_sprite_06_January_2025, 95, 100);

            // Added on Wednesday, 5th March 2025.
             choco.Add(chocolateBar);
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
                dogSprite.Top = this.ClientSize.Height - dogSprite.Height + 30; // Changing .Width to .Height as per tutorial video makes the dog sprite reappear from the bottom edge faster. This also works.
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
                // Added on Sunday, 12th January 2025.

                /*
                 * I wondered if I could introduce a delay in time between an enemy sprite meeting the dog sprite and the game over elements showing up.
                 * 
                 * I tried to come up with my own solution first which used the gameTimer feature but I decided to move on. None of the gameTimer attributes or properties looked useful so I moved on and tried to find a tutorial video on YouTube again to help me achieve my goal.
                 */
                // gameTimer.

                /*
                 * What about this? (7:59pm)
                 * ...
                 * Wow! Oh my gosh, it worked!
                 * 
                 * The delay was a bit too long so I will reduce three thousand to a lower number and test the game until the delay feels or looks right.
                 * 
                 * Six hundred or one thousand works. I kind of like the comedic timin of six hundred.
                 * 
                 * OK, now I know the System.Threading thing and Thread.Sleep() are the things I need to introduce a delay, I have just now thought about showing an alternate GIF animation which shows the dog sprite having been caught by an enemy sprite in grayscale colours. 
                 */

                dogSprite.Image = Properties.Resources.Dog_sprite_FACE_ONLY_front_side_caught_by_enemy_state_12_January_2025;

                Thread.Sleep(/*3000*/ 600 /*1000*/);



                // If this works in the game, this will have been fun to do!
                GameOver("Oh, no! Good try though. Your dog ate " + score + " dog treats. Better luck next time.");

                // Call up the public function called ChangeDirection() in the Ghost class file.
                g.ChangeDirection();
            }
        }

        private void ChocolateToxic(PictureBox dogSprite, PictureBox Choco)
        {
            // Added on Wednesday, 5th March 2025.

            /* 
             * The ChocolateToxic() function checks the interaction between the dog sprite and the chocolate bar sprite.
             * 
             * When the dog sprite meets the chocolate bar sprite, the game will end. The replay game function that will display at the end of every game should be here as this function is a modified enemy sprite function.
             */

            if (dogSprite.Bounds.IntersectsWith(Choco.Bounds))
            {
                dogSprite.Image = Properties.Resources.Dog_sprite_FACE_ONLY_front_side_caught_by_enemy_state_12_January_2025;

                Thread.Sleep(/*3000*/ 600 /*1000*/);



                // If this works in the game, this will have been fun to do!
                GameOver("Oh, no! Your dog ate the chocolate! Your dog ate " + score + " dog treats. Better luck next time.");
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



            // Added on Friday, 10th January 2025. Now this code works, I will have applied this code to the replay game panel.

            // Commented out on Monday, 20th January 2025. This line of code made the background colour of the replay panel take on a different colour, regardless of the first value having zero or one hundred.

            //replayPanel.BackColor = Color.FromArgb(0, 0, 0, 0);



            // Ahhhhh why not alter the background transparency of the game over panel.

            // Commented out on Monday, 20th January 2025. The same goes for this line of code affecting background colour transparency

            // gameOverMessage.BackColor = Color.FromArgb(0, 255, 0, 0);

            ShowFoodAgain(); // The feature that does not work haha

            // This line of code resets the position of the dog sprite to the starting position. I may not want this though.
            // Updated on 10th January 2025. As it turns out, this Location command is necessary because with it off, the dog sprite is... (13th January edit) ... appears somewhere weird.
            
            dogSprite.Location = new Point(484, 473);

            /*
             * Adding lblInfo.Text which the guy in the tutorial video was going to use to display a custom message at the end of the game did not work for me. Then I wondered if I needed to add an extra label or something to the game board and watched a much earlier section of the tutorial video to see if the guy added something called lblInfo and he did, I think.
             * 
             * So I decided to create a copy of the instructions label, named it 'gameoverMessage', deleted the text, and then updated lblInfo with gameOverMessage. Now it works!
             * 
             * I still have no idea how the message will become customisable (10:02am).
             */

            gameOverMessage.Text = message;
            }      

        private void GameInformation(string message)
        {
            // Added on Friday, 24th January 2025.

            // I wanted to give credit to the YouTube channel which uploaded a tutorial video which helped me create Snaccident Dog so here I am about to create a brand new function to achieve my aim. Even if this fails, at least I tried.

            gameInfoMessage.Enabled = true;
            gameInfoMessage.Visible = true;

            gameInfoMessage.Text = message;
        }

    }
}
