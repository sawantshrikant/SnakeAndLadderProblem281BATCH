using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem281Batch
{
    public class Start
    {
        private int playerPosition;
        private Random random;

        public Start()
        {
            playerPosition = 0;
            random = new Random();
        }

        public void PlaySnakeAndLadder()
        {
            Console.WriteLine("Starting Snake and Ladder game...");
            Console.WriteLine("Your starting position is {0}.", playerPosition);
        }
    }
}
