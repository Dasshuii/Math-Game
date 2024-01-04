using MathGame;

var menu = new Menu();

var date = DateTime.UtcNow;

Console.Clear();
string nickname = Helpers.GetInput("Please type your nickname");

menu.ShowMenu(nickname, date);

