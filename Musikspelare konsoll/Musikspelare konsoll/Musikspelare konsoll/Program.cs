// See https://aka.ms/new-console-template for more information
using WMPLib;

WindowsMediaPlayer spelare = new WindowsMediaPlayer();

string[] genre = { "Jazz", "Funk" };
string[,] låtar = { { "Autumn Leaves", "Take Five" }, { "Just Around The Corner", "Come On Come Over" } };

Console.WriteLine("Välkommen till Alexanders musikspelare!");
Console.WriteLine("Du kommer att få välja mellan två genre där respektive genre har 2 låtar att välja mellan");
Console.WriteLine("Tryck på enter för att starta...");
var start = Console.ReadKey();

while (start.Key != ConsoleKey.Enter)
{
    Console.Clear();
    Console.WriteLine("Du behöver trycka på enter för att starta...");
    start = Console.ReadKey();
}
if (start.Key == ConsoleKey.Enter )
{
    Console.Clear();
    Console.WriteLine("Skriv vilken av följande genre vill du lyssna på: ");
    Console.WriteLine($"\n{genre[0]}\t{genre[1]}" );
    string genreVal = Console.ReadLine();
}




