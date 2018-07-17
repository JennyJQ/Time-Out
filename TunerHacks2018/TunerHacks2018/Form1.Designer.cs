namespace TunerHacks2018
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.fleeButton = new System.Windows.Forms.Button();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.monsterName = new System.Windows.Forms.Label();
            this.characterHealth = new System.Windows.Forms.ProgressBar();
            this.magic1Button = new System.Windows.Forms.Button();
            this.magic2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.meleeButon = new System.Windows.Forms.Button();
            this.expBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPictureBox.Image")));
            this.enemyPictureBox.Location = new System.Drawing.Point(167, 130);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(180, 191);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 0;
            this.enemyPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 99);
            this.label1.TabIndex = 1;
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(38, 346);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 2;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // fleeButton
            // 
            this.fleeButton.Location = new System.Drawing.Point(38, 385);
            this.fleeButton.Name = "fleeButton";
            this.fleeButton.Size = new System.Drawing.Size(75, 23);
            this.fleeButton.TabIndex = 3;
            this.fleeButton.Text = "Flee/Cry";
            this.fleeButton.UseVisualStyleBackColor = true;
            this.fleeButton.Click += new System.EventHandler(this.fleeButton_Click);
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.Location = new System.Drawing.Point(13, 12);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(121, 23);
            this.monsterHealthBar.Step = 1;
            this.monsterHealthBar.TabIndex = 4;
            this.monsterHealthBar.Value = 100;
            // 
            // monsterName
            // 
            this.monsterName.AutoSize = true;
            this.monsterName.Location = new System.Drawing.Point(152, 22);
            this.monsterName.Name = "monsterName";
            this.monsterName.Size = new System.Drawing.Size(0, 13);
            this.monsterName.TabIndex = 5;
            // 
            // characterHealth
            // 
            this.characterHealth.Location = new System.Drawing.Point(407, 361);
            this.characterHealth.Name = "characterHealth";
            this.characterHealth.Size = new System.Drawing.Size(100, 23);
            this.characterHealth.Step = 1;
            this.characterHealth.TabIndex = 6;
            this.characterHealth.Value = 100;
            // 
            // magic1Button
            // 
            this.magic1Button.Location = new System.Drawing.Point(134, 346);
            this.magic1Button.Name = "magic1Button";
            this.magic1Button.Size = new System.Drawing.Size(75, 23);
            this.magic1Button.TabIndex = 7;
            this.magic1Button.Text = "Spell Blast";
            this.magic1Button.UseVisualStyleBackColor = true;
            this.magic1Button.Visible = false;
            this.magic1Button.Click += new System.EventHandler(this.magic1Button_Click);
            // 
            // magic2Button
            // 
            this.magic2Button.Location = new System.Drawing.Point(237, 346);
            this.magic2Button.Name = "magic2Button";
            this.magic2Button.Size = new System.Drawing.Size(75, 23);
            this.magic2Button.TabIndex = 9;
            this.magic2Button.Text = "Lightning Strike";
            this.magic2Button.UseVisualStyleBackColor = true;
            this.magic2Button.Visible = false;
            this.magic2Button.Click += new System.EventHandler(this.magic2Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(379, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "HP";
            // 
            // meleeButon
            // 
            this.meleeButon.Location = new System.Drawing.Point(38, 346);
            this.meleeButon.Name = "meleeButon";
            this.meleeButon.Size = new System.Drawing.Size(75, 23);
            this.meleeButon.TabIndex = 11;
            this.meleeButon.Text = "Punch";
            this.meleeButon.UseVisualStyleBackColor = true;
            this.meleeButon.Visible = false;
            this.meleeButon.Click += new System.EventHandler(this.meleeButon_Click);
            // 
            // expBar
            // 
            this.expBar.Location = new System.Drawing.Point(407, 390);
            this.expBar.Name = "expBar";
            this.expBar.Size = new System.Drawing.Size(100, 23);
            this.expBar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(373, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "EXP";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.levelLabel.Location = new System.Drawing.Point(460, 338);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(18, 20);
            this.levelLabel.TabIndex = 14;
            this.levelLabel.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(431, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lvl:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expBar);
            this.Controls.Add(this.meleeButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magic2Button);
            this.Controls.Add(this.magic1Button);
            this.Controls.Add(this.characterHealth);
            this.Controls.Add(this.monsterName);
            this.Controls.Add(this.monsterHealthBar);
            this.Controls.Add(this.fleeButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyPictureBox);
            this.Name = "Form1";
            this.Text = "Snakio";
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button fleeButton;
        private System.Windows.Forms.ProgressBar monsterHealthBar;
        private System.Windows.Forms.Label monsterName;
        private System.Windows.Forms.ProgressBar characterHealth;
        private System.Windows.Forms.Button magic1Button;
        private System.Windows.Forms.Button magic2Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button meleeButon;
        private System.Windows.Forms.ProgressBar expBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

