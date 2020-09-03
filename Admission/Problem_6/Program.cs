using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            if (N > 15)
            {
                Console.WriteLine("It should be less than 15");
            }
            else
            {
                var nth = 0;
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(Fib(nth));
                    nth++;
                }
            }
        }

        static int Fib(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            else if (N == 1)
            {
                return 1;
            }
            else
            {
                return (Fib(N - 1) + Fib(N - 2));
            }
        }
    }
}
