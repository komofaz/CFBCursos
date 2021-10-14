using System;

class Aula21{
    static void Main(){
        int golpes = 4;
        int ataque = 1;
        int dano = 0;
        int danoTotal = 0;

        do {
            dano += 100;
            danoTotal += dano;
            Console.WriteLine("Ataque {0} : Dano {1}",ataque,dano);            
            ataque++;
        } while(ataque<=golpes);

        Console.WriteLine("Dano Total : {0}",danoTotal);
    }
}