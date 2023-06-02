namespace CollectSum
{
    partial class GameWindow
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
            System.Windows.Forms.Label rightPlayerLabel;
            System.Windows.Forms.Label leftPlayerLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label leftLabel1;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            this.roundCounterLabel = new System.Windows.Forms.Label();
            this.takeButton = new System.Windows.Forms.Button();
            this.passButton = new System.Windows.Forms.Button();
            this.leftReceivedNumber = new System.Windows.Forms.Label();
            this.rightReceivedNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.turnArrowIndicatorLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.leftRoundScore = new System.Windows.Forms.Label();
            this.rightRoundScore = new System.Windows.Forms.Label();
            this.leftTotalScore = new System.Windows.Forms.Label();
            this.rightTotalScore = new System.Windows.Forms.Label();
            this.turnTextIndicatorLabel = new System.Windows.Forms.Label();
            this.maxScoreLabel = new System.Windows.Forms.Label();
            rightPlayerLabel = new System.Windows.Forms.Label();
            leftPlayerLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            leftLabel1 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightPlayerLabel
            // 
            rightPlayerLabel.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rightPlayerLabel.Location = new System.Drawing.Point(573, 381);
            rightPlayerLabel.Name = "rightPlayerLabel";
            rightPlayerLabel.Size = new System.Drawing.Size(250, 63);
            rightPlayerLabel.TabIndex = 4;
            rightPlayerLabel.Text = "Right player";
            // 
            // leftPlayerLabel
            // 
            leftPlayerLabel.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            leftPlayerLabel.Location = new System.Drawing.Point(12, 381);
            leftPlayerLabel.Name = "leftPlayerLabel";
            leftPlayerLabel.Size = new System.Drawing.Size(229, 63);
            leftPlayerLabel.TabIndex = 6;
            leftPlayerLabel.Text = "Left player";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(289, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(253, 63);
            label3.TabIndex = 9;
            label3.Text = "Round Score";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(13, 461);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 38);
            label4.TabIndex = 10;
            label4.Text = "Total score:";
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(573, 461);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(134, 38);
            label7.TabIndex = 14;
            label7.Text = "Total score:";
            // 
            // leftLabel1
            // 
            leftLabel1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            leftLabel1.Location = new System.Drawing.Point(12, 244);
            leftLabel1.Name = "leftLabel1";
            leftLabel1.Size = new System.Drawing.Size(204, 38);
            leftLabel1.TabIndex = 16;
            leftLabel1.Text = "Received number:";
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(619, 244);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(204, 38);
            label9.TabIndex = 22;
            label9.Text = "Received number:";
            // 
            // label13
            // 
            label13.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label13.Location = new System.Drawing.Point(295, 62);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(85, 63);
            label13.TabIndex = 23;
            label13.Text = "L:";
            // 
            // label14
            // 
            label14.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label14.Location = new System.Drawing.Point(426, 62);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(85, 63);
            label14.TabIndex = 25;
            label14.Text = "R:";
            // 
            // roundCounterLabel
            // 
            this.roundCounterLabel.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundCounterLabel.Location = new System.Drawing.Point(12, 18);
            this.roundCounterLabel.Name = "roundCounterLabel";
            this.roundCounterLabel.Size = new System.Drawing.Size(178, 44);
            this.roundCounterLabel.TabIndex = 30;
            this.roundCounterLabel.Text = "Round  #2";
            // 
            // takeButton
            // 
            this.takeButton.BackColor = System.Drawing.Color.Navy;
            this.takeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.takeButton.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.takeButton.Location = new System.Drawing.Point(247, 139);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(147, 144);
            this.takeButton.TabIndex = 0;
            this.takeButton.Text = "T a k e";
            this.takeButton.UseVisualStyleBackColor = false;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // passButton
            // 
            this.passButton.BackColor = System.Drawing.Color.DarkRed;
            this.passButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passButton.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.passButton.Location = new System.Drawing.Point(426, 139);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(153, 143);
            this.passButton.TabIndex = 1;
            this.passButton.Text = "P a s s";
            this.passButton.UseVisualStyleBackColor = false;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // leftReceivedNumber
            // 
            this.leftReceivedNumber.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftReceivedNumber.Location = new System.Drawing.Point(61, 282);
            this.leftReceivedNumber.Name = "leftReceivedNumber";
            this.leftReceivedNumber.Size = new System.Drawing.Size(104, 42);
            this.leftReceivedNumber.TabIndex = 15;
            this.leftReceivedNumber.Text = "+24";
            // 
            // rightReceivedNumber
            // 
            this.rightReceivedNumber.Font = new System.Drawing.Font("Lucida Fax", 26.25F);
            this.rightReceivedNumber.Location = new System.Drawing.Point(674, 282);
            this.rightReceivedNumber.Name = "rightReceivedNumber";
            this.rightReceivedNumber.Size = new System.Drawing.Size(104, 42);
            this.rightReceivedNumber.TabIndex = 17;
            this.rightReceivedNumber.Text = "+24";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 53);
            this.label11.TabIndex = 20;
            this.label11.Text = "TURN:";
            // 
            // turnArrowIndicatorLabel
            // 
            this.turnArrowIndicatorLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnArrowIndicatorLabel.Location = new System.Drawing.Point(346, 380);
            this.turnArrowIndicatorLabel.Name = "turnArrowIndicatorLabel";
            this.turnArrowIndicatorLabel.Size = new System.Drawing.Size(115, 76);
            this.turnArrowIndicatorLabel.TabIndex = 19;
            this.turnArrowIndicatorLabel.Text = "🠖";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.SandyBrown;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.Brown;
            this.restartButton.Location = new System.Drawing.Point(289, 459);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(222, 39);
            this.restartButton.TabIndex = 21;
            this.restartButton.Text = "R e s t a r t";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // leftRoundScore
            // 
            this.leftRoundScore.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftRoundScore.Location = new System.Drawing.Point(336, 62);
            this.leftRoundScore.Name = "leftRoundScore";
            this.leftRoundScore.Size = new System.Drawing.Size(84, 56);
            this.leftRoundScore.TabIndex = 24;
            this.leftRoundScore.Text = "0";
            // 
            // rightRoundScore
            // 
            this.rightRoundScore.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightRoundScore.Location = new System.Drawing.Point(468, 62);
            this.rightRoundScore.Name = "rightRoundScore";
            this.rightRoundScore.Size = new System.Drawing.Size(84, 56);
            this.rightRoundScore.TabIndex = 26;
            this.rightRoundScore.Text = "0";
            // 
            // leftTotalScore
            // 
            this.leftTotalScore.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTotalScore.Location = new System.Drawing.Point(135, 461);
            this.leftTotalScore.Name = "leftTotalScore";
            this.leftTotalScore.Size = new System.Drawing.Size(81, 38);
            this.leftTotalScore.TabIndex = 27;
            this.leftTotalScore.Text = "246";
            // 
            // rightTotalScore
            // 
            this.rightTotalScore.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTotalScore.Location = new System.Drawing.Point(697, 460);
            this.rightTotalScore.Name = "rightTotalScore";
            this.rightTotalScore.Size = new System.Drawing.Size(81, 38);
            this.rightTotalScore.TabIndex = 28;
            this.rightTotalScore.Text = "246";
            // 
            // turnTextIndicatorLabel
            // 
            this.turnTextIndicatorLabel.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnTextIndicatorLabel.Location = new System.Drawing.Point(354, 371);
            this.turnTextIndicatorLabel.Name = "turnTextIndicatorLabel";
            this.turnTextIndicatorLabel.Size = new System.Drawing.Size(107, 47);
            this.turnTextIndicatorLabel.TabIndex = 29;
            this.turnTextIndicatorLabel.Text = "Right";
            // 
            // maxScoreLabel
            // 
            this.maxScoreLabel.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxScoreLabel.Location = new System.Drawing.Point(592, 18);
            this.maxScoreLabel.Name = "maxScoreLabel";
            this.maxScoreLabel.Size = new System.Drawing.Size(231, 44);
            this.maxScoreLabel.TabIndex = 31;
            this.maxScoreLabel.Text = "Max score: 20";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.maxScoreLabel);
            this.Controls.Add(this.roundCounterLabel);
            this.Controls.Add(this.turnTextIndicatorLabel);
            this.Controls.Add(this.rightTotalScore);
            this.Controls.Add(this.leftTotalScore);
            this.Controls.Add(this.rightRoundScore);
            this.Controls.Add(label14);
            this.Controls.Add(this.leftRoundScore);
            this.Controls.Add(label13);
            this.Controls.Add(label9);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.turnArrowIndicatorLabel);
            this.Controls.Add(this.rightReceivedNumber);
            this.Controls.Add(leftLabel1);
            this.Controls.Add(this.leftReceivedNumber);
            this.Controls.Add(label7);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(leftPlayerLabel);
            this.Controls.Add(rightPlayerLabel);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.takeButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "GameWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label maxScoreLabel;

        private System.Windows.Forms.Label roundCounterLabel;

        private System.Windows.Forms.Label turnTextIndicatorLabel;

        private System.Windows.Forms.Label rightTotalScore;
        private System.Windows.Forms.Label leftTotalScore;

        private System.Windows.Forms.Button restartButton;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label turnArrowIndicatorLabel;

        private System.Windows.Forms.Label rightReceivedNumber;

        private System.Windows.Forms.Label leftReceivedNumber;

        private System.Windows.Forms.Label leftRoundScore;
        private System.Windows.Forms.Label rightRoundScore;

        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.Button passButton;

        #endregion
    }
}