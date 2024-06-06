using System;

class Exercicio9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Me diga o código do produto de 1 a 40, e vou te informar sua categoria!");
        int produto = Convert.ToInt32(Console.ReadLine());
        if ((produto > 0) && (produto <= 10)){
            Console.WriteLine("Este produto é um alimento não perecível.");
        }
        else if ((produto >= 10) && (produto <= 20)){
            Console.WriteLine("Este produto é um alimento perecível.");
        }
        else if ((produto >= 20) && (produto <= 30)){
            Console.WriteLine("Este produto é de vestuário.");
        }
        else if ((produto >= 30) && (produto <= 40)){
            Console.WriteLine("Este produto é um eletrônico.");
        }
        else{
            Console.WriteLine("Este é um código inválido");
        }
    }
}