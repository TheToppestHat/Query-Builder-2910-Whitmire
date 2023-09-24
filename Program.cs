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
            Console.WriteLine("Now entering the bulbasaur back");
            con.Create(test);

            Console.WriteLine("Now entering a game");
            BannedGame tester = new BannedGame(137, "tester", "testing games", "idk zimbawe", "idk you tell me");
            con.Create(tester);
            Console.WriteLine("Now removing the game again");
            con.Delete(tester);

            //Console.WriteLine("This will erase the databases");
            //con.DeleteAll(test);
            //con.DeleteAll(tester);

            //Console.WriteLine("This will rewrite them from CSV");
            //con.CreateAll(test);
            //con.CreateAll(tester);


            /*Greetings Will, sorry for the little speel here, but I have tried and tried again to get this create all portion of the lab complete, 
             * however I have not found a suitable solution in the time we have had to work on this.
             * I am very sorry and I understand the failure here. I ask to please meet with you once we are back on campus to
             * look at this again and help me see maybe where I was looking in the wrong place?
             * I was trying to pull the csv files data in but it just wasnt working(ik the file is wrong but didnt want it to crash.)
             * Again I am sorry, I have 0 clue if you give partial credit as I did complete almost everything,
             * but I understand if you do not. I would primarily like to set up a small talk so you can help me better understand
             * my issues with this code. Thank you and have a good day
             * 
             * Also, I made the delete alls not running by default so you wouldnt delete them by mistake lol,
             * but you can turn them on and they should remove the data if my code is correct.
            */



        }
    }
}