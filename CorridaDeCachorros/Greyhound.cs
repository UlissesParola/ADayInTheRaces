using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CorridaDeCachorros
{
    class Greyhound
    {
        public Point StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public Random Randomizer;

        public Greyhound(Random random, PictureBox myPicture, int raceTrackLength)
        {
            this.RacetrackLength = raceTrackLength;
            this.Randomizer = random;
            this.MyPictureBox = myPicture;
            this.StartingPosition = MyPictureBox.Location;
        }

        public Boolean Run()
        {
            Point newlocation = new Point(MyPictureBox.Location.X + Randomizer.Next(1,5), MyPictureBox.Location.Y);
            MyPictureBox.Location = newlocation;

            if (MyPictureBox.Location.X >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            this.MyPictureBox.Location = this.StartingPosition;
        }
    }
}
