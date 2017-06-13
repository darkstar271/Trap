using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Trap.Properties;


namespace Trap

//todo make a reset
//todo fix if userspins == mySaw.UserSpins != mySaw.Rnd
//todo make a better death
//todo Wins and lose keep score
//todo Newgame button Resets parameters, but not score

{
    public partial class Form1 : Form
    {
        private bool ifBlock = false;
        Saw mySaw = new Saw();
        SpeechSynthesizer speaker = new SpeechSynthesizer();


        public Form1()
        {
            InitializeComponent();
        }

        // press play game starts, gives info and starts random Gen

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mySaw.Rnd = mySaw.RndGenerator();
            speaker.SpeakAsync("hello I want to play a game,one of the tanks above you contain acid, 2 chances to escape your fate choose wisely.");



          //   myCarousel.RND = myCarousel.RNDGenerator();
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            // mySaw.BlockReset();
           // mySaw.UserSpinsReset();
            mySaw.AllReset();
            ButtonOn();
            this.Text = "";
        }


        /// <summary>
        /// This resets back to new game
        /// </summary>
        public void ButtonOn()
        {
            btPlay.Enabled = true;
            btnOpen.Enabled = true;
            btnBlock.Enabled = true;
            txtBlock.Text = "";
            txtOpen.Text = "";
            mySaw.Rnd = mySaw.RndGenerator();

        }

        // opens the tanks, and checks is Userspins and Randoms number are the same
        private void btnOpen_Click(object sender, EventArgs e)
            // this block of code , checks to see if the user has any blocks left and if the user has the same number as the random number
        {   // if Block is equal, ("==" must be used), to zero your dead
            // mySaw.Block = 0 and user still has spins your dead
            mySaw.UserSpins = mySaw.UserSpinsCountDown();
            if (mySaw.Block == 0 || (mySaw.Block == 0 && mySaw.UserSpins > 0))


            {
                SoundPlayer snPlayer = new SoundPlayer(Resources.blood_2);
                snPlayer.Play();

                MessageBox.Show("you're dead");

                ButtonOff();


                return;

            }
            //if (mySaw.UserSpins != mySaw.Rnd) return;
            if (mySaw.UserSpins == mySaw.Rnd)




            {
                pic3.Visible = true;
                MessageBox.Show("your dead");
                ButtonOff();
                return;
            }

            this.Text = "UserSpins " + mySaw.UserSpins.ToString() + " Rnd Number " + mySaw.Rnd + " Blocked " + mySaw.Block;
            txtOpen.Text = mySaw.UserSpins.ToString();
            txtBlock.Text = mySaw.Block.ToString();




            //SoundPlayer snPlayer = new SoundPlayer(Resources.blood_2);
            //snPlayer.Play();
            //
            // you have no more blocks and still have spins to go.
            //MessageBox.Show("Game Over");



        }

        public void ButtonOff()
        {
            btPlay.Enabled = false;
            btnOpen.Enabled = false;
            btnBlock.Enabled = false;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            // this counts down both the Userspins and Block
            mySaw.Block = mySaw.BlockCountDown();
            mySaw.UserSpins = mySaw.UserSpinsCountDown();
            ifBlock = true;
        }

        private void txtBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOpen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
