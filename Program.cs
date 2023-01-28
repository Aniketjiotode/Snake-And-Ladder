using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int Player1_position = 0;
            int Player2_position = 0;
            Random random = new Random();
            

            while (Player1_position < 100 && Player2_position < 100)
            {
                bool flag = true;
                while (flag)
                {
                    int Dice1_num = random.Next(1, 7);
                    int option1 = random.Next(3);
                    switch (option1)
                    {
                        case 0:
                            Console.WriteLine("No play");
                            Console.WriteLine(" PLayer1_position =" + Player1_position);
                            flag = false;
                            break;
                        case 1:
                            Console.WriteLine("Ladder");
                            Player1_position = Player1_position + Dice1_num;
                            Console.WriteLine(" Player1_position =" + Player1_position);
                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            Player1_position = Player1_position - Dice1_num;
                            Console.WriteLine(" Player1_position =" + Player1_position);
                            flag = false;
                            break;
                    }

                    if (Player1_position < 0)
                    {
                        Player1_position = 0;

                    }
                    else if (Player1_position > 100)
                    {
                        Player1_position = Player1_position - Dice1_num;
                    }
                    else if (Player1_position== 100)
                    {
                        Console.WriteLine("PLayer1 win the game");
                        Environment.Exit(0);
                    }
                   
                }

                flag = true;
                while (flag)
                {
                    int Dice2_num = random.Next(1, 7);
                    int option2 = random.Next(3);
                    switch (option2)
                    {
                        case 0:
                            Console.WriteLine("No play");
                            Console.WriteLine(" Player2_position =" + Player2_position);
                            flag = false;
                            break;
                        case 1:
                            Console.WriteLine("Ladder");
                            Player2_position = Player2_position + Dice2_num;
                            Console.WriteLine(" Player2_position =" + Player2_position);
                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            Player2_position = Player2_position - Dice2_num;
                            Console.WriteLine(" Player2_position =" + Player2_position);
                            flag = false;
                            break;
                    }

                    if (Player2_position < 0)
                    {
                        Player2_position = 0;

                    }
                    else if (Player2_position > 100)
                    {
                        Player2_position = Player2_position - Dice2_num;
                    }else if (Player2_position == 100)
                    {
                        Console.WriteLine("player2 win the game");
                        Environment.Exit(0);
                    }
                   
                }
                
            }
          
            
        }
    }
}
