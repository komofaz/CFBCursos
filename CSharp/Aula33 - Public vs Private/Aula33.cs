using System;

class Aula33{
    static void Main(){
        Jogador j1 = new Jogador("nomezinho");
        Console.WriteLine("{0} >> {1}",j1.nome,j1.vida);

        Jogador2 j2 = new Jogador2("elasqueira");
        Console.WriteLine("{0} >> {1}",j2.GetNome(),j2.GetVida()); 

        j2.SetVida(30);
        Console.WriteLine("30 = {0} >> {1}",j2.GetNome(),j2.GetVida()); 
        j2.SetVida(101);
        Console.WriteLine("101 = {0} >> {1}",j2.GetNome(),j2.GetVida());
        j2.SetVida(-1);
        Console.WriteLine("-1 = {0} >> {1}",j2.GetNome(),j2.GetVida());

    }
}

class Jogador{
    public int vida;
    public string nome;

    public Jogador(string n){
        vida = 100;
        nome = n;
    }
}

class Jogador2{
    private int vida;
    private string nome;

    public Jogador2(string n){
        vida = 100;
        nome = n;
    }

    public int GetVida(){
        return vida;
    }
    public string GetNome(){
        return nome;
    }

    public void SetVida(int v){
        if(v < 0){
            vida = 0;
            Console.WriteLine("A vida foi setada no mínimo = 0");
        } else if (v > 100){
            vida = 100;
            Console.WriteLine("A vida foi setada no maximo = 100");
        } else {
            vida = v;
        }
    }
}