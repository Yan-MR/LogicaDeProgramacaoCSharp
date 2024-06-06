using System;

class Exercicio14
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número positivo ou negativo... Positivo = raíz quadrada do valor | Negativo = o valor ao quadrado.");
        double valor = Convert.ToDouble(Console.ReadLine());
        if (valor >= 0){
            double conta = Math.Sqrt(valor);
            Console.WriteLine("Como o valor é positivo, sua raíz quadrada é: " + conta);
        }
        else if (valor <= 0){
            double conta = valor * valor;
            Console.WriteLine("Como o valor é negativo, ele ao quadrado é: " + conta);
        }
    }
}
