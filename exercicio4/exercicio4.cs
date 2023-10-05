internal class Program
{
    private static void Main(string[] args)
    {
        int idade = 26;
        Console.WriteLine(idade);

        Console.WriteLine("A idade de José é" + idade);
        Console.WriteLine("A idade de José é {0}", idade);

        int numA, numB, resultado;

        numA = 10;
        numB = 3;

        resultado = numA + numB;

        Console.WriteLine("{0} + {1} = {2}", numA, numB, resultado);
    }
}