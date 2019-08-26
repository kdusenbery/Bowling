using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class PlayerScore
    {
        int playerScore = 0;
        int strikeStreak = 0;
        bool hasSpare = false;
        bool hasStrike = false;

        public void AddToStrikeStreak()
        {
            strikeStreak++;
            hasStrike = true;
        }

        public void SetHasSpare()
        {
            hasSpare = true;
        }

        public void AddToScore(int ball, int points)
        {
            if (ball == 1 && hasSpare == true)
            {
                points = 10 + points;
                hasSpare = false;
            }
            else if (ball == 1 && points != 10 && hasStrike == true && strikeStreak > 1)
            {
                points = 20 + points;
                strikeStreak--;
            }
            else if (ball == 2 && points != 10 && hasStrike == true)
            {
                points = (10 + points) + points;
                strikeStreak = 0;
                hasStrike = false;
            }

            playerScore += points;
        }

        public int GetPlayerScore()
        {
            return playerScore;
        }
    }
}
