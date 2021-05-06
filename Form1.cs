using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        SimpleGame G1 = new SimpleGame();// Defining the object (G1) of the Game Class
        private object videoplayer;// Function for playing sound
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {


            G1.Load(); //Calling Load function from Game Class
            Btn_load.Enabled = false; // Disabling Load button
            Btn_Spin.Enabled = true;// Enabling spin function
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;
            try
            {
                SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.load);
                player.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
            //  System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.load);
            //  player.Play();// for playing the sound for load buttonm
              Assembly mygame = Assembly.GetExecutingAssembly();
             Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.load1.gif");// Adding image in load function
            pictureBox1.Image = global::SimpleGame.Resource1.load1;
            //Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources._3");
            //Bitmap bmp = new Bitmap(myStream);
            //pictureBox1.Image = bmp;
        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.spin) ;
                player.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.spin);
            // player.Play();// For playing sound for spin button
            Assembly mygame = Assembly.GetExecutingAssembly();
            Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.spining.gif");// This is used to add image on spin function
            pictureBox1.Image = global::SimpleGame.Resource1.spining;
            G1.Spin(); //Calling Spin function from Game Class
            MessageBox.Show(G1.spinbullet.ToString());
            Btn_load.Enabled = false;// Disable the spin button
            Btn_Spin.Enabled = false;// Disable the spin button
            Btn_Shoot.Enabled = true;// Enabling shoot button
            Btn_ShootAway.Enabled = true;// Enabling shoot away function
        }

        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            G1.Shoot(); //Calling Shoot function from Game Class
            if (G1.lose == 1)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }

                //  System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                //  player.Play();// This sound will play on the click of shoot button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.shoot.gif");// This image will show on the click of shoot button
                pictureBox1.Image = global::SimpleGame.Resource1.shoot;
                MessageBox.Show("you loose the game");// This message will pop up after loosing the game
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;


            }
            else
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                //  System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                // player.Play();// This sound will play on the click of shoot button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.shoot.gif");// Image will show on shoot button
                pictureBox1.Image = global::SimpleGame.Resource1.shoot;
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = true;// Enabling shoot button
                Btn_ShootAway.Enabled = true;//Enabling shoot away button
            }
        }

        private void Btn_ShootAway_Click(object sender, EventArgs e)
        {
            G1.ShootAway(); //Calling Shoot Away function from Game Class

            if (G1.lose == 1)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                //  System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                //  player.Play();// This sound will play on the click of shoot away button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.shooting.gif");// Image will show on the click of shoot away button
                pictureBox1.Image = global::SimpleGame.Resource1.shooting;
                MessageBox.Show("you loose the game"); // This message will pop up after loosing the game
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;
                // Disabling all buttons after loosing the game


            }
            else if (G1.win == 1 && G1.shootawaybullet == 1)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                // System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                //  player.Play();
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.shooting.gif");
                pictureBox1.Image = global::SimpleGame.Resource1.shooting;
                MessageBox.Show("you won the game and Score is 100"); // This message will pop up after win the game
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;
                // Disabling all buttons after win the game

            }
            else if (G1.win == 1 && G1.shootawaybullet == 0)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                // System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                //   player.Play();
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.shooting.gif");
                pictureBox1.Image = global::SimpleGame.Resource1.shooting;
                MessageBox.Show("you won the game and Score is 50");
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;
                // Disabling all buttons after winning the game

            }
            else //
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(global::SimpleGame.Resource1.shoot1);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                //  System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                //   player.Play();
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resource1.shooting.gif");
                pictureBox1.Image = global::SimpleGame.Resource1.shooting;
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = true;
                Btn_ShootAway.Enabled = true;
            }



        }

        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();// This button will reload the game and we can play again


            // Btn_load.Enabled = true;
            // Btn_Spin.Enabled = false;
            // Btn_Shoot.Enabled = false;
            // Btn_ShootAway.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;
        }
    }
}
