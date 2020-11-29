using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussinaGame_HarmanGarcha
{
    public partial class Form1 : Form
    {
        Random obj = new Random();
        int lop = 0, countr = 0, countr2 = 0;
        customeFunctions instance = new customeFunctions();
        public Form1()
        {
            InitializeComponent();
            lop = obj.Next(1, 6);
            loadByHarman.Enabled = false;
            spinByHarman.Enabled = false;
            shootByHarman.Enabled = false;
            shootAwayByHarman.Enabled = false;
        }

        private void startByHarman_Click(object sender, EventArgs e)
        {
            instance.ongame(pictureBox1);
            startByHarman.Enabled = false;
            loadByHarman.Enabled = true;
        }
        public void generateNo()
        {
            lop = obj.Next(1, 3);
        }
        // load button for loading the gun 
        private void loadByHarman_Click(object sender, EventArgs e)
        {
            instance.loadgame(pictureBox1);
            loadByHarman.Enabled = false;
            spinByHarman.Enabled = true;
        }
        // spin button is changing the picture and enabling and disabling the next and previous buttons
        private void spinByHarman_Click(object sender, EventArgs e)
        {
            instance.spingame(pictureBox1);

            spinByHarman.Enabled = false;
            shootByHarman.Enabled = true;
            shootAwayByHarman.Enabled = true;
        }
        // for shooting purpose below code is written with help of countr variable 
        private void shootByHarman_Click(object sender, EventArgs e)
        {
            instance.shootgame(pictureBox1);
            countr++;

            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(RussinaGame_HarmanGarcha.Properties.Resources.fire);
            obj.Play();
            if (lop == countr)
            {
                MessageBox.Show("Shoot Sucess");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Alive Still  ");
            }

            // after 4 times button is disabled
            if (countr == 4)
            {
                MessageBox.Show("Over Now ");
                shootByHarman.Enabled = false;
            }

            if (countr == 4 && countr2 == 2)
            {
                Application.Restart();
            }
        }

        private void shootAwayByHarman_Click(object sender, EventArgs e)
        {
            instance.shootawaygame(pictureBox1);
            countr2++;
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(RussinaGame_HarmanGarcha.Properties.Resources.fire);
            obj.Play();
            MessageBox.Show("Shoot Awayed");

            if (countr2 == 2)
            {
                shootAwayByHarman.Enabled = false;


            }


            if (countr == 4 && countr2 == 2)
            {
                Application.Restart();
            }

        }

        private void reloadByHarman_Click(object sender, EventArgs e)
        {
            reloadByHarman.Enabled = false;
            startByHarman.Enabled = true;
        }
    }
}
