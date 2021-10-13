using System;

class Aula15{
    static void Main(){

        Console.Clear();

        Inicio:       
        Console.WriteLine("1 - Ataque");
        Console.WriteLine("2 - Defesa");
        Console.WriteLine("3 - Fugir");
        Console.Write("Digite sua acao : ");
        string acao = "";
        int continua = 1;
        
        switch(Console.ReadLine()){
            case "1":
                acao = "Voce atacou";
                break;
            case "2":
                acao = "Voce defendeu";
                break;
            case "3":
                acao = "Voce fugiu";
                continua = 0;
                break;
            default:
                acao = "Acao Invalida, Voce ficou parado";                
                break;
        }

        Console.Clear();
        Console.WriteLine(">> " + acao);
        if(continua == 1){
            goto Inicio;
        }

    }
}