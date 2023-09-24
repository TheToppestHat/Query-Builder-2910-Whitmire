using Microsoft.Data.Sqlite;
using Query.QueryBuilderStarterKit;
using System.Formats.Asn1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Query
{
    public class Program : FileRoot
    {
        static string root = Root;
        static string dbPath = root + "\\data.db";
        static void Main(string[] args)
        {
            List<Pokemon> pokemonList = new List<Pokemon>();
            List<BannedGame> gameList = new List<BannedGame>();

            Pokemon test = new Pokemon(1,1,"Bulbasaur","", "Grass", "Poison", 318, 45, 49, 49, 65, 65, 45, 1);

            QueryBuilder con = new QueryBuilder(dbPath);

            Console.WriteLine("Now removing a bulbasaur");
            con.Delete(test);
            Console.Write("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Now entering the bulbasaur back");
            con.Create(test);
            Console.Write("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Now entering a game");
            BannedGame tester = new BannedGame(137, "tester", "testing games", "idk zimbawe", "idk you tell me");
            con.Create(tester);
            Console.Write("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Now removing the game again");
            con.Delete(tester); 
            Console.Write("Press enter to continue...");
            Console.ReadLine();


            Console.WriteLine("This will erase the databases");
            con.DeleteAll(test);
            con.DeleteAll(tester);
            Console.Write("Press Enter when you are done checking if the data deleted.");
            Console.ReadLine();

            Console.WriteLine("This will rewrite them from CSV");
            con.CreateAll(test);
            con.CreateAll(tester);
        }
    }
}