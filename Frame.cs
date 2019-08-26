using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Frame
    {
        int frameScore = 0;
        int ballOneScore = 0;
        int ballTwoScore = 0;
        int ballThreeScore = 0;

        public int GetBallOneScore()
        {
            Random r = new Random();
            ballOneScore = r.Next(0, 10);
            frameScore += ballOneScore;
            return ballOneScore;
        }

        public int GetBallTwoScore()
        {
            Random r = new Random();
            ballTwoScore = r.Next(0, ballOneScore);
            frameScore += ballTwoScore;
            return ballTwoScore;
        }

        public int GetBallThreeScore()
        {
            Random r = new Random();
            ballThreeScore = r.Next(0, 10);
            frameScore += ballThreeScore;
            return ballThreeScore;
        }

        public int GetFrameScore()
        {
            return frameScore;
        }
    }
}
