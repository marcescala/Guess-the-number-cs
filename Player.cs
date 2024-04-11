namespace GuessTheNumber;

public class Player

{
    public string Name { get; set; }
    public int LastAttempt { get; set; }

    // Constructor que inicializa el último intento en cero y establece el nombre
    public Player(string playerName)
    {
        Name = playerName;
        LastAttempt = 0; // Inicializa el último intento en cero al crear una nueva instancia
    }

    public int MakeGuess()
    {
        Console.WriteLine($"{Name}, ingresa tu número:");
        if (int.TryParse(Console.ReadLine(), out int guess))
        {
            return guess;
        }
        else
        {
            Console.WriteLine("Por favor ingresa un número válido.");
            return MakeGuess(); // Llamada recursiva si no se ingresa un número válido
        }

    }


}