using System;
using System.IO;


namespace GuessTheNumber
{
    public class Game
    {
        public int numberRandom { get; set; } // Almacena numero ramdom
        public Player Player { get; set; } // Propiedad que almacena una instancia de Player
        
        // Constructor que inicializa el número aleatorio y crea un nuevo objeto Player
        public Game(string playerName)
        {
            Random random = new Random();
            numberRandom = random.Next(1, 101); // Inicializa el número aleatorio

            Player = new Player(playerName); // Crea una nueva instancia de Player con el nombre proporcionado
        }
        public void Start() // Comienza el juego
        {
            
             int input = Player.MakeGuess();


            while (input != numberRandom)
            {
                if (input < numberRandom)
                {
                    Console.WriteLine("Debes ingresar un número mayor");
                }
                else if (input > numberRandom)
                {
                    Console.WriteLine("Debes ingresar un número menor");
                }
                input = Player.MakeGuess();
               

                    }
                Console.WriteLine("Felicidades, has adivinado el número");
        }
    }
}