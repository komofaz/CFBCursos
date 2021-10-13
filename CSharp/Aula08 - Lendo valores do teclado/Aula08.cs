using System;

class Aua08{
    static void Main(){
        int v1,v2,soma;
        string nome;

        Console.Write("Digite seu nome : ");
        nome =  Console.ReadLine();

        Console.Write("Digite o primeiro valor : ");
        v1 = int.Parse(Console.ReadLine()); // Usando Parse para converter

        Console.Write("Digite o primeiro valor : ");
        v2 = Convert.ToInt32(Console.ReadLine()); // Usando Convert para converter

        soma = v1 + v2;
        Console.WriteLine("O nome digitado foi : {0}",nome);
        Console.WriteLine("\t {0} + {1} = {2}",v1,v2,soma);


    }
}