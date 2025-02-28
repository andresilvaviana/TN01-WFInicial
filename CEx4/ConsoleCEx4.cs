namespace CEx4
{
    internal class ConsoleCEx4
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.Write("\nDigite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine()!);

            Console.Write("\nDigite o terceiro numero: ");
            int num3 = int.Parse(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            Console.WriteLine($"\nO número {maior} é maior valor!");
        }
    }
}
