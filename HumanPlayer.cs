using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class HumanPlayer : Player
    {
        public new string Name { get; set; }

        public HumanPlayer(string playerName): base(playerName)
        {
            Name = playerName;    
        }
        public override int  MakeGuess()
        {
            Console.WriteLine($"{Name}, ingresa tu número:");
        if (int.TryParse(Console.ReadLine(), out int guess))
        {
            LastAttempt = guess;
            Attempts.Add(guess); // Agrega el nuevo intento al historial
            return guess;
        }
        else
        {
            Console.WriteLine("Por favor ingresa un número válido.");
            return MakeGuess(); // Llamada recursiva si no se ingresa un número válido
        }
        }

    }
   
}

