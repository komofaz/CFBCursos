using System;

class Aula28{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();

        j1.vida = 50;

        Console.WriteLine("Jogador 1 | Vida: {0} | Vivo: {1}",j1.vida,j1.vivo);
        Console.WriteLine("Jogador 2 | Vida: {0} | Vivo: {1}",j2.vida,j2.vivo);
    }
}

public class Jogador{
    public int vida = 100;
    public bool vivo = true;

}

