using System;

namespace CEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Primeiro Numero! ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o Segundo Numero! ");
            int num2 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o Terceiro Numero! ");
            int num3 = int.Parse(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            int menor = Math.Min(num1, num2);
            maior = Math.Min(maior, num3);


            Console.WriteLine($"\nO numero {maior} é o maior valor!");
        }
    }
}
