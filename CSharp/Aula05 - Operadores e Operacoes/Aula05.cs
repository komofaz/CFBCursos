using System;

class Aula05{

    static void Main(){
        // + - * /
        int res = (10 + 5)*2; 
        Console.WriteLine(res);

        // Operadores Relacionais : > < >= <= !=
        bool res2 = 10 < 5; 
        Console.WriteLine(res2);

        int num = 10;
        // Operadores Incrementais : += ++      Decrementais : -- -=
        num++; 
        num+=2; 
        Console.WriteLine(num);

        //Operadores Lógicos : & (AND)   | (OR)
        bool res3 = (5 > 3) | (3 > 5);
        bool res4 = (5 > 3) & (3 > 5);
        Console.WriteLine(res3);
        Console.WriteLine(res4);
    }
}