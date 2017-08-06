using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros
{
    class Bet
    {
        public double Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (this.Amount > 0)
            {
                return Bettor.Name + " bets " + this.Amount + " bucks on dog #" + (this.Dog + 1);
            }
            else
            {
                return Bettor.Name + " hasn't place a bet";
            }
            
        }

        public double PayOut(int winningDog)
        {
            if (winningDog == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
