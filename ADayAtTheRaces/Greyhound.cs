using System;
using System.Windows.Forms;

namespace ADayAtTHeRaces
{
    class Greyhound
    {
        //Variables

        public double Location = 0;
        public PictureBox MyPictureBox = null;
        public Random Randomizer;
        public double StartingPosition = 0.0;
        public double RaceTrackLength;

        public int LanePosition = 0;
        public bool Finished = false;

        private double handicap = 1.0;


        //Constructors and Setters

        public Greyhound()
        {
        }

       public void SetHandicap(double handicap)
        {
            this.handicap = handicap;
        }

        public void SetRaceTrackLength(double raceTrackLength)
        {
            this.RaceTrackLength = raceTrackLength;
        }


        //Methods

        public bool Run()
        {
            double movement = Randomizer.Next(1, 4); 
            Location += movement;
            int intMovement = Convert.ToInt32(Location) + Convert.ToInt32(StartingPosition);
            MyPictureBox.Left = intMovement;

            if (Location >= RaceTrackLength)
            {
                Finished = true;
                return true;
            }

            return false;
        }

        public void TakeStartingPosition()
        {
            MyPictureBox.Left = Convert.ToInt32(StartingPosition);
            Location = StartingPosition;
            Finished = false;
        }
    }
}
