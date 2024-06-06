using System;

class Exercicio5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos calcular sua média de notas!");
        Console.WriteLine("Digite sua primeira nota:");
        int nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite sua segunda nota:");
        int nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite sua terceira nota:");
        int nota3 = Convert.ToInt32(Console.ReadLine());
        int soma = nota1 + nota2 + nota3;
        if (soma / 3 >=7){
            Console.WriteLine("Está aprovado.");
        }
        else if (soma / 3 >= 5){
            Console.WriteLine("Está em recuperação.");
        }
        else {
            Console.WriteLine("Está reprovado.");
        }
    }
}
