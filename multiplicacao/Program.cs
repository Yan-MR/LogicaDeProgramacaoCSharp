﻿using System;

class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Vamos multiplicar!");
    Console.WriteLine("Digite um número:");
    double numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    double numero2 = Convert.ToDouble(Console.ReadLine());
    double multiplicacao = numero1 * numero2;
    Console.WriteLine("O resultado foi de: " + multiplicacao);
}
}