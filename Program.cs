using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int Player_position = 0;
            Console.WriteLine("Position = " + Player_position);
            int dice_Roll = 0;
            Random random= new Random();

            while (Player_position < 100)
            {
                dice_Roll++;
                int Dice_num =random.Next(1,7);
                int option = random.Next(3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play");
                        Console.WriteLine(" position =" + Player_position);
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        Player_position = Player_position + Dice_num;
                        Console.WriteLine(" position =" + Player_position);
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        Player_position = Player_position - Dice_num;
                        Console.WriteLine(" position =" + Player_position);
                        break;
                }
                    if (Player_position < 0)
                    {
                        Player_position = 0;

                    }
                    else if (Player_position > 100)
                    {
                        Player_position = Player_position - Dice_num;
                    }
            }
            Console.WriteLine($"Number of times the dice was played to win the game = {dice_Roll}");
        }   
    }
}
