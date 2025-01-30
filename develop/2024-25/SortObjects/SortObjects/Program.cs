
namespace SortObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] names = { "A", "AA", "B", "C", "CC", "D", "DD", "X"};
            List<Company> list = new List<Company>();
            for(int i=0; i<names.Length; i++)
            {
                list.Add(new Company(names[i], "ABC"));
                list[i].Count = rnd.Next(100, 1000);
                Console.WriteLine(list[i]);
                if (rnd.Next(100) > 50) list[i].Valid = true;
            }
            Console.WriteLine("----------------------");
            list.Sort();
            foreach (Company company in list)
                Console.WriteLine(company);
        }
    }
}
