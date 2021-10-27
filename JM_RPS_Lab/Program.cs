using System;
using System.Collections.Generic;

namespace JM_RPS_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            UserPlayer drawPlayer = new UserPlayer("Draw");

            RPSApp gameTime = new RPSApp();
            List<Player> Leaderboard = new List<Player>();
            while (keepPlaying)
            {
                Player winner = gameTime.Play();
                
                if (winner == null)
                {
                    Leaderboard.Add(drawPlayer);
                    winner = drawPlayer;
                }
                else
                {
                    Leaderboard.Add(winner);
                }
                Console.WriteLine($"Winner: {winner.Name}");
                Console.WriteLine();
                keepPlaying = Continue();
                
            }
            Console.WriteLine("\n!WINNER CIRCLE!");
            for (int i = 0; i < Leaderboard.Count; i++)
            {
                Console.WriteLine($"{i+1}: {Leaderboard[i].Name}");
            }
        }
        public static bool Continue()
        {
            Console.Write("GG, Would you like to play again?(y/n) ");
            string response = Console.ReadLine();
            response = response.Trim().ToLower();
            if(response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                Console.WriteLine("It was fun playing with you, goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, sorry");
                return Continue();
            }
        }
    }
}
