public class Player
{
    public int points = 300;

    public int incorrectGuess()
    {
        return points - 75;
    }

    public int correctGuess()
    {
        return points + 100;
    }
}