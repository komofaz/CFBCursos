using System;

class Aula18{
    static void Main(){
        int[,] matr = new int[2,2];
        matr[0,0] = 10;
        matr[0,1] = 15;
        matr[1,0] = 20;
        matr[1,1] = 25;

        Console.WriteLine(matr);
        Console.WriteLine(matr[0,1]);
    }
}