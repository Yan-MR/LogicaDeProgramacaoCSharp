using System;

class Exercicio4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos verificar se um triângulo é válido!");
        Console.WriteLine("Digite o valor do primeiro lado:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do segundo lado:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do terceiro lado:");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        if (numero1 + numero2 > numero3 && numero1 + numero3 > numero2 && numero2 + numero3 > numero1) {
            Console.WriteLine("Este triângulo é válido.");
        }
        else{
            Console.WriteLine("Este triângulo não é válido");
        }
    }
}