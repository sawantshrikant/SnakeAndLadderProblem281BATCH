
using SnakeAndLadderProblem281Batch;
using System; 
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Snake And Ladder!");
        Start start = new Start();
        PlayerRollsTheDie playerRollsTheDie = new PlayerRollsTheDie();

        int roll = playerRollsTheDie.RollDie();
        start.PlaySnakeAndLadder(roll);
    }
}