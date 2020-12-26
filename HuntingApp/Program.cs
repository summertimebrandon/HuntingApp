﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print welcome message and ask for Username

            //printing Welcome message
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("WELCOME TO THE ANIMAL GAME");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("BY BRANDON");
            //ask user what their Username is
            Console.WriteLine("What is your Username?");


            //making a variable and capturing the data from the user
            string userInput = Console.ReadLine();

            //Print out the username
            Console.WriteLine("Hello:" + userInput);


            #endregion

            #region Create Player object and set score to 0
            //created a new instance of Player and set the Username
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;



            Console.WriteLine("player1 Username:" + player1.Username);
            Console.WriteLine("player1 Score:" + player1.Score);
            #endregion


            GameEngine game = new GameEngine();
            Animal animal1 = game.CatchAnimal();

            Console.WriteLine("animal1 AnimalType:" + animal1.AnimalType);
            Console.WriteLine("animal1 Score:" + animal1.Points);

            player1.Score = player1.Score + animal1.Points;

            Console.WriteLine("player1 Score:" + player1.Score);





            Animal animal2 = game.CatchAnimal();

            Console.WriteLine("anmal2 AnimalType:" + animal2.AnimalType);
            Console.WriteLine("animal2 Score:" + animal2.Points);

            player1.Score = player1.Score + animal2.Points;

            Console.WriteLine("player1 Score:" + player1.Score);
        }
    }
}
