using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(60);
            numbers.Add(50);
            numbers.Add(70);
            numbers.Add(40);
            numbers.Add(90);

            var res = from n in numbers where n > 50; 
        }
    }
}



//Sir, I did not study this topic. This Linq query is my assumption.