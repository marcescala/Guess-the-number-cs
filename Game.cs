using System;
using System.IO;


namespace GuessTheNumber
{
    public class Game
    {
        private int numberRandom { get; set; } // Almacena numero ramdom
        private Player Player { get; set; } // Propiedad que almacena una instancia de Player

        // Constructor que inicializa el número aleatorio y crea un nuevo objeto Player
        public Game(string playerName)
        {
            RandomNumberGenerator(); // llama el metodo que genera el numero aleatorio

            Player = new Player(playerName); // Crea una nueva instancia de Player con el nombre proporcionado
        }
        private void RandomNumberGenerator() // Metodo que genera un número aleatorio entre 1 y 100
        {
            Random random = new Random();
            numberRandom = random.Next(1, 101); // utilizando la clase Random
        }
        public void Start() // Comienza el juego
        {

            int input = Player.MakeGuess(); // Asigna el resultado de llamar al metodo de la clase Player


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
                input = Player.MakeGuess(); // Actualiza el valor de input 


            }
            Console.WriteLine($"Felicidades, has adivinado el número");
        }
    }
}