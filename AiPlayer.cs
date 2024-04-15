namespace GuessTheNumber
{
    abstract class AiPlayer : Player
    {
        private Random random = new();
        public new string Name { get; set; }

        public AiPlayer(string playerName) : base(playerName)
        {
            Name = playerName;

        }
    }

    public override int MakeGuess()
    {
        int guess = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100 (ambos inclusive)
        Console.WriteLine($"AI Player's guess: {guess}");

        LastAttempt = guess;
        Attempts.Add(guess); // Agrega el nuevo intento al historial
        return guess;
    }

}

