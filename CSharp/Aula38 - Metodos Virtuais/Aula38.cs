using System;

// metodos virtuais : metodos que tem o mesmo nome em classes diferentes
class Aula38{
    static void Main(){
        // criar uma referencia pra receber SubBase e SubBase2
        Base Ref;

        SubBase sb = new SubBase();
        sb.Info();
        Console.WriteLine();

        SubBase2 sb2 = new SubBase2();
        sb2.Info();
        Console.WriteLine();

        Ref = sb;
        Ref.Info();
        Console.WriteLine();
        Ref = sb2;
        Ref.Info();

    }

    
}

class Base{
    public Base(){
        Console.WriteLine("Construtor Base");
    }
    
    virtual public void Info(){
        // um metodo virtual significa que pretendo utilizar ele para ser sobrescrito, então não faz sentido colocar conteudo dentro...
        Console.WriteLine("Info Base"); // esse conteudo se torna inutil, pois sera sobrescrito
    }
}

class SubBase : Base{
    public SubBase(){
        Console.WriteLine("Construtor SubBase");
    }

    // não é possivel criar um metodo com mesmo nome da Base, nem vai compilar
    // por isso tem que declarar o metodo como virtual, para nomear com mesmo nome, 
    // então vou declarar o da Base como virtual, assim todas as derivadas poderao ter com mesmo nome.
    // então o metodo Info() da base, será sobrescrito por esse metodo da base derivada.
    // para sobrescrever tem que declarar o override
    override public void Info(){
        Console.WriteLine("Info SubBase");
    }
}

class SubBase2 : SubBase{
    public SubBase2(){
        Console.WriteLine("Construtor SubBase2");
    }

    override public void Info()
    {
        Console.WriteLine("Info SubBase 2");        
    }
}