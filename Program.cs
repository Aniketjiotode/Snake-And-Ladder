﻿using System;

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
            int Die_num =random.Next(7);
            Console.WriteLine($"{Die_num}");

           
        }   
    }
}
