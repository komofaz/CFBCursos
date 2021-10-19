using System;

class Aula34{
    static void Main(){
        Carro c1 = new Carro("Relampago Marquinhos","Vermelho Personalizado");
        c1.Ligar();
        Console.WriteLine("Nome: {0}  Cor: {1}  Vel.Max.: {2}  ligado: {3}",c1.nome,c1.cor,c1.velMax,c1.GetStatus());
    }
}

class Veiculo{
    public int velMax;
    private bool ligado;
    public int rodas;

    public void Ligar(){
        ligado = true;
    }
    public void Desligar(){
        ligado = false;
    }

    public string GetStatus(){
        return Convert.ToString(ligado);
    }
}

class Carro : Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        Desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}