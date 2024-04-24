using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber;


namespace Guess_the_number.Tests
{
    [TestClass]
    public class GameTest
    {

    
        [TestMethod]
        public void TestCheckGuess_LowerThanNumber()
        {

            Game game = new Game("TestPlayer");
            int guess = game.NumberRandom - 1; // el intento de la jugadora es menor que el número ramdom

            bool result = game.CheckGuess(guess);

            Assert.IsTrue(result); // Esperamos que la función devuelva true

        }

        [TestMethod]
        public void TestCheckGuess_HigherThanNumber()
        {

            Game game = new Game("TestPlayer");
            int guess = game.NumberRandom + 1; // el intento de la jugadora es mayor que el número ramdom

            bool result = game.CheckGuess(guess);

            Assert.IsTrue(result); // Esperamos que la función devuelva true

        }

        [TestMethod]
        public void TestCheckGuess_CorrectGuess()
        {

            Game game = new Game("TestPlayer");
            int guess = game.NumberRandom; // Suponemos que el intento de la jugador es igual al número ramdom

            bool result = game.CheckGuess(guess);

            Assert.IsTrue(result); // Esperamos que la función devuelva true

        }
    }
}