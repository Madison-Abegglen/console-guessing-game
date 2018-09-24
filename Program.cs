using System;
using System.Collections.Generic;
using guess_challenge.Models;

namespace guess_challenge
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Clear();
      System.Console.WriteLine("Welcome to the number guessing game. Lets play!");

      Game game = new Game();
      bool playing = true;

      while (playing)
      {
        System.Console.WriteLine($"Guess and enter a number between 1 and 100 (so far you have guessed {game.Guesses} times).");
        string guessString = Console.ReadLine();
        int guess;
        if (!Int32.TryParse(guessString, out guess) || guess < 1 && guess > 100)
        {
          System.Console.WriteLine("Invalid number, try again.");
          continue;
        }
        string result = game.Guess(guess);
        System.Console.WriteLine(result);
        if (game.Won)
        {
          System.Console.WriteLine("Great job, that was correct. Want to play again? (Y/N)");
          string again = Console.ReadLine();
          if (again.Length > 0 && again.ToLower()[0] == 'n')
          {
            playing = false;
          }
          else
          {
            game = new Game();
          }
        }

      }

      System.Console.WriteLine("Until we meet again...");
    }
  }
}
