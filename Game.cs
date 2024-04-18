using System.Reflection.Metadata;

namespace GuessTheNumber;

public class Game
{
    private int NumberRandom { get; set; } // Almacena numero ramdom
    private Player HumanPlayer { get; set; }
    private Player AiPlayer { get; set; }


    // Constructor que inicializa el número aleatorio y crea un nuevo objeto Player
    public Game(string playerName)
    {
        Random random = new();
        bool isHumanFirst = random.Next(0, 2) == 0;

        RandomNumberGenerator();

        if (isHumanFirst)
        {
            HumanPlayer = new HumanPlayer(playerName);
            AiPlayer = new AiPlayer("AI Player");
        }
        else
        {
            AiPlayer = new AiPlayer("AI Player");
            HumanPlayer = new HumanPlayer(playerName);
        }
    }
    private void RandomNumberGenerator() // Metodo que genera un número aleatorio entre 1 y 100
    {
        Random random = new();
        NumberRandom = random.Next(1, 101); // utilizando la clase Random
    }
    private void CheckGuess(int guess)
    {
        if (guess < NumberRandom)
    {
        Console.WriteLine("Muy bajo");
        Console.WriteLine();
    }
    else if (guess > NumberRandom)
    {
        Console.WriteLine("Muy alto");
        Console.WriteLine();
    }
    }
    public void Start() // Comienza el juego
    {
        Player currentPlayer = HumanPlayer; // Inicia el juego con humanPlayer

        while (true)
        {
            // Solicita al jugador actual que haga su intento
            int input = currentPlayer.MakeGuess();

            CheckGuess(input);


            if (input == NumberRandom)
            {
                
                Console.WriteLine();
                Console.WriteLine($"Felicidades, has adivinado el número");
                Console.WriteLine();
                Console.WriteLine($"Adivinaste en {currentPlayer.Attempts.Count} intentos.");
                Console.WriteLine("Intentos realizados:");
                foreach (int attempt in currentPlayer.Attempts)
                {
                    Console.Write(attempt + " - ");
                }
                Console.WriteLine();
                break; // Sale del bucle si se adivina el número
            }
            currentPlayer = (currentPlayer == HumanPlayer) ? AiPlayer : HumanPlayer;


        }

    }
}
