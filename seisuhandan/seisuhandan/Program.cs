using System;

namespace IntCheckApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                Console.WriteLine($"整数です: {value}");
            }
            else
            {
                Console.WriteLine("整数ではありません。");
            }

            Console.WriteLine("Enterで終了します。");
            Console.ReadLine();
        }
    }
}