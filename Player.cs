public class Player
{
    public int points = 300;

    public void incorrectGuess()
    {
        points = points - 75;
    }

    public void correctGuess()
    {
        points = points + 100;
    }
}