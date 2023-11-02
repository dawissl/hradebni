using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        
        for(int i = 0; i < 20; i++)
        {
            
            Console.WriteLine($"{GetRandom()}");
        }
    }

    public static int GetRandom()
    {
        long timestamp = -1 * Environment.TickCount;
        int[] result = timestamp.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        /// last three digits of number
        int a = result[result.Length-1];
        int b = result[result.Length-2];
        int c = result[result.Length-3];
        int res = 1;
        while (result.Length > 1)
        {
            for(int i=0;i<result.Length; i++)
            {
                if(i%2 == 0)
                {
                    res += result[i];
                }
                else
                {
                    res /= result[i];
                }
            }
        }

        Console.WriteLine($"{a} - {b} - {c}");


        return a;
    }
}