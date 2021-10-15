using System;

class Aula29{
    static void Main(){
        Console.Write("Digite o nome do Jogador : ");        
        Jogador j1 = new Jogador(Console.ReadLine());

        j1.vida = 50;
        Console.WriteLine("{0} >> Vida: {1} | {2}",j1.nome,j1.vida,j1.vivo);
    }
}

class Jogador{
    public int vida;
    public bool vivo;
    public string nome;

    // Construtor
    public Jogador(string n){
        vida = 100;
        vivo = true;
        nome = n;
    }

    // Destrutor
    ~Jogador(){
        Console.WriteLine("Jogador Destruido");
    }
}