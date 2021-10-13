using System;

class Aula17{
    static void Main(){
        int[] num = new int[5];
        int[] num2 = new int[5]{11,22,33,44,55};

        num[0] = 1;
        num[1] = 2;
        num[2] = 3;
        num[3] = 4;
        num[4] = 5;

        Console.WriteLine(num);
        Console.WriteLine(num[1]);
        Console.WriteLine(num2[1]);
    }
}