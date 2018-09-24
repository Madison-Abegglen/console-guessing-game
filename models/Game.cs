using System;
namespace guess_challenge.Models
{
  public class Game
  {

    private int _secretNumber { get; set; }

    public int Guesses { get; set; }

    public bool Won { get; set; }

    public string Guess(int guess)
    {
      Guesses++;
      if (guess > _secretNumber)
      {
        return "That number was too high.";
      }
      else if (guess < _secretNumber)
      {
        return "That was definitley too low of a number.";
      }
      Won = true;
      return "You guessed it, that was correct.";
    }

    public Game()
    {
      Random rnd = new Random();
      _secretNumber = rnd.Next(1, 101);

      Won = false;
      Guesses = 0;
    }
  }
}