using Bowling_Game_Kata;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        int[] pins = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 };
        var game = new Game();
        game.Roll(pins);
        var result = game.Score();
        Console.WriteLine(result);
    }
}
