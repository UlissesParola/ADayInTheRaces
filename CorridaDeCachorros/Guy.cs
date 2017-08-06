using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaDeCachorros
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public double Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy(string name, double cash, RadioButton radio, Label label)
        {
            this.Name = name;
            this.Cash = cash;
            this.MyRadioButton = radio;
            this.MyLabel = label;
            this.MyBet = new Bet() {Amount = 0, Bettor = this};

        }

        public void Updatelabels()
        {
            MyRadioButton.Text = this.Name + " has " + (Cash - MyBet.Amount) + " bucks";
            MyLabel.Text = MyBet.GetDescription();
        }

        public Boolean PlaceBet(double bet, int dog)
        {
            if (this.Cash >= bet)
            {
                MyBet = new Bet() { Amount = bet, Bettor = this, Dog = dog };
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearBet()
        {
            MyBet = new Bet() {Amount = 0, Bettor = this };
        }

        public void Collect(int winningDog)
        {
            this.Cash += MyBet.PayOut(winningDog);
        }
    }
}
