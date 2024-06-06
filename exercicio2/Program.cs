using System;

class Exercicio02 { 

    public static void Main(String[] args) 
    {
        Console.WriteLine("Digite um numero e será informado se é positivo, negativo, ou neutro");
        int entrada = Convert.ToInt32(Console.ReadLine());

        if (entrada > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if(entrada == 0){
            Console.WriteLine("O número é neutro.");
                }
        else{
            Console.WriteLine("O número é negativo.");
        }
        
    }  
}