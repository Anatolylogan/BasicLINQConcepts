using System;
using System.Linq;
using System.Reflection;

namespace BasicLINQConcepts
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 5, 15, 20, 3, 10, 8, 25 };
            var filteredNumbers = numbers.Where(n => n > 10).ToList();
            string result = string.Join(",", filteredNumbers);
            Console.WriteLine("Числа больше 10:");
            Console.WriteLine(result);

            List<string> words = new List<string> { "яблоко", "банан", "груша", "ананас", "вишня" };
            var sortedWords = words.OrderBy(words => words).ToList();
            string result2 = string.Join(",", sortedWords);
            Console.WriteLine("Отсортированные строки: ");
            Console.WriteLine(result2);

            List<int> numbers2 = new List<int> { 2, 3, 4, 5 };
            List<int> squaredNumbers = numbers2.Select(n => n * n).ToList();
            string result3 = string.Join(",", squaredNumbers);
            Console.WriteLine("Квадратные числа: ");
            Console.WriteLine(result3);
        }
    }
}