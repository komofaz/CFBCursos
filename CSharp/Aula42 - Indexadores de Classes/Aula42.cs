// indexador : membro de uma classe que vai permitir aos objetos dessa classe serem indexados como se fossem arrays

using System;

class Aula42{
    static void Main(){
        Carro c1 = new Carro();
        // utilizando o indexadors
        // utilizando o objeto como array
        Console.WriteLine("velMax: {0}",c1[2]);
        c1[2] = 300;
        Console.WriteLine("velMax: {0}",c1[2]);
    }
}

class Carro{
    private int[] velMax = new int[3]{80,120,150};

    // Indexador 
    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value < 0){
                velMax[i] = 0;
            } else if(value > 200){
                velMax[i] = 200;
            } else {
                velMax[i] = value;
            }
        }
    }
}