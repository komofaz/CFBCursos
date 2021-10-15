using System;

class Aula30{

    static void Main(){        

        Jogador j1 = new Jogador();
        Console.Write("Digite o nome do jogador2 : ");
        Jogador j2 = new Jogador(Console.ReadLine());
        Console.Write("Digite o nome do jogador3 : ");
        Jogador j3 = new Jogador(Console.ReadLine(),50);
        Console.Write("Digite o nome do jogador4 : ");
        Jogador j4 = new Jogador(Console.ReadLine(),0,false);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();

    }

    
}


class Jogador{
    public int vida;
    public bool vivo;
    public string nome;

    public Jogador(){
        vida = 100;
        vivo = true;
        nome = "Sem Nome";
    }
    public Jogador(string n){
        vida = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n,int vid){
        vida = vid;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int vid, bool viv){
        vida = vid;
        vivo = viv;
        nome = n;
    }

    public void Info(){
        Console.WriteLine("{0} >> VIDA = {1} | {2}",nome,vida,vivo);
    }

    ~Jogador(){
        Console.WriteLine("Jogador Destruido");
    }
}