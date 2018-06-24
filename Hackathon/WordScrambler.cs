using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hackathon
{
    public partial class WordScrambler : Form
    {
        //global variables
        string Temp;
        int place;
        int letternumber;
        ArrayList Letterlist = new ArrayList();
        int score = 0;
        //static string[] hsc =  File.ReadAllLines(Application.StartupPath + "\\HIGHSCORE.txt") ;
        // int highscore = Convert.ToInt32(hsc[0]);
        int highscore = int.Parse(File.ReadAllText(Application.StartupPath + "\\HIGHSCORE.txt"));
        public WordScrambler()
        {
            InitializeComponent();
            Points.Text = "SCORE: " + score.ToString();
            method();
        }

        private void fake_Click(object sender, EventArgs e)
        {
            score = 0;
            Points.Text = "SCORE: " + score.ToString();
            method();
        }

        private void Check_Click(object sender, EventArgs e)
        {

            Result.ResetText();

            string answer = Answer.Text.ToLower();
            if (answer == Temp)
            {

                Result.Text = "Correct";
                score++;
            }
            else
            {
                Result.Text = "Incorrect. The Correct answer is: " + Temp;
                score = 0;
            }

            if (score > highscore)
            {
                highscore = score;
                File.WriteAllText(Application.StartupPath + "\\HIGHSCORE.txt", highscore.ToString());
            }

            High.Text = "HIGHSCORE: " + highscore.ToString();
            Points.Text = "SCORE: " + score.ToString();

            method();
            Answer.Text = "";
        }

        private void method()
        {
            Scramble.ResetText();
            Letterlist.Clear();


            ArrayList list = new ArrayList();
            list.Clear();
            string[] Word = File.ReadAllLines(Application.StartupPath + "\\ListOfWords.txt");

            List<string> Words = new List<string>();

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] != "")
                {
                    Words.Add(Word[i]);

                }
            }

            Random number = new Random();
            place = number.Next(0, Words.Count);
            Temp = Words[place].ToLower();

            for (int i = 0; i < (Temp.Length); i++)
            {
                list.Add(Temp.Substring(i, 1));
            }
            int g = list.Count;
            while (g > 0)
            {
                letternumber = number.Next(0, list.Count - 1);
                Letterlist.Add(list[letternumber]);
                list.RemoveAt(letternumber);
                g--;
            }
            for (int i = 0; i < Letterlist.Count; i++)
            {
                Scramble.Text += Letterlist[i];
            }
        }
    }
}