using System;

class Aula06{
    static void Main(){
        int n1=10,n2=20,n3=30;

        Console.WriteLine(n1 + n2 + n3); //60
        Console.WriteLine(n1 + " " + n2 + " " + n3); //10 20 30
        Console.WriteLine("{0} {1} {2}",n1,n2,n3);//10 20 30
        Console.WriteLine("\t{0}\n\t{1}\n\t{2}",n1,n2,n3);// (tab) 10 (linha de baixo tab) 20 (linha de baixo tab) 30

        double valorCompra = 5.5;        
        double lucro = 0.1;
        string produto = "Pastel";

        double valorVenda = valorCompra +(valorCompra*lucro);

        //{indice variavel,espaco:saida}
        Console.WriteLine("Produto......:{0,14}",produto);
        Console.WriteLine("Val.Compra...:{0,15:c}",valorCompra); // c (formato monetario)
        Console.WriteLine("Lucro........:{0,14:p}",lucro); // p = (formato porcentagem)
        Console.WriteLine("Val.Venda....:{0,15:c}",valorVenda);

    }
}