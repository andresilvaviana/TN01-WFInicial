﻿using static System.Net.Mime.MediaTypeNames;

namespace CEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = @"
_______________________________________
    1-Domingo
    2-Segunda-Feira
    3-Terça-Feira
    4-Quarta-Feira
    5-Quinta-Feira
    6-Sexta-Feira
    7-Sábado-Feira
_______________________________________
                            ";
            Console.WriteLine(menu);
            byte opcao = byte.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado-Feira");
                    break;
                case 8:
                    Console.WriteLine("Dia Invalido");
                    break;

            }
        }
    }
}
