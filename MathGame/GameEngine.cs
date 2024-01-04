using System.Diagnostics;

namespace MathGame;

class GameEngine
{
    static Random random_number = new Random();
    static int[] numbers = Array.Empty<int>();
    public List<string> records = new List<string>();
    Stopwatch stopwatch = new Stopwatch();

    internal void RandomGame(int difficulty, int questions_amount, string nickname)
    {
        string answer;
        int score = 0;
        char[] operations = { '+', '-', '*', '/' };

        stopwatch.Start();
        for (int i = 0; i < questions_amount; i++)
        {
            Console.WriteLine($"Question {i + 1} of {questions_amount} \tScore: {score}");
            char operation = operations[random_number.Next(operations.Length - 1)];
            numbers = Helpers.RandomNumbers(difficulty, operation);

            answer = Helpers.GetInput($"How much is {numbers[0]} {operation} {numbers[1]}");

            while(!Helpers.CheckInteger(answer))
                answer = Helpers.GetInput($"How much is {numbers[0]} {operation} {numbers[1]}");

            if (Helpers.CheckAnswer(int.Parse(answer), numbers, operation)) score++;
        }
        stopwatch.Stop();
        Helpers.AddToHistory(nickname, GameType.Random, stopwatch, score);
        Console.WriteLine($"Your score was: {score}");
        Console.ReadKey();
    }

    internal void AdditionGame(int difficulty, int questions_amount, string nickname)
    {
        string answer;
        int score = 0;

        stopwatch.Start();
        for (int i = 0; i < questions_amount; i++)
        {
            Console.WriteLine($"Question {i + 1} of {questions_amount} \tScore: {score}");
            numbers = Helpers.RandomNumbers(difficulty, '+');

            answer = Helpers.GetInput($"How much is {numbers[0]} + {numbers[1]}");

            while(!Helpers.CheckInteger(answer))
                answer = Helpers.GetInput($"How much is {numbers[0]} + {numbers[1]}");

            if (Helpers.CheckAnswer(int.Parse(answer), numbers, '+')) score++;
        }
        stopwatch.Stop();
        Helpers.AddToHistory(nickname, GameType.Addition, stopwatch, score);
        Console.WriteLine($"Your score was: {score}");
        Console.ReadKey();
    }

    internal void SubtractionGame(int difficulty, int questions_amount, string nickname)
    {
        string answer;
        int score = 0;

        stopwatch.Start();
        for (int i = 0; i < questions_amount; i++)
        {
            Console.WriteLine($"Question {i + 1} of {questions_amount} \tScore: {score}");
            numbers = Helpers.RandomNumbers(difficulty, '-');

            answer = Helpers.GetInput($"How much is {numbers[0]} - {numbers[1]}");

            while(!Helpers.CheckInteger(answer))
                answer = Helpers.GetInput($"How much is {numbers[0]} - {numbers[1]}");

            if (Helpers.CheckAnswer(int.Parse(answer), numbers, '-')) score++;
        }
        stopwatch.Stop();
        Helpers.AddToHistory(nickname, GameType.Subtraction, stopwatch, score);
        Console.WriteLine($"Your score was: {score}");
        Console.ReadKey();
    }

    internal void MultiplicationGame(int difficulty, int questions_amount, string nickname)
    {
        string answer;
        int score = 0;

        stopwatch.Start();
        for (int i = 0; i < questions_amount; i++)
        {
            Console.WriteLine($"Question {i + 1} of {questions_amount} \tScore: {score}");
            numbers = Helpers.RandomNumbers(difficulty, '*');

            answer = Helpers.GetInput($"How much is {numbers[0]} * {numbers[1]}");

            while(!Helpers.CheckInteger(answer))
                answer = Helpers.GetInput($"How much is {numbers[0]} * {numbers[1]}");

            if (Helpers.CheckAnswer(int.Parse(answer), numbers, '*')) score++;
        }
        stopwatch.Stop();
        Helpers.AddToHistory(nickname, GameType.Multiplication, stopwatch, score);
        Console.WriteLine($"Your score was: {score}");
        Console.ReadKey();
    }

    internal void DivisionGame(int difficulty, int questions_amount, string nickname)
    {
        string answer;
        int score = 0;

        stopwatch.Start();
        for (int i = 0; i < questions_amount; i++)
        {
            Console.WriteLine($"Question {i + 1} of {questions_amount} \tScore: {score}");
            numbers = Helpers.RandomNumbers(difficulty, '/');

            answer = Helpers.GetInput($"How much is {numbers[0]} / {numbers[1]}");

            while(!Helpers.CheckInteger(answer))
                answer = Helpers.GetInput($"How much is {numbers[0]} / {numbers[1]}");

            if (Helpers.CheckAnswer(int.Parse(answer), numbers, '/')) score++;
        }
        stopwatch.Stop();
        Helpers.AddToHistory(nickname, GameType.Division, stopwatch, score);
        Console.WriteLine($"Your score was: {score}");
        Console.ReadKey();
    }
}