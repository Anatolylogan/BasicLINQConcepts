using System;
using System.Linq;
using System.Reflection;

namespace BasicLINQConcepts
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("_________________________________________");
            List<int> numbers = new List<int> { 1, 5, 15, 20, 3, 10, 8, 25 };
            var filteredNumbers = numbers.Where(n => n > 10).ToList();
            string result = string.Join(",", filteredNumbers);
            Console.WriteLine("Числа больше 10:");
            Console.WriteLine(result);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            List<string> words = new List<string> { "яблоко", "банан", "груша", "ананас", "вишня" };
            var sortedWords = words.OrderBy(words => words).ToList();
            string result2 = string.Join(",", sortedWords);
            Console.WriteLine("Отсортированные строки: ");
            Console.WriteLine(result2);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            List<int> numbers2 = new List<int> { 2, 3, 4, 5 };
            List<int> squaredNumbers = numbers2.Select(n => n * n).ToList();
            string result3 = string.Join(",", squaredNumbers);
            Console.WriteLine("Квадратные числа: ");
            Console.WriteLine(result3);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            List<string> words2 = new List<string> { "яблоко", "ананас", "банан", "авокадо", "виноград" };
            var count = words2.Count(word => word.StartsWith("а"));
            Console.WriteLine("Количество строк начинаются с буквы <А>: ");
            Console.WriteLine(count);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            var employees = new List<(string Name, int Age)>
            {
            ("Анна", 25),
            ("Борис", 30),
            ("Виктор", 35),
            ("Дмитрий", 22),
            ("Елена", 29)
            };
            var groupedEmployees = employees.GroupBy(e => e.Age < 30).ToList();
            var youngerThan30 = groupedEmployees.First(g => g.Key).Select(e => e.Name).ToList();
            var olderThan30 = groupedEmployees.First(g => !g.Key).Select(e => e.Name).ToList();
            string result4 = string.Join(",", youngerThan30);
            string result5 = string.Join(",", olderThan30);
            Console.WriteLine("Группа младше 30: ");
            Console.WriteLine(result4);
            Console.WriteLine("Группа 30 лет и старше: ");
            Console.WriteLine(result5);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumbers = numbers3.Count(n => n % 2 == 0);
            Console.WriteLine("Количество чётных чисел: ");
            Console.WriteLine(evenNumbers);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            List<int> numbers4 = new List<int> { 10, 20, 30, 40, 50, 5 };
            var maxNumber = numbers4.Max();
            var minNumber = numbers4.Min();
            Console.WriteLine("Максимальное значение: ");
            Console.WriteLine(maxNumber);
            Console.WriteLine("Минимальное значение: ");
            Console.WriteLine(minNumber);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("_________________________________________");
            List<int> numbers5 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var uniqueNumbers = numbers5.GroupBy(n => n).Where(g => g.Count() == 1).Select(g => g.Key).ToList();
            string result6 = string.Join(",", uniqueNumbers);
            Console.WriteLine("Уникальные элементы:");
            Console.WriteLine(result6);
            Console.WriteLine("-----------------------------------------");

        }
    }
}