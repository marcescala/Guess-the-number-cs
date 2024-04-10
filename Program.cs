using System;
using game;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenida,vamos a jugar! Adivina un número entre 1 y 100");
            Console.WriteLine();
            
            MyFunctions myFunctions = new MyFunctions(); // Crear una instancia de MyFunctions
            myFunctions.GenerateAndSaveNum(); // Llamar al método GenerateAndSaveNum


        }

    }

}
