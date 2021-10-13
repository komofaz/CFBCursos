using System;

class Aula07{
    static void Main(){
        //Constante - uma vez atribuido o valor ela nunca muda
        const string curso = "CFB Cursos - CSharp";
        const double pi = 3.1415;

        //curso = "nao vai dar"; // não deixa compilar com esse erro
        Console.WriteLine("Curso {0} \n\t Pi: {1}",curso,pi);
    }
}