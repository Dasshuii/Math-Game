namespace MathGame;

internal class Menu
{
    GameEngine gamesClass = new();

    internal void ShowMenu(string nickname, DateTime date)
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Hello {nickname}. It's {date}. This is your math's game. That's great that you're working on improving yourself");

        bool isGameOn = true;

        do
        {
            // Console.Clear();
            Console.WriteLine(@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
            Console.WriteLine("---------------------------------------------");

            string gameSelected = Console.ReadLine();

            // Console.Clear();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    string questions_amount = Helpers.GetInput("Amount of questions: ");
                    while(!Helpers.CheckInteger(questions_amount)) questions_amount = Helpers.GetInput("Amount of questions: ");

                    string difficulty = Helpers.GetInput("Select the difficulty:\n1 - Easy\n2 - Medium\n3 - Hard\nDifficulty:");
                    while(!Helpers.CheckDifficultyInput(difficulty)) difficulty = Helpers.GetInput("Difficulty: ");

                    gamesClass.AdditionGame(int.Parse(difficulty), int.Parse(questions_amount), nickname);
                    break;
                case "s":
                    questions_amount = Helpers.GetInput("Amount of questions: ");
                    while(!Helpers.CheckInteger(questions_amount)) questions_amount = Helpers.GetInput("Amount of questions: ");

                    difficulty = Helpers.GetInput("Select the difficulty:\n1 - Easy\n2 - Medium\n3 - Hard\nDifficulty:");
                    while(!Helpers.CheckDifficultyInput(difficulty)) difficulty = Helpers.GetInput("Difficulty: ");
                    
                    gamesClass.SubtractionGame(int.Parse(difficulty), int.Parse(questions_amount), nickname);
                    break;
                case "m":
                    questions_amount = Helpers.GetInput("Amount of questions: ");
                    while(!Helpers.CheckInteger(questions_amount)) questions_amount = Helpers.GetInput("Amount of questions: ");

                    difficulty = Helpers.GetInput("Select the difficulty:\n1 - Easy\n2 - Medium\n3 - Hard\nDifficulty:");
                    while(!Helpers.CheckDifficultyInput(difficulty)) difficulty = Helpers.GetInput("Difficulty: ");

                    gamesClass.MultiplicationGame(int.Parse(difficulty), int.Parse(questions_amount), nickname);
                    break;
                case "d":
                    questions_amount = Helpers.GetInput("Amount of questions: ");
                    while(!Helpers.CheckInteger(questions_amount)) questions_amount = Helpers.GetInput("Amount of questions: ");

                    difficulty = Helpers.GetInput("Select the difficulty:\n1 - Easy\n2 - Medium\n3 - Hard\nDifficulty:");
                    while(!Helpers.CheckDifficultyInput(difficulty)) difficulty = Helpers.GetInput("Difficulty: ");

                    gamesClass.DivisionGame(int.Parse(difficulty), int.Parse(questions_amount), nickname);
                    break;
                case "q":
                    Console.WriteLine($"Goodbye, {nickname}");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (isGameOn);
    }
}