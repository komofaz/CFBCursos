using System;

class Aula37{
    static void Main(){
        SubBase2 sb = new SubBase2();
    }
}

class Base{
    public Base(){
        // Sempre da classe mais acima da hierarquia que vai executar o construtor primeiro. Base, subBase e por ultimo subBase2.
        Console.WriteLine("Construtor Base");
    }
}

class SubBase : Base{
    public SubBase(){
        Console.WriteLine("Construtor SubBase");
    }
}

class SubBase2 : SubBase{
    public SubBase2(){
        Console.WriteLine("Construtor SubBase 2");
    }
}
