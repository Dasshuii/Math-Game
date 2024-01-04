using System.Diagnostics;

namespace MathGame;

internal class Game
{
    public String NickName { get; set; }
    public GameType Type { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public int Score { get; set; }
    public override string ToString()
    {
        return $"{NickName},{Type},{Score},{Time.Minutes}:{Time.Seconds}:{Time.Milliseconds},{Date.ToString("d")}";
    }  

    public string GetInfo()
    {
        return $"{NickName} | {Type} | {Score}pts | {Time.Minutes}:{Time.Seconds}:{Time.Milliseconds} | {Date.ToString("d")}";
    }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}