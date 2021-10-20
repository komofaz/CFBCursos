// struc pode armazenar tipos de dados diferentes
// struct é tratada como tipo value e a class é como referencia
// como struct não é class, ela não pode ser herdada nem herdar
// mas pode ter construtor 

using System;

class Aula44{
    static void Main(){
        Carro c1; // instancinado struct
        
        c1.marca = "VM";
        c1.modelo = "Golf";
        c1.cor = "Azul";
        
        Console.WriteLine("1 | Marca: {0}  Modelo: {1}  Cor:{2}",c1.marca,c1.modelo,c1.cor); 

        // chamando o construtor
        Carro c2 = new Carro("VM","Golf","Azul"); 
        Console.WriteLine("2 | Marca: {0}  Modelo: {1}  Cor:{2}",c2.marca,c2.modelo,c2.cor); 
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