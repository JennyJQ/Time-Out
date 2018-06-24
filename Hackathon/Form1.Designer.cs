namespace Hackathon
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
            this.WorkTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.ProcessesListBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BreakNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.louderRadioButton = new System.Windows.Forms.RadioButton();
            this.softerRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.WorkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkTimer
            // 
            this.WorkTimer.Interval = 5000;
            this.WorkTimer.Tick += new System.EventHandler(this.WorkTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(255, 61);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(113, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Working";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ProcessesListBox
            // 
            this.ProcessesListBox.FormattingEnabled = true;
            this.ProcessesListBox.Location = new System.Drawing.Point(12, 32);
            this.ProcessesListBox.Name = "ProcessesListBox";
            this.ProcessesListBox.Size = new System.Drawing.Size(237, 251);
            this.ProcessesListBox.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(255, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(113, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh Windows";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select the window you will be working on:";
            // 
            // WorkNumericUpDown
            // 
            this.WorkNumericUpDown.Location = new System.Drawing.Point(472, 29);
            this.WorkNumericUpDown.Name = "WorkNumericUpDown";
            this.WorkNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.WorkNumericUpDown.TabIndex = 4;
            this.WorkNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // BreakNumericUpDown
            // 
            this.BreakNumericUpDown.Location = new System.Drawing.Point(472, 68);
            this.BreakNumericUpDown.Name = "BreakNumericUpDown";
            this.BreakNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BreakNumericUpDown.TabIndex = 5;
            this.BreakNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Indicate the length of the work session in minutes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Indicate the length of the break period in minutes:";
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTimeLabel.Location = new System.Drawing.Point(395, 130);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(284, 108);
            this.WorkTimeLabel.TabIndex = 8;
            this.WorkTimeLabel.Text = "00:00";
            // 
            // SecondTimer
            // 
            this.SecondTimer.Interval = 1000;
            this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick);
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // louderRadioButton
            // 
            this.louderRadioButton.AutoSize = true;
            this.louderRadioButton.Location = new System.Drawing.Point(256, 105);
            this.louderRadioButton.Name = "louderRadioButton";
            this.louderRadioButton.Size = new System.Drawing.Size(92, 17);
            this.louderRadioButton.TabIndex = 9;
            this.louderRadioButton.Text = "Louder Sound";
            this.louderRadioButton.UseVisualStyleBackColor = true;
            // 
            // softerRadioButton
            // 
            this.softerRadioButton.AutoSize = true;
            this.softerRadioButton.Checked = true;
            this.softerRadioButton.Location = new System.Drawing.Point(256, 128);
            this.softerRadioButton.Name = "softerRadioButton";
            this.softerRadioButton.Size = new System.Drawing.Size(87, 17);
            this.softerRadioButton.TabIndex = 10;
            this.softerRadioButton.TabStop = true;
            this.softerRadioButton.Text = "Softer Sound";
            this.softerRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.softerRadioButton);
            this.Controls.Add(this.louderRadioButton);
            this.Controls.Add(this.WorkTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BreakNumericUpDown);
            this.Controls.Add(this.WorkNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.ProcessesListBox);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Timeout";
            ((System.ComponentModel.ISupportInitialize)(this.WorkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer WorkTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox ProcessesListBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WorkNumericUpDown;
        private System.Windows.Forms.NumericUpDown BreakNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WorkTimeLabel;
        private System.Windows.Forms.Timer SecondTimer;
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.RadioButton louderRadioButton;
        private System.Windows.Forms.RadioButton softerRadioButton;
    }
}

