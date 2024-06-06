using System;

class Exercicio6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um ano para verificar se é bissexto:");
        int ano = Convert.ToInt32(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
        {
            Console.WriteLine("O ano " + ano + " é bissexto.");
        }
        else
        {
            Console.WriteLine("O ano " + ano + " não é bissexto.");
        }
    }
}
