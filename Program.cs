using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerScore playerScore = new PlayerScore();
            int currentFrame = 1;

            while (currentFrame < 11)
            {
                Console.WriteLine("Please roll ball 1 for frame " + currentFrame + " by pressing enter.");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Frame frame = new Frame();

                    int ballOneScore = frame.GetBallOneScore();
                    int ballTwoScore = frame.GetBallTwoScore();
                    int ballThreeScore = frame.GetBallThreeScore();
                    int frameScore = frame.GetFrameScore();

                    if (ballOneScore < 10 || currentFrame == 10)
                    {
                        if (currentFrame == 10 && ballOneScore == 10)
                        {
                            playerScore.AddToStrikeStreak();
                            Console.WriteLine("You knocked down all 10 pins, STRIKE!!! Please roll ball 2 for frame " + currentFrame + " by pressing enter.");
                        }
                        else
                        {
                            playerScore.AddToScore(1, ballOneScore);
                            Console.WriteLine("You knocked down " + ballOneScore + " pins. Please roll ball 2 for frame " + currentFrame + " by pressing enter.");
                        }
                        
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            if (frameScore < 10 || currentFrame == 10)
                            {
                                if (currentFrame == 10 && ballOneScore == 10)
                                {
                                    playerScore.AddToStrikeStreak();
                                    Console.WriteLine("You knocked down all 10 pins, STRIKE!!! Please roll ball 2 for frame " + currentFrame + " by pressing enter.");
                                }
                                else if (currentFrame == 10 && frameScore == 10)
                                {
                                    playerScore.SetHasSpare();
                                    Console.WriteLine("You knocked down " + ballTwoScore + " pins for a total of 10 pins this frame, SPARE!!!. Please roll ball 2 for frame " + currentFrame + " by pressing enter.");
                                }
                                else
                                {
                                    playerScore.AddToScore(1, frameScore);
                                    Console.WriteLine("You knocked down " + ballTwoScore + " pins for a total of " + frameScore + " pins this frame.");
                                }
                            }
                            else
                            {
                                playerScore.SetHasSpare();
                                Console.WriteLine("You knocked down " + ballTwoScore + " pins for a total of 10 pins this frame, SPARE!!!.");
                            }

                            if (currentFrame == 10 && frameScore > 20)
                            {
                                if (Console.ReadKey().Key == ConsoleKey.Enter)
                                {
                                    if (ballThreeScore == 10)
                                    {
                                        playerScore.AddToStrikeStreak();
                                        Console.WriteLine("You knocked down all 10 pins, STRIKE!!!");
                                    }
                                    else if (frameScore == 20)
                                    {
                                        playerScore.SetHasSpare();
                                        Console.WriteLine("You knocked down " + ballTwoScore + " pins for a total of 10 pins this frame, SPARE!!!. Please roll ball 2 for frame " + currentFrame + " by pressing enter.");
                                    }
                                    else
                                    {
                                        playerScore.AddToScore(1, frameScore);
                                        Console.WriteLine("You knocked down " + ballTwoScore + " pins for a total of " + frameScore + " pins this frame.");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        playerScore.AddToStrikeStreak();
                        Console.WriteLine("You knocked down all 10 pins, STRIKE!!!");
                    }
                }
            }
        }
    }
}
