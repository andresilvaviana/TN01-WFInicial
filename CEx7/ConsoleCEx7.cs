namespace CEx7
{
    internal class ConsoleCEx7
    {
        static void Main(string[] args)
        {

            double[] menorvalor = new double [3];
            string[] nome = new string [3];
            
            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Informe o seu nome:");
                nome[i] = Console.ReadLine()!;

                Console.Write("Informe o valor do produto:");
                menorvalor[i] = Convert.ToDouble(Console.ReadLine()!);

                if (menorvalor[i] < menorvalor[0])
                {
                    menorvalor[0] = menorvalor[i];
                }   


            }
                Console.WriteLine($"O produto {nome[0]} de {menorvalor[0]} é o mais inconta");


        }
    }
}
