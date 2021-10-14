using System;

class Aula25{
    static void Main(){
        int num = 10;
        dobrar(num); // passagem por valor
        Console.WriteLine(num);

        dobrarRef(ref num); // passando por referencia
        Console.WriteLine(num);
    }

    // Aloca em um novo espaço na memoria uma copia do valor que foi passado
    static void dobrar(int num){
        num *= 2;
    }

    // Passagem por referencia, altera o proprio espaço na memoria da variavel
    static void dobrarRef(ref int num){
        num *= 2;
    }
}