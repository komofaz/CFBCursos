using System;

class Aula20{
    static void Main(){
        int[] vet = new int[3];

        int i = 0;
        while(i<vet.Length){
            vet[i] = i;
            Console.WriteLine(vet[i]);
            i++;
        }
    }
}