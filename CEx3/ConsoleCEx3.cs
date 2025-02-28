using System;

namespace CEx3
{
    internal class ConsoleCEx3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.Write("\nDigite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\nO número {maior} é maior valor!");
        }
    }
}
