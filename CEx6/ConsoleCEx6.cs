namespace CEx6
{
    internal class ConsoleCEx6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Informe o numero de horas trabalhadas:");
            int quantidadehoras = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o valor da hora trabalhada:");
            double valorhora = Convert.ToDouble (Console.ReadLine()!);

            double resultado = valorhora * quantidadehoras;

            Console.WriteLine($"A renda total {nome} é R${resultado:F2}");

        }
    }
}
