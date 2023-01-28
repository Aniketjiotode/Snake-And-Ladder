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
            Random random= new Random();
            int Dice_num =random.Next(7);
            Console.WriteLine($"{Dice_num}");

            int option = random.Next(3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No play");
                    Console.WriteLine("the position is" + Player_position);
                    break;
                case 1:
                    Console.WriteLine("Ladder");
                    Player_position = Player_position + Dice_num;
                    Console.WriteLine("the position is" + Player_position);
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    Player_position = Player_position - Dice_num;
                    Console.WriteLine("the position is" + Player_position);
                    break;
            }


        }   
    }
}
