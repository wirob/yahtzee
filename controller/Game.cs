namespace controller
{
  class Game
  {
    view.View View = new view.View();
    controller.Score Score = new Score();
    public void StartGame()
    {
      View.DisplayGreeting();

      CurrentScore();
    }

    private void CurrentScore()
    {
      View.DisplayPlayerScore(Score.GetPlayerScore());
      View.DisplayComputerScore(Score.GetComputerScore());
    }
  }
}