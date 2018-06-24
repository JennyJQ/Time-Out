namespace Hackathon
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RPSButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scrambleButton = new System.Windows.Forms.Button();
            this.invaderButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RPSButton
            // 
            this.RPSButton.Location = new System.Drawing.Point(12, 82);
            this.RPSButton.Name = "RPSButton";
            this.RPSButton.Size = new System.Drawing.Size(237, 46);
            this.RPSButton.TabIndex = 0;
            this.RPSButton.Text = "Rock, Paper, Scissors";
            this.RPSButton.UseVisualStyleBackColor = true;
            this.RPSButton.Click += new System.EventHandler(this.RPSButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "While you are on break, we have suggested a few games for you to play to de-stres" +
    "s. You are free to spend your time however you wish, but it is recommend you pla" +
    "y these games.";
            // 
            // scrambleButton
            // 
            this.scrambleButton.Location = new System.Drawing.Point(12, 134);
            this.scrambleButton.Name = "scrambleButton";
            this.scrambleButton.Size = new System.Drawing.Size(237, 46);
            this.scrambleButton.TabIndex = 2;
            this.scrambleButton.Text = "Scramble";
            this.scrambleButton.UseVisualStyleBackColor = true;
            this.scrambleButton.Click += new System.EventHandler(this.scrambleButton_Click);
            // 
            // invaderButton
            // 
            this.invaderButton.Location = new System.Drawing.Point(12, 186);
            this.invaderButton.Name = "invaderButton";
            this.invaderButton.Size = new System.Drawing.Size(237, 46);
            this.invaderButton.TabIndex = 3;
            this.invaderButton.Text = "Space Invaders";
            this.invaderButton.UseVisualStyleBackColor = true;
            this.invaderButton.Click += new System.EventHandler(this.invaderButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Demon Slayer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 308);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.invaderButton);
            this.Controls.Add(this.scrambleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RPSButton);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RPSButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scrambleButton;
        private System.Windows.Forms.Button invaderButton;
        private System.Windows.Forms.Button button4;
    }
}