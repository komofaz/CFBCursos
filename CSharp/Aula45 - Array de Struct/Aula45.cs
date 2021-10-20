using System;

class Aula45{
    static void Main(){
        Carro c1 = new Carro("VM","Golf","Azul");

        // array de struct
        Carro[] carros = new Carro[5];

        for(int i=0;i<carros.Length;i++){
            carros[i].marca = "Marca"+i;
            carros[i].modelo = "Modelo"+i;
            carros[i].cor = "Cor"+i;
        }
        for(int i=0;i<carros.Length;i++){
            Console.WriteLine("Marca: {0}  Modelo: {1}  Cor: {2}",carros[i].marca,carros[i].modelo,carros[i].cor);
        } 
    }
}

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}