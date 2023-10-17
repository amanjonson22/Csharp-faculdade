using System

class Program
{
    public static void Main(string[] args)
    {
        int valorA;
        Console.WriteLine("Digite um valor: ");
        valorA = int.Parse(Console.ReadLine());

        int valorB;
        Console.WriteLine("Digite um valor: ");
        valorB = int.Parse(Console.ReadLine());

        int soma = valorA + valorB;

        Console.WriteLine("A soma de " + valorA + "+" +  valorB " = " + soma);

    }
}