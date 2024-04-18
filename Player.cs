namespace GuessTheNumber;

abstract class Player

{
    public string Name { get; set; }
    public int LastAttempt { get; set; }
    public List<int> Attempts { get; private set;}

    protected Player(string name)
    {
        Name = name;
        LastAttempt = 0; // Inicializa el último intento en cero al crear una nueva instancia
        Attempts = []; // Inicializa la lista de intentos
    }


    public abstract int MakeGuess();

   
}   