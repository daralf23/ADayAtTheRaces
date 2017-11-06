using System;
using System.Windows.Forms;



namespace ADayAtTHeRaces
{
    public partial class Form1 : Form
    {
        //Properties

        Random MyRandomizer = new Random();
        Greyhound[] Greyhounds = new Greyhound[4];
        Guy[] Guys = new Guy[3];
        Timer tRace = new Timer();


        //Initialize

        public Form1()
        {
            tRace.Stop();
            InitializeComponent();
            InitializeGrehounds();
            InitializeGuys();
            UpdateBetPlacingLabel();
            UpdateMinBetLabel();
        }


        //Main Methods

        public void Race()
        {

            //Run the Race
            int xCounter = 0;
            tRace = new Timer();
            gbBettingParlor.Enabled = false;

            foreach (Greyhound dog in Greyhounds)
            {
                Greyhounds[xCounter].TakeStartingPosition();
                xCounter++;
            }

            MessageBox.Show("Our Races are Ready!");

            tRace.Enabled = true;
            tRace.Tick += tRace_Tick;
            tRace.Interval = 20;
            tRace.Start();
        }

        private void tRace_Tick(object sender, EventArgs e)
        {
            Greyhound winner = null;

            int xCounter = 0;
            int yCounter;
            foreach (Greyhound dog in Greyhounds)
            {
                if (Greyhounds[xCounter].Run())
                {
                    tRace.Stop();
                    MessageBox.Show("The Race is Over");

                    winner = Greyhounds[xCounter];
                    MessageBox.Show("Lane " + winner.LanePosition + " won the race");

                    yCounter = 0;
                    foreach (Guy Guy in Guys)
                    {
                        Guys[yCounter].Collect(winner.LanePosition);
                        yCounter++;
                    }

                    gbBettingParlor.Enabled = true;
                }
                xCounter++;

            }
        }


        //Control Methods

        private void bPlaceBet_Click(object sender, EventArgs e)
        {
            PlaceBet();
        }

        private void bStartRace_Click(object sender, EventArgs e)
        {
            Race();
        }

        public void PlaceBet()
        {
            int bet = (int)nudBetAmount.Value;
            int lane = (int)nudLane.Value;

            if (rbJoe.Checked)
            {
                Guys[0].PlaceBet(bet, lane);
            }
            else if (rbBob.Checked)
            {
                Guys[1].PlaceBet(bet, lane);
            }
            else if (rbTom.Checked)
            {
                Guys[2].PlaceBet(bet, lane);
            }
        }

        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBetPlacingLabel();
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBetPlacingLabel();
        }

        private void rbTom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBetPlacingLabel();
        }


        //Support Methods

        public void UpdateMinBetLabel()
        {
            int minBetAmt = (int)nudBetAmount.Minimum;
            lbMinimumBetLabel.Text = string.Format("Minimum Bet: ${0}", minBetAmt);
        }

        public void UpdateBetPlacingLabel()
        {
            if (rbJoe.Checked)
            {
                lbBetPlacing.Text = "Joe";
            }
            else if (rbBob.Checked)
            {
                lbBetPlacing.Text = "Bob";
            }
            else if (rbTom.Checked)
            {
                lbBetPlacing.Text = "Tom";
            }
        }


        //Initialize Only Methods

        public void InitializeGrehounds()
        {
            Greyhounds[0] = new Greyhound()
            {
                LanePosition = 1,
                MyPictureBox = pbDogLane1,
                StartingPosition = pbDogLane1.Left,
                RaceTrackLength = pbRaceTrack.Width - pbDogLane1.Width,
                Randomizer = MyRandomizer
            };
            Greyhounds[1] = new Greyhound()
            {
                LanePosition = 2,
                MyPictureBox = pbDogLane2,
                StartingPosition = pbDogLane2.Left,
                RaceTrackLength = pbRaceTrack.Width - pbDogLane2.Width,
                Randomizer = MyRandomizer
            };
            Greyhounds[2] = new Greyhound()
            {
                LanePosition = 3,
                MyPictureBox = pbDogLane3,
                StartingPosition = pbDogLane3.Left,
                RaceTrackLength = pbRaceTrack.Width - pbDogLane3.Width,
                Randomizer = MyRandomizer
            };
            Greyhounds[3] = new Greyhound()
            {
                LanePosition = 4,
                MyPictureBox = pbDogLane4,
                StartingPosition = pbDogLane4.Left,
                RaceTrackLength = pbRaceTrack.Width - pbDogLane4.Width,
                Randomizer = MyRandomizer
            };
        }

        public void InitializeGuys()
        {
            Guys[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = rbJoe,
                MyLabel = lbJoesBet
            };
            Guys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = rbBob,
                MyLabel = lbBobsBet
            };
            Guys[2] = new Guy()
            {
                Name = "Tom",
                Cash = 15,
                MyRadioButton = rbTom,
                MyLabel = lbTomsBet
            };

            Guys[0].UpdateLabels();
            Guys[1].UpdateLabels();
            Guys[2].UpdateLabels();
        }
    }
}
