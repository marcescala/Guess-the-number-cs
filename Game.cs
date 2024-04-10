using System;
using System.IO;

namespace game
{
    public class MyFunctions
    {
        public void GenerateAndSaveNum()
        {
            Random random = new Random();
            int numberRandom = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
            // Console.WriteLine(numberRandom);

            Console.WriteLine("Por favor, ingresa un número entre 1 y 100:");

            // Leer el número ingresado por el usuario
            int input = Int32.Parse(Console.ReadLine());


            while (input != numberRandom)
            {
                if (input < numberRandom)
                {
                    Console.WriteLine("Debes ingresar un número mayor");
                    input = int.Parse(Console.ReadLine());

                }
                else if (input > numberRandom)
                {
                    Console.WriteLine("Debes ingresar un número menor");
                    input = int.Parse(Console.ReadLine());
                }

                    }
                Console.WriteLine("Felicidades, has adivinado el número");
        }
    }
}