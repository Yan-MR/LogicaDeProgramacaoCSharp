using System;
class Exercicio1
{
public static void Main(string[] args)
{
Console.WriteLine("Digite um numero:");
string? entrada = Console.ReadLine();
int numero = Convert.ToInt32(entrada);
if (numero % 2 == 0) {
Console.WriteLine("Seu número é par!");

}
else {
    Console.WriteLine("Seu número é ímpar!");
}
}
}