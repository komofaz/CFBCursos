using System;

class Aula41{
    static void Main(){
        Carro c1 = new Carro();
        Console.WriteLine("velocidade: {0}",c1.vm);
        c1.vm = 500; // pra setar o valor não é (500) e sim atribui através de =
        Console.WriteLine("velocidade: {0}",c1.vm);
    }
}

class Carro{
    private int velMax;

    // como não é metodo e sim propriedade não utiliza ()
    // pode ser get, set ou get e set
    // propriedade metod acessors
    public int vm{
        get{
            return velMax;
        }
        set{
            // os argumentos passados para o vm são armazenados em value.
            if(value < 0){
                velMax = 0;
            } else if(value > 300){
                velMax = 300;
            } else {
                velMax = value;
            }
        }
    }   
    public Carro(){
        vm=120;
    }
}