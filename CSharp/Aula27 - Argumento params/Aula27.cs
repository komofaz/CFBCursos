using System;

class Aula27{
    static void Main(){
        soma(12,3,12);
    }

    static void soma(params int[]n){
        int soma = 0;
        foreach(int i in n){
            soma += i;
        }
        Console.WriteLine("A soma dos valores é : {0}",soma);
    }

    
}