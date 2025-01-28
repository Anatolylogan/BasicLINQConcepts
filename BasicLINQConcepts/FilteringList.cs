using System;
using System.Linq;

namespace BasicLINQConcepts
{
    class FilteringList
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 5, 15, 20, 3, 10, 8, 25 };

            List<int> filteredNumbers = numbers.Where(n => n > 10).ToList();

            string result = string.Join(",", filteredNumbers);

            Console.WriteLine("Числа больше 10:");
            Console.WriteLine(result);
        }
    }
}