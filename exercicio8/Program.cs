using System;

class Exercicio8
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua nota em número, e eu vou converter para letras!");
        int nota = Convert.ToInt32(Console.ReadLine());
        if (nota >= 9){
            Console.WriteLine("Sua nota vale A.");
        }
        else if (nota >= 7){
            Console.WriteLine("Sua nota vale B.");
        }
        else if (nota >= 5){
            Console.WriteLine("Sua nota vale C.");
        }
        else if (nota >= 3){
            Console.WriteLine("Sua nota vale D.");
        }
        else {
                Console.WriteLine("Sua nota vale F.");
        }
    }
}
