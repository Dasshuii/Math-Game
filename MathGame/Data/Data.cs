using System.Globalization;

namespace MathGame;

class Data 
{
    public List<Game> Games { get; set; }
    private const string fileName = "Records.txt";
    public Data()
    {
        Games = new List<Game>();

        string line;
        
        if (!File.Exists(fileName)) File.Create(fileName).Dispose();

        using(StreamReader file = new StreamReader(fileName))
        {
            while((line = file.ReadLine()) != null)
            {
                string [] words = line.Split(',');
                Games.Add(new Game 
                {
                    NickName = words[0],
                    Type = Enum.Parse<GameType>(words[1]),
                    Date = DateTime.Parse(words[4]),
                    Time = TimeSpan.ParseExact(words[3], @"m\:s\:fff", CultureInfo.InvariantCulture),
                    Score = int.Parse(words[2])
                });
            }
        }
    }

    internal void Add(Game game)
    {
        Games.Add(game);

        using(StreamWriter file = File.AppendText(fileName))
            file.WriteLine(game);
    }
}