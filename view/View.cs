using System;

namespace view
{
  class View
  {
    public void DisplayGreeting()
    {
      Console.WriteLine("Welcome to this wonderful game");
    }

    public void DisplayPlayerScore(int score)
    {
      Console.WriteLine("The player has a total of: {0}", score);
    }

    public void DisplayComputerScore(int score)
    {
      Console.WriteLine("The Computer has a total of: {0}", score);
    }

    public void SetPlayerName()
    {
      Console.WriteLine("Which name do you want to use?");
    }

    public void GreetPlayer(string name)
    {
      Console.WriteLine("Welcome to the game {0}.", name);
    }

    public void Error(string error)
    {
      Console.WriteLine(error);
    }

  }
}

// ⚀ ⚁ ⚂ ⚃ ⚄ ⚅