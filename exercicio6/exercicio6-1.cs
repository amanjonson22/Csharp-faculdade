using System;

class Program{
    public static void Main (string[] args){
        int valorA;
        Console.WriteLine("Diga um número");
        valorA = int.Parse(Console.ReadLine());

        if(valorA >= 0){
            Console.WriteLine("Positivo")
        }
        else {
            Console.WriteLine("Negativo")
        }
    } 
}
