using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTHeRaces
{
    class Guy
    {
        //Variables

        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;


        //Constructors, Getters and Setters

        public Guy()
        {
            MyBet = new Bet(this);
        }

        public Guy(string Name)
        {
            this.Name = Name;
            UpdateLabels();
        }

        public Guy(string Name, int Cash)
        {
            this.Name = Name;
            this.Cash = Cash;
            UpdateLabels();
        }


        //Methods

        public void PlaceBet(int betAmount, int dogToWin)
        {
            if (betAmount <= Cash)
            {
                clearBet();
                MyBet = new Bet(this, betAmount, dogToWin);
                UpdateLabels();
            }
            else
            {
                MessageBox.Show(Name+" does not have the funds to support that bet.","Error:100 - Insufficent Funds");
            }
        }

        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
            clearBet();
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = string.Format("{0} has ${1}.", Name, Cash);
        }

        private void clearBet()
        {
            MyBet = new Bet(this);
            UpdateLabels();
        }
    }
}
