using System.Reflection.Metadata;

namespace GuessTheNumber;
//otro comentario de prueba
public class Game
{
    public int NumberRandom { get; set; } // Almacena numero ramdom
    private Player HumanPlayer { get; }
    private Player AiPlayer { get; }


    // Constructor que inicializa el número aleatorio y crea un nuevo objeto Player
    public Game(string playerName)
    {


        RandomNumberGenerator();


        HumanPlayer = new HumanPlayer(playerName);
        AiPlayer = new AiPlayer("AI Player");

    }
    public void RandomNumberGenerator() // Metodo que genera un número aleatorio entre 1 y 100
    {
        Random random = new();
        NumberRandom = random.Next(1, 101); // utilizando la clase Random
    }
    public bool CheckGuess(int guess)
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
        return true;
    }
    public void Start() // Comienza el juego
    {
        Player currentPlayer = HumanPlayer;

        while (true)
        {
            // Solicita al jugador actual que haga su intento
            int input = currentPlayer.MakeGuess();

            CheckGuess(input);


            if (input == NumberRandom)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine($"Felicidades, has adivinado el número");
                Console.WriteLine();
                Console.ResetColor();
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
