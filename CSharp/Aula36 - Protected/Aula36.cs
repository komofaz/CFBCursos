using System;

class Aula36{
    static void Main(){
        Carro carro1 = new Carro("Fusca 53",300);
        Console.WriteLine("Nome: {0}  VelMax: {1}  Ligado: {2}",carro1.nome,carro1.GetVelMax(),carro1.GetLigado());
    }
}

class Veiculo{
    public int velAtual;
    // restringe somente à classe, classe derivada não tem acesso
    private int velMax;    
    // permite acesso pelas classes derivadas, mas, somente pelas classes, pelo objeto não tem acesso.
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool GetLigado(){
        return ligado;
    }

    public int GetVelMax(){
        return velMax;
    }
}

class Carro : Veiculo{
    public string nome;

    public Carro(string nome,int vm):base(vm){
        this.nome = nome;
        ligado = true;
    }
}