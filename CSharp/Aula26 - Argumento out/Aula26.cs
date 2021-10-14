using System;

class Aula26{
    static void Main(){
        int resto;
        Console.WriteLine("Quociente: {0}   Resto: {1}",divide(13,2,out resto),resto);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}