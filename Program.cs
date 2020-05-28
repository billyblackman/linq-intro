using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits.Where(fruits => fruits.StartsWith("L"));

            List<string> LFruitsList = LFruits.ToList();

            LFruitsList.ForEach(fruit => Console.WriteLine(fruit));
        }
    }
}