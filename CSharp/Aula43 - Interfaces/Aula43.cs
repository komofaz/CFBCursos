// interface - não pode ter construtor nem destrutor
// não pode definir metodo operator
// não pode definir membros static
using System;

class Aula43{
    static void Main(){
        Carro c1 = new Carro();
    }
}

// interface - quem herdaar sera obrigado implementar os metodos
public interface Veiculo{
    void Ligar();
    void Desligar();
    void Info();
}
public interface Combate{
    void Disparar();   
}


// utilizaando duas interfcess
class Carro:Veiculo,Combate{
    
    private int municao;
    public bool ligado;
    public Carro(){

    }

    public void Ligar(){
        this.ligado = true;
    }
    
    public void Desligar(){
        ligado = false;
    }

    public void Info(){       
    }

    public void Disparar(){
        SetMunicao(100); 
    }

    public void SetMunicao(int qtd){
        this.municao = qtd;
    }
    
}