using System;

class Aula31{
    static void Main(){
        Jogador.Inicio("elasqueira");
        Jogador.Info();

        Inimigo i1 = new Inimigo("vixe");
        Inimigo i2 = new Inimigo("eita");

        // acesso o static pela classe, como é static todos os inimigos ficarão em alerta=true
        Inimigo.alerta=true;

        i1.Info();
        i2.Info();
    }
}

// Classe static não pode ter construtor
// CLasse static não permite instanciação de objetos
// todos os membros da classe static precisam ser static
static public class Jogador{

    static int vida;
    static bool vivo;
    static string nome;

    static public void Inicio(string n){
        vida = 100;
        vivo = true;
        nome = n;
    }

    static public void Info(){
        Console.WriteLine("{0} >> {1} | {2}",nome,vida,vivo);
    }
}

public class Inimigo{

    // static = Todos os objetos irão apontar para o mesmo endereço na memoria do alerta.
    static public bool alerta;
    public string nome;
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }

    public void Info(){
        Console.WriteLine("I {0} >> {1}",nome,alerta);
    }
}