namespace GuessTheNumber
{
    class HumanPlayer : Player
    {


        public HumanPlayer(string playerName) : base(playerName)
        {
            Name = playerName;
        }
        public override int MakeGuess()
        {
            Console.WriteLine($"Es tu turno {Name}, ingresa un número:");
            Console.WriteLine();
            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                if (guess >= 1 && guess <= 100)
                {
                    Attempts.Add(guess);
                    return guess;
                }
                else
                {
                    Console.WriteLine("Por favor ingresa un número válido entre 1 y 100.");
                    Console.WriteLine();
                    return MakeGuess(); // Llamada recursiva si no se ingresa un número válido
                }
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número válido.");
                Console.WriteLine();
                return MakeGuess(); // Llamada recursiva si no se ingresa un número válido
            }
        }

    }

}

