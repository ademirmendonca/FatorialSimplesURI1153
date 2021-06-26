using System;

namespace FatorialSimplesURI1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int total = 1;
            
            for (int i = 1; i <= n; i++)
            {
                total = total * i;
            }

            Console.WriteLine(total);
        }
    }
}
