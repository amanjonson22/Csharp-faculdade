using System;
class Program {
  public static void Main (string[] args) {
    int valorA;
    Console.WriteLine("Diga um número");
    valorA = int.Parse(Console.ReadLine());
    
    int valorB;
    Console.WriteLine("Diga outro número");
    valorB = int.Parse(Console.ReadLine());
    
    int resultado;
    resultado = valorA + valorB;
    Console.WriteLine(resultado);

    Console.WriteLine();
  }
}