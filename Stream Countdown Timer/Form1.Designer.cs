namespace Stream_Countdown_Timer
{
    partial class StreamCountdownTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.SetTimer = new System.Windows.Forms.Label();
            this.Or = new System.Windows.Forms.Label();
            this.SetStartTime = new System.Windows.Forms.Label();
            this.SetTimerText = new System.Windows.Forms.TextBox();
            this.SetStartTimeText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(338, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(594, 55);
            this.Title.TabIndex = 0;
            this.Title.Text = "Stream Countdown Timer";
            // 
            // SetTimer
            // 
            this.SetTimer.AutoSize = true;
            this.SetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetTimer.Location = new System.Drawing.Point(341, 291);
            this.SetTimer.Name = "SetTimer";
            this.SetTimer.Size = new System.Drawing.Size(174, 37);
            this.SetTimer.TabIndex = 1;
            this.SetTimer.Text = "Set Timer:";
            this.SetTimer.Click += new System.EventHandler(this.label1_Click);
            // 
            // Or
            // 
            this.Or.AutoSize = true;
            this.Or.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Or.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Or.Location = new System.Drawing.Point(425, 328);
            this.Or.Name = "Or";
            this.Or.Size = new System.Drawing.Size(55, 37);
            this.Or.TabIndex = 2;
            this.Or.Text = "Or";
            this.Or.Click += new System.EventHandler(this.label2_Click);
            // 
            // SetStartTime
            // 
            this.SetStartTime.AutoSize = true;
            this.SetStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStartTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetStartTime.Location = new System.Drawing.Point(270, 365);
            this.SetStartTime.Name = "SetStartTime";
            this.SetStartTime.Size = new System.Drawing.Size(245, 37);
            this.SetStartTime.TabIndex = 3;
            this.SetStartTime.Text = "Set Start Time:";
            // 
            // SetTimerText
            // 
            this.SetTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimerText.Location = new System.Drawing.Point(530, 291);
            this.SetTimerText.Multiline = true;
            this.SetTimerText.Name = "SetTimerText";
            this.SetTimerText.Size = new System.Drawing.Size(250, 50);
            this.SetTimerText.TabIndex = 4;
            this.SetTimerText.TextChanged += new System.EventHandler(this.SetTimerText_TextChanged);
            // 
            // SetStartTimeText
            // 
            this.SetStartTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStartTimeText.Location = new System.Drawing.Point(530, 365);
            this.SetStartTimeText.Multiline = true;
            this.SetStartTimeText.Name = "SetStartTimeText";
            this.SetStartTimeText.Size = new System.Drawing.Size(250, 50);
            this.SetStartTimeText.TabIndex = 5;
            this.SetStartTimeText.TextChanged += new System.EventHandler(this.SetStartTimeText_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(530, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Instructions.Location = new System.Drawing.Point(464, 176);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(374, 87);
            this.Instructions.TabIndex = 7;
            this.Instructions.Text = "Formats\r\nTimer : t (h/m)\r\nSpecific Time: h:mm:ss AM/PM";
            this.Instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLeftLabel.Location = new System.Drawing.Point(311, 601);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(169, 37);
            this.timeLeftLabel.TabIndex = 8;
            this.timeLeftLabel.Text = "Time Left:";
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLeft.Location = new System.Drawing.Point(571, 601);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(151, 37);
            this.timeLeft.TabIndex = 9;
            this.timeLeft.Text = "00:00:00";
            this.timeLeft.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset Timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StreamCountdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SetStartTimeText);
            this.Controls.Add(this.SetTimerText);
            this.Controls.Add(this.SetStartTime);
            this.Controls.Add(this.Or);
            this.Controls.Add(this.SetTimer);
            this.Controls.Add(this.Title);
            this.Name = "StreamCountdownTimer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SetTimer;
        private System.Windows.Forms.Label Or;
        private System.Windows.Forms.Label SetStartTime;
        private System.Windows.Forms.TextBox SetTimerText;
        private System.Windows.Forms.TextBox SetStartTimeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Button button2;
    }
}

