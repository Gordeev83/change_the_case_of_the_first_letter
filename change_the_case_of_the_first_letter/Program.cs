using System.Text.RegularExpressions;

namespace change_the_case_of_the_first_letter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            string result = Regex.Replace(input, @"(^\w|\.\s+\w)", m => m.Value.ToUpper());

            Console.WriteLine("Результат:");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
