using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace Hackathon
{
    public partial class Form1 : Form
    {
        int minChar = 2;
        int breakChar = 1;

        GameForm gameForm = new GameForm();
        RPSForm rpsForm = new RPSForm();
        SpaceInvaders spaceForm = new SpaceInvaders();

        public Form1()
        {
            InitializeComponent();
            updateProcesses();
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();
            

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private void updateProcesses()
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    ProcessesListBox.Items.Add(process.MainWindowTitle);
                }
            }
            if (ProcessesListBox.Items.Contains("Timeout"))
                ProcessesListBox.Items.Remove("Timeout");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ProcessesListBox.Items.Clear();
            updateProcesses();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (ProcessesListBox.SelectedItem != null)
            {
                int minutes = (int)WorkNumericUpDown.Value;

                if (minutes < 10)
                    minChar = 1;
                else if (minutes > 10 && minutes < 99)
                    minChar = 2;
                else if (minutes > 99)
                    minChar = 3;

                if (startButton.Text.Contains("Start"))
                {
                    WorkTimer.Start();
                    SecondTimer.Start();
                    startButton.Text = "Stop Working";
                    refreshButton.Enabled = false;
                }
                else
                {
                    WorkTimer.Stop();
                    SecondTimer.Stop();
                    breakTimer.Stop();
                    startButton.Text = "Start Working";
                    refreshButton.Enabled = true;
                }

                WorkTimeLabel.Text = $"{minutes}:00";
            }
            else MessageBox.Show("You must select the window you will be working on.");
            
        }

        private void WorkTimer_Tick(object sender, EventArgs e)
        {
            string activeWindow = GetActiveWindowTitle();
            string workWindow = (string)ProcessesListBox.SelectedItem;

            if (activeWindow != workWindow)
            {
                if (softerRadioButton.Checked)
                {
                    SoundPlayer airhornplayer = new SoundPlayer(Application.StartupPath + "\\DJ_Airhorn_Sound_Effect.wav");
                    airhornplayer.Play();
                }
                else
                {
                    SoundPlayer blyatplayer = new SoundPlayer(Application.StartupPath + "\\BLYAT (EARRAPE).wav");
                    blyatplayer.Play();
                }
                MessageBox.Show("Get back to work!!!", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
        }

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            int minutes = int.Parse(WorkTimeLabel.Text.Substring(0, minChar));
            int seconds = int.Parse(WorkTimeLabel.Text.Substring(minChar + 1));
            
            if (minutes != 0 || seconds != 0)
            {
                if (seconds != 0)
                {
                    seconds -= 1;
                    if (seconds < 10)
                        WorkTimeLabel.Text = $"{minutes}:0{seconds}";
                    else
                        WorkTimeLabel.Text = $"{minutes}:{seconds}";
                }
                else
                {
                    seconds = 59;
                    minutes -= 1;
                    WorkTimeLabel.Text = $"{minutes}:{seconds}";
                }
            }
            else
            {
                MessageBox.Show("You have completed your work session! For your hard work, have a little break.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                WorkTimer.Stop();
                SecondTimer.Stop();

                int breakmins = (int)BreakNumericUpDown.Value;
                if (breakmins < 10)
                {
                    breakChar = 1;
                    WorkTimeLabel.Text = $"{breakmins}:00";
                    breakTimer.Start();
                    gameForm.Show();
                }
                else if (breakmins > 10 && breakmins < 99)
                {
                    breakChar = 2;
                    WorkTimeLabel.Text = $"{breakmins}:00";
                    breakTimer.Start();
                    gameForm.Show();
                }
                else MessageBox.Show("Stop being lazy! Dont take such a long break."); 
            }
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            int minutes = int.Parse(WorkTimeLabel.Text.Substring(0, breakChar));
            int seconds = int.Parse(WorkTimeLabel.Text.Substring(breakChar + 1));

            if (minutes != 0 || seconds != 0)
            {
                if (seconds != 0)
                {
                    seconds -= 1;
                    if (seconds < 10)
                        WorkTimeLabel.Text = $"{minutes}:0{seconds}";
                    else
                        WorkTimeLabel.Text = $"{minutes}:{seconds}";
                }
                else
                {
                    seconds = 59;
                    minutes -= 1;
                    WorkTimeLabel.Text = $"{minutes}:{seconds}";
                }
            }
            else
            {
                gameForm.Close();
                MessageBox.Show("Break time is over. Get back to work!", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                breakTimer.Stop();
                WorkTimeLabel.Text = $"{(int)WorkNumericUpDown.Value}:00";
                WorkTimer.Start();
                SecondTimer.Start();
            }
        }
    }
}
