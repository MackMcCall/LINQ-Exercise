namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>() 
            { 
                "Super Smash Bros Ultimate", 
                "DOOM", 
                "Mario Party", 
                "Splatoon 3", 
                "EDF 4.1"
            };
            var sortedGames = videogames.OrderBy(x => x.Length);
            foreach (string game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
