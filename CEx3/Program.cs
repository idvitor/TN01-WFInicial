namespace CEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Primeiro Numero! ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o Segundo Numero! ");
            int num2 = int.Parse(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\nO numero {maior} é o maior valor!");
        }
    }
}
