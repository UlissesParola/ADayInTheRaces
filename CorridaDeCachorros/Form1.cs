using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaDeCachorros
{
    public partial class Form1 : Form
    {
        Guy[] Guys = new Guy[3];
        Greyhound[] Dogs = new Greyhound[4];
        Random Randomizer;
        Guy Bettor;

        public Form1()
        {
            InitializeComponent();

            Randomizer = new Random();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guys[0] = new Guy("Joe", 80, rdbJoe, lblJoesBet);
            Guys[1] = new Guy("Bob", 180, rdbBob, lblBobsBet);
            Guys[2] = new Guy("Al", 100, rdbAl, lblAlsBet);

            Dogs[0] = new Greyhound(Randomizer, imgDog1, 470);
            Dogs[1] = new Greyhound(Randomizer, imgDog2, 470);
            Dogs[2] = new Greyhound(Randomizer, imgDog3, 470);
            Dogs[3] = new Greyhound(Randomizer, imgDog4, 470);

            rdbJoe.Text = string.Format("{0} has {1} bucks", Guys[0].Name, Guys[0].Cash);
            rdbBob.Text = string.Format("{0} has {1} bucks", Guys[1].Name, Guys[1].Cash);
            rdbAl.Text  = string.Format("{0} has {1} bucks", Guys[2].Name, Guys[2].Cash);

            nudDogs.Maximum = Dogs.Length;

            lblBettor.Text = Guys[0].Name;
            Bettor = Guys[0];
        }

        private void rdbJoe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJoe.Checked)
            {
                lblBettor.Text = Guys[0].Name;
                Bettor = Guys[0];
            }
        }

        private void rdbBob_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBob.Checked)
            {
                lblBettor.Text = Guys[1].Name;
                Bettor = Guys[1];
            }
        }

        private void rdbAl_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAl.Checked)
            {
                lblBettor.Text = Guys[2].Name;
                Bettor = Guys[2];
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            Bettor.ClearBet();
            Boolean betOk = Bettor.PlaceBet((double)nudBet.Value, (int)nudDogs.Value - 1);

            if (betOk)
            {
                Bettor.Updatelabels();
            }
            else
            {
                MessageBox.Show(Bettor.Name + " don't have that amount of cash to bet", "Sorry...");
            }
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            btnBet.Enabled = false;
            btnRace.Enabled = false;
            Boolean winner = false;
            int winnerDog = 0;

            while (!winner)
            {
                for (int i = 0; i < Dogs.Length; i++)
                {
                    if (!(winner = Dogs[i].Run()))
                    {
                    imgBackground.Refresh();
                    Dogs[i].MyPictureBox.Refresh();
                    System.Threading.Thread.Sleep(20);
                    }
                    else
                    {
                        winnerDog = i;
                        break;
                        
                    }
                }                
            }

            MessageBox.Show("The dog #" + (winnerDog + 1) + " has won!", "Winner dog");

            btnRace.Enabled = true;
            btnBet.Enabled = true;

            for (int i = 0; i < Guys.Length; i++)
            {
                Guys[i].Collect(winnerDog);
                Guys[i].ClearBet();
                Guys[i].Updatelabels();
            }

            for (int i = 0; i < Dogs.Length; i++)
            {
                Dogs[i].TakeStartingPosition();
            }
        }
    }
}
