using System;

class Aula35{
    static void Main(){
        Carro c1 = new Carro("Relampago Marquinhos","Vermelho Personalizado");
        c1.Ligar();
        Console.WriteLine("Nome: {0}  Cor: {1}  Vel.Max.: {2}  Ligado: {3}  Rodas: {4}",c1.nome,c1.cor,c1.velMax,c1.GetStatus(),c1.GetRodas());

        CarroCombate cc1 = new CarroCombate();
        Console.WriteLine("Nome: {0}  Cor: {1}  Vel.Max.: {2}  Ligado: {3}  Rodas: {4}  Municao: {5}",cc1.nome,cc1.cor,cc1.velMax,cc1.GetStatus(),cc1.GetRodas(),cc1.municao);
    }
}

class Veiculo{
    public int velMax;
    private bool ligado;    
    // alteracao - private
    private int rodas;

    public void Ligar(){
        ligado = true;
    }
    public void Desligar(){
        ligado = false;
    }

    public string GetStatus(){
        // Operador ternário
        return (ligado?"Ligado":"Desligado");
    }

    // **
    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public int GetRodas(){
        return rodas;
    }
}

class Carro : Veiculo{
    public string nome;
    public string cor;

    //  **
    public Carro(string nome, string cor):base(4){
        Desligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

// Cadeia de herança
class CarroCombate : Carro{
    public int municao;
    public CarroCombate():base("Relampago Marquinhos","Vermelho Personalizado"){
        municao = 100;
    }
}