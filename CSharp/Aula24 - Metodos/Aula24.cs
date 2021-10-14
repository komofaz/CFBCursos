using System;

class Aula24{
    
    // Como o metodo Main é static os metodos aqui dentro da classe também precisam ser static
    static void Main(){
        primeiroMetodo();

        Console.Write("Digite o numero 1 : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o numero 2 : ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        segundoMetodo(n1,n2);
        Console.WriteLine("{0} + {1} = {2}",n1,n2,terceiroMetodo(n1,n2));
    }

    // static - estatico
    // void - nao retorna nada
    static void primeiroMetodo(){
        Console.WriteLine("Primeiro Metodo");
    }

    static void segundoMetodo(int n1, int n2){
        int soma = n1 + n2;
        Console.WriteLine("{0} + {1} = {2}",n1,n2,soma);
    }

    static int terceiroMetodo(int n1, int n2){
        return n1 + n2;         
    }

}