using System.Text.RegularExpressions;

namespace RegularniVyrazy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte vstupní řetězec pro kontrolu:");
            string vstup = Console.ReadLine();
            //string vzor = @"\b[a-z]+@[a-z]+\.(cz|com|org)\b";
            //string vzor = @"\b[^5-9]+\b";
           // string vzor = @"\bx[a-z]?\b";
           string vzor = @"\b(ab)+(cd)+\b";
            MatchCollection shody = Regex.Matches(vstup, vzor);
            foreach (Match match in shody) {
                Console.WriteLine($"Shoda {match.Value} na pozici {match.Index}");
            }
        }
    }
}
