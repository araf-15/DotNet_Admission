using System;
using System.Collections.Generic;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Person> list = new Dictionary<int, Person>();
            list.Add(1, new Person("Araf"));
            list.Add(2, new Person("Hasan"));
            list.Add(3, new Person("Kallol"));
            list.Add(4, new Person("Rakib"));
            list.Add(5, new Person("Jakir"));

            foreach (var n in list)
            {
                Console.WriteLine("ID: "+n.Key+" Name: "+n.Value.ToString());
            }

        }
    }
}
