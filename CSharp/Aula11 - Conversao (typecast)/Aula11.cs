// typecast : necessario quando a conversão não pode ser implicita

using System;
class Aula11{
    static void Main(){
        float n1=10.8f;
        int n2=(int)n1; //typecast
        Console.WriteLine(n2);

        long vLong=10;
        int vInt=(int)vLong; //typecast
        Console.WriteLine(vInt);

    }
}