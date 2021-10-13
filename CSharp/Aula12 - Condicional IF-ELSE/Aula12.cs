using System;

class Aula12{

    static void Main(){
        Console.Write("Digite uma nota (0~10) : ");
        int nota = int.Parse(Console.ReadLine());
        string resultado = "Nota Invalida";

        if(nota >= 7 & nota <= 10){
            resultado = "Aprovado";
        } else if(nota < 7 & nota >= 0){
            resultado = "Reprovado";
        }

        Console.WriteLine("Nota: {0} - {1}",nota,resultado);
    }
}