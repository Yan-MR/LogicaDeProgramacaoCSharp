using System;

class Exercicio11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva um número para saber se ele está no intervalo entre 10 e 20.");
        int numero = Convert.ToInt32(Console.ReadLine());
        if ((numero >= 10) && (numero <= 20)){
            Console.WriteLine("O número está no intervalo de 10 a 20.");
            }
            else
            {
                Console.WriteLine("O número passa ou não chega entre 10 e 20.");
            }
    }
}
