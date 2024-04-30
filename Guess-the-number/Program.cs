using System;

namespace GuessTheNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine(" * ¡Vamos a jugar! Adivina un número entre 1 y 100 *");
            Console.WriteLine();
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string? playerName = Console.ReadLine();
            Console.WriteLine();

            Game game = new(playerName!); 
            game.Start();
        }
    }
}