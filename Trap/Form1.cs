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







{
    public partial class Form1 : Form
    {
        //set's up booling logic, true false
        private bool ifBlock = false;
        // set's up a copy of the "saw" class and gives it the name "mysay"
        Saw mySaw = new Saw();
        // set's up a copy of the "SpeechSynthesizer" and gives it the name "speaker"
        SpeechSynthesizer speaker = new SpeechSynthesizer();


        public Form1()
        {
            InitializeComponent();
        }

        // press play game starts, gives info and starts random Gen

        private void btnPlay_Click(object sender, EventArgs e)

        {
            mySaw.Rnd = mySaw.RndGenerator();
            speaker.SpeakAsync("hello I want to play a game,the gun has one bullet, 2 chances to turn it away.");
        }

        //calls the methods to resets game variables
        private void btNewGame_Click(object sender, EventArgs e)
        {
            
            mySaw.AllReset();
            ButtonOn();
            this.Text = "";
        }


        /// <summary>
        /// This resets back to new game
        /// </summary>
        public void ButtonOn()
        {
            pic3.Visible = true;
            pictureBox1.Visible = false;
            btPlay.Enabled = true;
            btnOpen.Enabled = true;
            btnBlock.Enabled = true;
            txtBlock.Text = "";
            txtOpen.Text = "";
            mySaw.Rnd = mySaw.RndGenerator();

        }

        // checks is Userspins and Randoms number are the same
        private void btnOpen_Click(object sender, EventArgs e)
        // this block of code , checks to see if the user has any blocks left and if the user has the same number as the random number
        // if Block is equal, ("==" must be used), to zero your dead
        // mySaw.Block = 0 and user still has spins your dead
        // Visible is used to turn on or off the image in pictureboxs
        {

            pic3.Visible = true;
            pictureBox1.Visible = false;
            //plays sound from saw class
            mySaw.ClickSound();
            mySaw.UserSpins = mySaw.UserSpinsCountDown();
            if (mySaw.Block == 0 || (mySaw.Block == 0 && mySaw.UserSpins > 0))
            {
                SoundPlayer snPlayer = new SoundPlayer(Resources.blood_2);
                snPlayer.Play();
                MessageBox.Show("you're dead");
                ButtonOff();
                return;
                }
            
            if (mySaw.UserSpins == mySaw.Rnd)

            {
              
                SoundPlayer snPlayer = new SoundPlayer(Resources.Gun_Shot2);
                snPlayer.Play();
                MessageBox.Show("your dead cat");
                ButtonOff();
                return;
            }
            // this displays at top of winform, info
            this.Text = "UserSpins " + mySaw.UserSpins.ToString() + " Rnd Number " + mySaw.Rnd + " Blocked " + mySaw.Block;
            txtOpen.Text = mySaw.UserSpins.ToString();
            txtBlock.Text = mySaw.Block.ToString();
        }
        //turns off buttons
        public void ButtonOff()
        {
            btPlay.Enabled = false;
            btnOpen.Enabled = false;
            btnBlock.Enabled = false;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            mySaw.ClickSound();
            pic3.Visible = false;
            pictureBox1.Visible = true;
            // if statment ,you win plays sound and shows you win , on screen
            if (mySaw.UserSpins == mySaw.Rnd)

            {
               
                SoundPlayer snPlayer = new SoundPlayer(Resources.Cheering_3);
                snPlayer.Play();
                MessageBox.Show("you win");
                ButtonOff();
                return;
            }



            mySaw.WinOrLose();
            // this counts down both the Userspins and Block
            mySaw.Block = mySaw.BlockCountDown();
            //mySaw.UserSpins = mySaw.UserSpinsCountDown();
            ifBlock = true;
            //a "if'statment, checkes if there no blocks left and if so, plays sound and a message showing your dead, and turns off the buttons

            mySaw.UserSpins = mySaw.UserSpinsCountDown();
            if (mySaw.Block == 0 || (mySaw.Block == 0 && mySaw.UserSpins > 0))
            {
                SoundPlayer snPlayer = new SoundPlayer(Resources.blood_2);
                snPlayer.Play();
                MessageBox.Show("you're dead no more blocks");
                ButtonOff();
              return;

            }
            //shows counters on top of form
            this.Text = "UserSpins " + mySaw.UserSpins.ToString() + " Rnd Number " + mySaw.Rnd + " Blocked " + mySaw.Block;
            txtOpen.Text = mySaw.UserSpins.ToString();
            txtBlock.Text = mySaw.Block.ToString();
        }

        private void txtBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOpen_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
