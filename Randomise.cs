using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaccident_Dog_attempt_one_06_January_2025
{
    internal class Randomise
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Randomise()
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

            //if (change > 0)
            //{
            //    change--;
            //}



            //// However, when the enemy sprites have closed in on the dog sprite, the enemy sprites will change direction randomly and move away from the dog sprite.
            //else
            //{
            //    change = random.Next(50, 100);
            //    direction = directions[random.Next(directions.Length)];
            //}

            //direction = directions[random.Next(directions.Length)];

            X = 0;
            Y = 0;
        }
    }
}
