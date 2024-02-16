using System;
namespace uppgift6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet kommer att rita ut en triangel.");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Bestäm triangelns höjd: ");
                int höjd = int.Parse(Console.ReadLine());
                Triangel(höjd);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Triangel(int höjd)
        {
            for (int i = 0; i < höjd; i++)
            {
                for (int j = höjd-1; j > i; j--)
                {
                    Console.Write(" ");
                }
                string tecken = new string('*', i + 1);
                Console.Write(tecken);
                tecken = new string('*', i);
                Console.Write(tecken);
                Console.WriteLine();
            }
        }
    }
}