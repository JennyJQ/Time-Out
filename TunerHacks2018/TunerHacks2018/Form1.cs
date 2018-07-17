using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Esri.ArcGISRuntime.Geometry;
//using Esri.ArcGISRuntime.Location;
//using Esri.ArcGISRuntime.Mapping;
//using Esri.ArcGISRuntime.UI;
using System.Linq;
using System.Windows;


namespace TunerHacks2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ChangeBGImage();
        }
        Random rd = new Random();
        int exp = 0;
        int meleeAttack = 1;
        int magic1Attack = 5;
        int magic2Attack = 10;
        int monsterAttack = 0;

        private Form2 mapForm;

        private void ChangeBGImage (Bitmap cameraImage)
        {
            //this.BackgroundImage = Bitmap //save camera image (need camera access permission & location permission)
        }

        private void AddGIFCharacter (int min, int max)
        {

            int resourceIndex = rd.Next(min, max);

            //enemyPictureBox.Image = Bitmap //(Properties.Resources.something);
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            attackButton.Visible = false;
            meleeButon.Visible = true;
            magic1Button.Visible = true;
            magic2Button.Visible = true;
            exp = rd.Next(5, 50);
            monsterHealthBar.Maximum = rd.Next(50, 101);
        }

        private void meleeButon_Click(object sender, EventArgs e)
        {
            if (monsterHealthBar.Value - meleeAttack >= 0)
            {
                monsterHealthBar.Value -= meleeAttack;
            }
            else
            {
                MessageBox.Show("You successfully killed the monster \nExp +" + exp);
                this.Close();
            }

            monsterAttack = rd.Next(0, 2);
            if (characterHealth.Value - monsterAttack >= 0)
            {
                characterHealth.Value -= monsterAttack;
            }
            else
            {
                characterHealth.Value = 0;
                MessageBox.Show("You died");
                this.Close();
            }

        }

        private void magic1Button_Click(object sender, EventArgs e)
        {
            if  (monsterHealthBar.Value - magic1Attack >= 0)
            {
                monsterHealthBar.Value -= magic1Attack;
            }
            else
            {
                MessageBox.Show("You successfully killed the monster \nExp +" + exp);
                this.Close();
            }

            monsterAttack = rd.Next(3, 8);
            if (characterHealth.Value - monsterAttack >= 0)
            {
                characterHealth.Value -= monsterAttack;
            }
            else
            {
                characterHealth.Value = 0;
                MessageBox.Show("You died");
                this.Close();
            }

        }

        private void magic2Button_Click(object sender, EventArgs e)
        {
            if (monsterHealthBar.Value - magic2Attack >= 0)
            {
                monsterHealthBar.Value -= magic2Attack;
            }
            else
            {

                MessageBox.Show("You successfully killed the monster \nExp +" + exp);
                this.Close();
            }

            monsterAttack = rd.Next(7, 13);
            if (characterHealth.Value - monsterAttack >= 0)
            {
                characterHealth.Value -= monsterAttack;
            }
            else
            {
                characterHealth.Value = 0;
                MessageBox.Show("You died");
                Close();
            }


        }

        private void fleeButton_Click(object sender, EventArgs e)
        {
            Form2 mapForm = new Form2();
            mapForm.Show();
            Close();
        }
    }
}
