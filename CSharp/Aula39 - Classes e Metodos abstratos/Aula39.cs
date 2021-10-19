using System;

class Aula39{
    static void Main(){
        Carro c1 = new Carro();
        Console.WriteLine("VelAtual: {0}",c1.GetVelAtual());

        c1.Aceleracao(1);
        Console.WriteLine("VelAtual: {0}",c1.GetVelAtual());
        c1.Aceleracao(2);
        Console.WriteLine("VelAtual: {0}",c1.GetVelAtual());
        c1.Aceleracao(-3);
        Console.WriteLine("VelAtual: {0}",c1.GetVelAtual());
    }
}


// classe abstrata : basicamente podemos entender como uma classe de REFERENCIA
// não se cria o comportamento dessa classe, mas sim é como se fosse um protótipo, para subclasses que irão herdar essa classe
// assim como também para métodos
// quem herdar os abstratos é obrigado que implementem aqueles metodos e propriedades...
// não se pode instanciar uma classe abstrata
abstract class Veiculo{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    // construtor não deixei como abstrato, então é necessãrio implementar seu conteudo
    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }

    // não abstrato, então obrigatóriedade de implementar a sua funcionalidade
    public void SetLigado(bool ligado){
        this.ligado = ligado;
    }

    public int GetVelAtual(){
        return velAtual;
    }

    // exmeplo de metodo abstrato
    abstract public void Aceleracao(int mult);

}

class Carro : Veiculo{
    public Carro(){
        velMax = 120;
    }

    override public void Aceleracao(int mult){       
        velAtual += 10 * mult;
    }
}