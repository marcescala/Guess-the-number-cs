using System;
using System.IO;


namespace GuessTheNumber
{
    public class Game
    {
        private int numberRandom { get; set; } // Almacena numero ramdom
        private Player HumanPlayer { get; set; }
        private Player AiPlayer { get; set; }


        // Constructor que inicializa el número aleatorio y crea un nuevo objeto Player
        public Game(string playerName)
        {
            RandomNumberGenerator(); // llama el metodo que genera el numero aleatorio

            Player HumanPlayer = new HumanPlayer(playerName);

            Player AiPlayer = new AiPlayer(playerName);
        }
        private void RandomNumberGenerator() // Metodo que genera un número aleatorio entre 1 y 100
        {
            Random random = new Random();
            numberRandom = random.Next(1, 101); // utilizando la clase Random
        }
        public void Start() // Comienza el juego
        {
            Player currentPlayer = HumanPlayer; // Inicia el juego con humanPlayer

            while (true)
            {
                // Solicita al jugador actual que haga su intento
                int input = currentPlayer.MakeGuess();



                if (input < numberRandom)
                {
                    Console.WriteLine("Debes ingresar un número mayor");
                }
                else if (input > numberRandom)
                {
                    Console.WriteLine("Debes ingresar un número menor");
                }
                else
                {
                    Console.WriteLine($"Felicidades, has adivinado el número");
                    break; // Sale del bucle si se adivina el número
                }
                currentPlayer = (currentPlayer == HumanPlayer) ? AiPlayer : HumanPlayer;


            }
            Console.WriteLine($"Felicidades, has adivinado el número");
        }
    }
}
