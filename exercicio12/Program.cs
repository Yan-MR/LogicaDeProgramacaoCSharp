using System;

class Exercicio12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número, se for menor que 100, ele será dobrado!");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero <= 100){
            int soma = numero * 2;
            Console.WriteLine("O número agora é " + soma + " pois o valor era menor ou igual a 100, então foi dobrado.");
        }
        else{
            int soma = numero;
            Console.WriteLine("o número " + soma + " é maior que 100, então sem alterações.");
        }
    }
}
