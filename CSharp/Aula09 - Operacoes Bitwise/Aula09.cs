// Deslocamento para a esquerda e deslocamento para a direita
// << dobra    >> metade

/*
    00001010 (10) << 00010100 (20)
    00001010 (10) >> 00000101 (5)
*/

using System;

class Aula09{

    static void Main(){
        int num=10;
        num=num<<1; //20

        Console.WriteLine(num); 
        
        num=num>>1; //10

        Console.WriteLine(num);

    }
}