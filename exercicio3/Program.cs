using System;

class Exercicio3
{
public static void Main(string[] args)
{
    Console.WriteLine("Digite dois números e eu vou te falar qual é o maior");
    Console.WriteLine("Digite o primeiro número:");
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    int numero2 = Convert.ToInt32(Console.ReadLine());
    if (numero1 > numero2){
        Console.WriteLine("O 1° número é o maior.");
    }
    else if (numero2 > numero1){
        Console.WriteLine("O 2° número é o maior.");
    }
    else{
        Console.WriteLine("Nenhum número é maior.");
    }
}
}