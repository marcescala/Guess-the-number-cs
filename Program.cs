using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("¡Bienvenida! Por favor, ingresa tu nombre:");
            string? playerName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{playerName}  Vamos a jugar! Adivina un número entre 1 y 100");
            Console.WriteLine();
            
            Game game = new(playerName); // Crear una instancia de Game con el nombre del jugador
            game.Start(); 
        }
    }
}