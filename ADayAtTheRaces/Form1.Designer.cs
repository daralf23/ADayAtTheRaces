namespace ADayAtTHeRaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bStartRace = new System.Windows.Forms.Button();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbTom = new System.Windows.Forms.RadioButton();
            this.lbBetPlacing = new System.Windows.Forms.Label();
            this.bPlaceBet = new System.Windows.Forms.Button();
            this.nudBetAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLane = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbJoesBet = new System.Windows.Forms.Label();
            this.lbBobsBet = new System.Windows.Forms.Label();
            this.lbTomsBet = new System.Windows.Forms.Label();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.lbMinimumBetLabel = new System.Windows.Forms.Label();
            this.pbDogLane1 = new System.Windows.Forms.PictureBox();
            this.pbDogLane2 = new System.Windows.Forms.PictureBox();
            this.pbDogLane3 = new System.Windows.Forms.PictureBox();
            this.pbDogLane4 = new System.Windows.Forms.PictureBox();
            this.gbBettingParlor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane4)).BeginInit();
            this.gbBettingParlor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStartRace
            // 
            this.bStartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bStartRace.Location = new System.Drawing.Point(445, 262);
            this.bStartRace.Name = "bStartRace";
            this.bStartRace.Size = new System.Drawing.Size(164, 96);
            this.bStartRace.TabIndex = 0;
            this.bStartRace.Text = "Race!";
            this.bStartRace.UseVisualStyleBackColor = true;
            this.bStartRace.Click += new System.EventHandler(this.bStartRace_Click);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Checked = true;
            this.rbJoe.Location = new System.Drawing.Point(16, 29);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(42, 17);
            this.rbJoe.TabIndex = 1;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(16, 52);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(44, 17);
            this.rbBob.TabIndex = 2;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbTom
            // 
            this.rbTom.AutoSize = true;
            this.rbTom.Location = new System.Drawing.Point(16, 75);
            this.rbTom.Name = "rbTom";
            this.rbTom.Size = new System.Drawing.Size(46, 17);
            this.rbTom.TabIndex = 3;
            this.rbTom.Text = "Tom";
            this.rbTom.UseVisualStyleBackColor = true;
            this.rbTom.CheckedChanged += new System.EventHandler(this.rbTom_CheckedChanged);
            // 
            // lbBetPlacing
            // 
            this.lbBetPlacing.AutoSize = true;
            this.lbBetPlacing.Location = new System.Drawing.Point(13, 105);
            this.lbBetPlacing.Name = "lbBetPlacing";
            this.lbBetPlacing.Size = new System.Drawing.Size(35, 13);
            this.lbBetPlacing.TabIndex = 4;
            this.lbBetPlacing.Text = "label1";
            // 
            // bPlaceBet
            // 
            this.bPlaceBet.Location = new System.Drawing.Point(51, 101);
            this.bPlaceBet.Name = "bPlaceBet";
            this.bPlaceBet.Size = new System.Drawing.Size(50, 20);
            this.bPlaceBet.TabIndex = 5;
            this.bPlaceBet.Text = "Bets";
            this.bPlaceBet.UseVisualStyleBackColor = true;
            this.bPlaceBet.Click += new System.EventHandler(this.bPlaceBet_Click);
            // 
            // nudBetAmount
            // 
            this.nudBetAmount.Location = new System.Drawing.Point(107, 101);
            this.nudBetAmount.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudBetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBetAmount.Name = "nudBetAmount";
            this.nudBetAmount.Size = new System.Drawing.Size(50, 20);
            this.nudBetAmount.TabIndex = 6;
            this.nudBetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "dollars on lane number";
            // 
            // nudLane
            // 
            this.nudLane.Location = new System.Drawing.Point(279, 101);
            this.nudLane.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLane.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLane.Name = "nudLane";
            this.nudLane.Size = new System.Drawing.Size(50, 20);
            this.nudLane.TabIndex = 8;
            this.nudLane.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(151, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Betting Parlor";
            // 
            // lbJoesBet
            // 
            this.lbJoesBet.AutoSize = true;
            this.lbJoesBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbJoesBet.Location = new System.Drawing.Point(154, 29);
            this.lbJoesBet.MinimumSize = new System.Drawing.Size(175, 0);
            this.lbJoesBet.Name = "lbJoesBet";
            this.lbJoesBet.Size = new System.Drawing.Size(175, 15);
            this.lbJoesBet.TabIndex = 11;
            this.lbJoesBet.Text = "JoesBetLabel";
            // 
            // lbBobsBet
            // 
            this.lbBobsBet.AutoSize = true;
            this.lbBobsBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBobsBet.Location = new System.Drawing.Point(154, 52);
            this.lbBobsBet.MinimumSize = new System.Drawing.Size(175, 0);
            this.lbBobsBet.Name = "lbBobsBet";
            this.lbBobsBet.Size = new System.Drawing.Size(175, 15);
            this.lbBobsBet.TabIndex = 12;
            this.lbBobsBet.Text = "BobsBetLabel";
            // 
            // lbTomsBet
            // 
            this.lbTomsBet.AutoSize = true;
            this.lbTomsBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTomsBet.Location = new System.Drawing.Point(154, 75);
            this.lbTomsBet.MinimumSize = new System.Drawing.Size(175, 0);
            this.lbTomsBet.Name = "lbTomsBet";
            this.lbTomsBet.Size = new System.Drawing.Size(175, 15);
            this.lbTomsBet.TabIndex = 13;
            this.lbTomsBet.Text = "TomsBetLabel";
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRaceTrack.Image")));
            this.pbRaceTrack.Location = new System.Drawing.Point(13, 13);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(601, 201);
            this.pbRaceTrack.TabIndex = 14;
            this.pbRaceTrack.TabStop = false;
            // 
            // lbMinimumBetLabel
            // 
            this.lbMinimumBetLabel.AutoSize = true;
            this.lbMinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMinimumBetLabel.Location = new System.Drawing.Point(7, 1);
            this.lbMinimumBetLabel.Name = "lbMinimumBetLabel";
            this.lbMinimumBetLabel.Size = new System.Drawing.Size(119, 17);
            this.lbMinimumBetLabel.TabIndex = 15;
            this.lbMinimumBetLabel.Text = "minimumBetLabel";
            // 
            // pbDogLane1
            // 
            this.pbDogLane1.Image = ((System.Drawing.Image)(resources.GetObject("pbDogLane1.Image")));
            this.pbDogLane1.Location = new System.Drawing.Point(21, 22);
            this.pbDogLane1.Name = "pbDogLane1";
            this.pbDogLane1.Size = new System.Drawing.Size(80, 24);
            this.pbDogLane1.TabIndex = 16;
            this.pbDogLane1.TabStop = false;
            // 
            // pbDogLane2
            // 
            this.pbDogLane2.Image = ((System.Drawing.Image)(resources.GetObject("pbDogLane2.Image")));
            this.pbDogLane2.Location = new System.Drawing.Point(21, 70);
            this.pbDogLane2.Name = "pbDogLane2";
            this.pbDogLane2.Size = new System.Drawing.Size(80, 24);
            this.pbDogLane2.TabIndex = 17;
            this.pbDogLane2.TabStop = false;
            // 
            // pbDogLane3
            // 
            this.pbDogLane3.Image = ((System.Drawing.Image)(resources.GetObject("pbDogLane3.Image")));
            this.pbDogLane3.Location = new System.Drawing.Point(21, 124);
            this.pbDogLane3.Name = "pbDogLane3";
            this.pbDogLane3.Size = new System.Drawing.Size(80, 24);
            this.pbDogLane3.TabIndex = 18;
            this.pbDogLane3.TabStop = false;
            // 
            // pbDogLane4
            // 
            this.pbDogLane4.Image = ((System.Drawing.Image)(resources.GetObject("pbDogLane4.Image")));
            this.pbDogLane4.Location = new System.Drawing.Point(21, 178);
            this.pbDogLane4.Name = "pbDogLane4";
            this.pbDogLane4.Size = new System.Drawing.Size(80, 24);
            this.pbDogLane4.TabIndex = 19;
            this.pbDogLane4.TabStop = false;
            // 
            // gbBettingParlor
            // 
            this.gbBettingParlor.Controls.Add(this.lbMinimumBetLabel);
            this.gbBettingParlor.Controls.Add(this.lbTomsBet);
            this.gbBettingParlor.Controls.Add(this.lbBobsBet);
            this.gbBettingParlor.Controls.Add(this.lbJoesBet);
            this.gbBettingParlor.Controls.Add(this.label3);
            this.gbBettingParlor.Controls.Add(this.nudLane);
            this.gbBettingParlor.Controls.Add(this.label2);
            this.gbBettingParlor.Controls.Add(this.nudBetAmount);
            this.gbBettingParlor.Controls.Add(this.bPlaceBet);
            this.gbBettingParlor.Controls.Add(this.lbBetPlacing);
            this.gbBettingParlor.Controls.Add(this.rbTom);
            this.gbBettingParlor.Controls.Add(this.rbBob);
            this.gbBettingParlor.Controls.Add(this.rbJoe);
            this.gbBettingParlor.Location = new System.Drawing.Point(5, 237);
            this.gbBettingParlor.Name = "gbBettingParlor";
            this.gbBettingParlor.Size = new System.Drawing.Size(342, 131);
            this.gbBettingParlor.TabIndex = 20;
            this.gbBettingParlor.TabStop = false;
            this.gbBettingParlor.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.gbBettingParlor);
            this.Controls.Add(this.pbDogLane4);
            this.Controls.Add(this.pbDogLane3);
            this.Controls.Add(this.pbDogLane2);
            this.Controls.Add(this.pbDogLane1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bStartRace);
            this.Controls.Add(this.pbRaceTrack);
            this.MinimumSize = new System.Drawing.Size(175, 38);
            this.Name = "Form1";
            this.Text = "A Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.nudBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogLane4)).EndInit();
            this.gbBettingParlor.ResumeLayout(false);
            this.gbBettingParlor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStartRace;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbTom;
        private System.Windows.Forms.Label lbBetPlacing;
        private System.Windows.Forms.Button bPlaceBet;
        private System.Windows.Forms.NumericUpDown nudBetAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbJoesBet;
        private System.Windows.Forms.Label lbBobsBet;
        private System.Windows.Forms.Label lbTomsBet;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Label lbMinimumBetLabel;
        private System.Windows.Forms.PictureBox pbDogLane1;
        private System.Windows.Forms.PictureBox pbDogLane2;
        private System.Windows.Forms.PictureBox pbDogLane3;
        private System.Windows.Forms.PictureBox pbDogLane4;
        private System.Windows.Forms.GroupBox gbBettingParlor;
    }
}

