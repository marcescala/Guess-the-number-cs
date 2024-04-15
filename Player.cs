using System;
using System.Collections.Generic;

namespace GuessTheNumber;

abstract class Player

{
    public string Name { get; set; }
    public int LastAttempt { get; set; }
    public List<int> Attempts { get; }

    protected Player(string playerName)
    {
        Name = playerName;
        LastAttempt = 0; // Inicializa el último intento en cero al crear una nueva instancia
        Attempts = new List<int>(); // Inicializa la lista de intentos
    }

    public void GetLastGuess()
    {
        Console.WriteLine($"Tu último intento fue: {LastAttempt}");
    }

    public abstract int MakeGuess();

   
}   