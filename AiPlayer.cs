namespace GuessTheNumber
{
    class AiPlayer : Player
    {
        private int GuessRandom { get; set; }


        public AiPlayer(string playerName) : base(playerName)
        {
        
            Random random = new ();
            GuessRandom = random.Next(1, 101);

        }


        public override int MakeGuess()
        {
            Random random = new ();
            int GuessRandom = random.Next(1, 101);
            Console.WriteLine($"Es el turno de la computadora, su número es: {GuessRandom}");
            Attempts.Add(GuessRandom);
            return GuessRandom;
            
        }
    }

}

