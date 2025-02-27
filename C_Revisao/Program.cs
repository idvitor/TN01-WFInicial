namespace C_Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do primeiro aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
                
               
                Console.WriteLine("Aprovado!");

            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Recuperação!");
                Console.WriteLine("Recuperação!");
            }

        }
    }
}  
