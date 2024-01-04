using System.Diagnostics;
using System.Linq.Expressions;

namespace MathGame;

internal class Helpers
{
    internal static Data data = new Data();
    internal static void AddToHistory(string nickname, GameType gameType, Stopwatch time, int gameScore)
    {
        Game game = new Game
        {
            NickName = nickname,
            Type = gameType,
            Date = DateTime.Now,
            Time = time.Elapsed,
            Score = gameScore
        };

        data.Add(game);
    }
    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("\t\tGames History");
        Console.WriteLine("--------------------------------------------");
        foreach (var game in data.Games) Console.WriteLine(game.GetInfo());
        Console.WriteLine("\nPress any key to return to Main Menu");
        Console.ReadLine();
    }
    internal static bool CheckAnswer(int answer, int[] numbers, char operation)
        {
            Dictionary<char, int> result = new Dictionary<char, int>()
            {
                { '+', numbers[0] + numbers[1] },
                { '-', numbers[0] - numbers[1] },
                { '*', numbers[0] * numbers[1] },
            };

            if (numbers[1] != 0)
            {
                result.Add('/', numbers[0] / numbers[1]);
            }

            return answer == result[operation];
        }
    internal static int[] RandomNumbers(int difficulty, char operation)
        {
            Random random_number = new();
            
            switch (difficulty)
            {
                case 1:
                    if (operation == '/') return [random_number.Next(0, 5), random_number.Next(1, 5)];
                    return [random_number.Next(0, 5), random_number.Next(1, 5)];
                case 2:
                    if (operation == '/') return [random_number.Next(0, 20), random_number.Next(1, 20)];
                    return [random_number.Next(0, 20), random_number.Next(1, 20)];
                case 3:
                    if (operation == '/') return [random_number.Next(0, 50), random_number.Next(1, 50)];
                    return [random_number.Next(0, 50), random_number.Next(1, 50)];
            }
            return [];
        }
    internal static bool CheckDifficultyInput(string difficulty)
    {
        return int.TryParse(difficulty, out _) && int.Parse(difficulty) >= 1 && int.Parse(difficulty) <= 3;
    }
    internal static string GetInput(string message)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        while (input == "")
            input = GetInput(message);
            
        return input;
    }
    internal static bool CheckInteger(string questions)
    {
        return int.TryParse(questions, out _);
    }
}