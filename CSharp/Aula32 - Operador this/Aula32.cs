using System;

class Aula32{
    static void Main(){
        Calculos c = new Calculos(10,20);
        Console.WriteLine(c.Soma());
    }
}

class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2){
        // this = as variaveis dessa classe, não as que vieram de 'fora'
        this.v1 = v1;
        this.v2 = v2;
    }
    public int Soma(){
        return v1 + v2;
    }
}