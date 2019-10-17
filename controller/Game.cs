using System;

namespace controller
{
  class Game
  {
    view.View View = new view.View();
    controller.Score Score = new Score();
    public void StartGame()
    {
      View.DisplayGreeting();

      View.SetPlayerName();
      var name = Console.ReadLine();

      if (CheckPlayerNameLength(name))
      {
        View.GreetPlayer(name);
      }
      else
      {
        View.Error("Name not long enough needs to be at least 3 char long");
      }

    }

    private bool CheckPlayerNameLength(string name)
    {
      return name.Length >= 3;
    }

    private void CurrentScore()
    {
      View.DisplayPlayerScore(Score.GetPlayerScore());
      View.DisplayComputerScore(Score.GetComputerScore());
    }
  }
}