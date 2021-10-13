using System;

class Aula10{

    enum DiasSemana{Domingo,Segunda,Terca,Quarta,Quinta,Sexta};
    
    static void Main(){
        DiasSemana ds = DiasSemana.Domingo;

        Console.WriteLine(ds);

        DiasSemana ds2 = (DiasSemana)0; // definindo pelo indice

        Console.WriteLine(ds2);

        int ds3 = (int)DiasSemana.Domingo; // trazendo o indice

        Console.WriteLine(ds3);
    }
}