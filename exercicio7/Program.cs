using System;

class Exercicio7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos te dizer se você é criança, adolescente, adulto ou idoso!");
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 12){
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade <= 17){
            Console.WriteLine("Você é um adolescente.");
        }
        else if(idade <= 59){
            Console.WriteLine("Você é um adulto.");
        }
        else{
            Console.WriteLine("Você é um idoso.");
        }
    }
}