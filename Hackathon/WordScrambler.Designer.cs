namespace Hackathon
{
    partial class WordScrambler
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
            this.Points = new System.Windows.Forms.Label();
            this.High = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Scramble = new System.Windows.Forms.Label();
            this.fake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Points.Location = new System.Drawing.Point(233, 143);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(0, 13);
            this.Points.TabIndex = 13;
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.High.Location = new System.Drawing.Point(233, 96);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(0, 13);
            this.High.TabIndex = 12;
            // 
            // Check
            // 
            this.Check.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Check.Location = new System.Drawing.Point(147, 198);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(181, 23);
            this.Check.TabIndex = 11;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Result.Location = new System.Drawing.Point(38, 221);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 10;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(41, 198);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 20);
            this.Answer.TabIndex = 9;
            // 
            // Scramble
            // 
            this.Scramble.AutoSize = true;
            this.Scramble.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Scramble.Location = new System.Drawing.Point(38, 97);
            this.Scramble.Name = "Scramble";
            this.Scramble.Size = new System.Drawing.Size(0, 13);
            this.Scramble.TabIndex = 8;
            // 
            // fake
            // 
            this.fake.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fake.Location = new System.Drawing.Point(41, 41);
            this.fake.Name = "fake";
            this.fake.Size = new System.Drawing.Size(181, 23);
            this.fake.TabIndex = 7;
            this.fake.Text = "Next Word";
            this.fake.UseVisualStyleBackColor = true;
            this.fake.Click += new System.EventHandler(this.fake_Click);
            // 
            // WordScrambler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 275);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.High);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Scramble);
            this.Controls.Add(this.fake);
            this.Name = "WordScrambler";
            this.Text = "Word Scramble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label High;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Scramble;
        private System.Windows.Forms.Button fake;
    }
}