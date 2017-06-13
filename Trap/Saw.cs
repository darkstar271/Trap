using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trap
{
    class Saw
    {



        // sets Block to a count of 2
        public int Block { get; set; } = 2;

        // sets a -1 countdown for Block
        public int BlockCountDown()
        {
            return Block - 1;
        }

        // setup a random number generator, called myRandom
        Random myRandom = new Random();

        // holds random number from RndGenerator
        public int Rnd { get; set; }

        public int UserSpins { get; set; } = 7;

        /// <summary>
        /// Creates a Random number
        /// </summary>
        /// <returns></returns>
        public int RndGenerator()
        {
            return myRandom.Next(1, 7);

        }
        /// <summary>
        /// method to countdown the user spins, which start at 6.
        /// </summary>
        /// <returns></returns>
        public int UserSpinsCountDown()
        {
            return UserSpins - 1;

        }
        //two methods to reset game values back to default
        public void BlockReset()
        {Block = 2;}
        public void UserSpinsReset()
        {UserSpins = 7;}

        public void AllReset()
        {
            Block = 2;
            UserSpins = 7;
           
            
        }

    }
}
