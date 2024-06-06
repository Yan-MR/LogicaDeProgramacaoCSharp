using System;

class Exercicio13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos fazer um conta baseado no valor do produto, e no seu perfil!");
        Console.WriteLine("Qual é o seu perfil? ( 1 = comum | 2 = associado | 3 = VIP)");
        int perfil = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("E qual é o valor do produto?");
        double valor = Convert.ToDouble(Console.ReadLine());

        double conta = valor;

        if (perfil == 1){
             conta = valor;
            Console.WriteLine("O valor do seu produto é cheio: " + conta);
        }
        else if (perfil == 2){
             conta = valor - (valor * 0.1);
            Console.WriteLine("O valor do seu produto teve um desconto de 10%: " + conta);
        }
        else if (perfil == 3){
            conta = valor - (valor * 0.2);
            Console.WriteLine("O valor do seu produto teve um desconto de 20%: " + conta);
        }
    }
}