using System;

class Aula23{
    static void Main(){
        int x = 5;
        int[] vet = new int[x];
        
        Random random = new Random(); // gerar numeros aleatorios
        for(int i=0;i<vet.Length;i++){
            vet[i] = random.Next(50); // (50) valor maximo 0~49 (10,50) minimo e maximo
        }

        foreach(int i in vet){
            Console.WriteLine("1 >> {0}",i);
        }

// Array.BinarySearch(array,valor)
        // retorna posição do elemento, se não for encontrado retorna um valor negativo(-1,-2,...), INT
        int valorProcurar = 10;
        int posProcurar = Array.BinarySearch(vet,valorProcurar);
        Console.WriteLine("Valor Procurado: {0} - Posicao: {1}",valorProcurar,posProcurar);

// Array.Copy(arrayOrigen,arrayDestino,qtdElementos)
        // copia os elementos de um array para outro, VOID
        int[] vet2 = new int[x];
        Array.Copy(vet,vet2,vet.Length);
        foreach(int i in vet2){
            Console.WriteLine("2 >> {0}",i);
        }

    // vet.CopyTo(arrayDestino,posicaoInicial)
        // copiar vetor a partir da posicao, VOID
        int[] vet3 = new int[x];
        vet.CopyTo(vet3,0);
        foreach(int i in vet3){
            Console.WriteLine("3 >> {0}",i);
        }

    // vet.GetLongLength(dimensao) vetor(0) matriz(n)
        // quantidade de elementos, LONG
        long qtdElementos = vet.GetLongLength(0);
        Console.WriteLine("Qtd Elementos : {0}",qtdElementos);

    // vet.GetLowerBound(0) << dimensão, como é vetor só possui uma
        // retorna o menor indice da dimensão (vetor ou matriz), INT
        int menorIndice = vet.GetLowerBound(0);
        Console.WriteLine("Menor Indice do Vetor é : {0}",menorIndice);

    // vet.GetUpperBound(0) << dimensão, como é vetor só possui uma
        // retorna o maior indice da dimensão (vetor ou matriz), INT
        int maiorIndice = vet.GetUpperBound(0);
        Console.WriteLine("Maior Indice do Vetor é : {0}",maiorIndice);

    // vet.GetValue(indice) vetor(0) matriz(0,0)
        // retorna valor a partir de um indice, OBJECT (Fazer cast se quiser o numeral)
        int valorIndice = Convert.ToInt32(vet.GetValue(maiorIndice));
        Console.WriteLine("Valor {0} do Indice {1}",valorIndice,maiorIndice);

// Array.IndexOf(array,valor)
        // retorna indice do PRIMEIRO valor encontrado da pesquisa, retorna -1 se não encontrar, INT
        int pesquisaValorFirst = Array.IndexOf(vet,valorProcurar);
        Console.WriteLine("Valor procurado {0} primeira posicao {1}",valorProcurar,pesquisaValorFirst);

// Array.LastIndexOf(array,valor)
        // retorna indice do PRIMEIRO valor encontrado da pesquisa,  retorna -1 se não encontrar, INT
        int pesquisaValorLast = Array.LastIndexOf(vet,valorProcurar);
        Console.WriteLine("Valor procurado [0] ultima posicao {1}",valorProcurar,pesquisaValorLast);

// Array.Reverse(array)
        // inverte a ordem dos elementos, VOID
        int[] vet4 = new int[x];
        Array.Copy(vet,vet4,vet.Length);
        Array.Reverse(vet4);
        foreach(int i in vet4){
            Console.WriteLine("4 >> {0}",i);
        }

    // vet.SetValue(valor,posicao)
        // setar um valor em uma posição, VOID
        for(int i = 0;i < vet2.Length;i++){ 
            vet2.SetValue(33,i);
        }
        foreach(int i in vet2){
            Console.WriteLine(i);
        }

// Array.Sorte(array)
        // ordenar os elementos do array em ordem crescente. (decrescente Sort + Reverse), VOID
        Array.Sort(vet3);
        foreach(int i in vet3){
            Console.WriteLine("3Sort >> {0}",i);
        }



    }
}
    
