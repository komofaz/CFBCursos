using System;

class Aula03{
    static void Main(){
        byte b1 = 10; //0~255
        int num=0;
        char umaLetra='o';
        string palavra="o valor de float é ";
        float valor=1.5f;

        var aux=valor; //tipo definido na atribuição

        Console.WriteLine(palavra + aux);

        int num1=10,num2=20;
        int res = num1 + num2;
        Console.WriteLine(num1 +" + "+ num2 +" = "+ res);

    }
}