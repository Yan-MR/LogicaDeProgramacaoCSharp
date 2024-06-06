using System;

class Exercicio15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos calcular seu IMC!");
        Console.WriteLine("Digite sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Agora digite seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        

 double imc = (peso / (altura * altura));
 
        string categoria;
        if (imc < 18.5)
        {
            categoria = "Abaixo do peso";
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            categoria = "Peso normal";
        }
        else if (imc >= 25 && imc < 29.9)
        {
            categoria = "Sobrepeso";
        }
        else if (imc >= 30 && imc < 34.9)
        {
            categoria = "Obesidade grau I";
        }
        else if (imc >= 35 && imc < 39.9)
        {
            categoria = "Obesidade grau II";
        }
        else
        {
            categoria = "Obesidade grau III";
        }
        Console.WriteLine("Seu IMC é de: " + imc.ToString("F4") + " você está na categoria: " + categoria);
    }
}