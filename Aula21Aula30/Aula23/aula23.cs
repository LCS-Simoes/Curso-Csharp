using System;
using Internal;

class aula23
{
    static void Main(){
        
        //Aula de hoje Métodos em arrays
        
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random(); //Chamei a classe Random e criei um objeto random

        for(int i = 0; i < vetor1.Length; i++){
            vetor1[i] = random.Next(50); 
            //Next tem sobrecarga de 50 de range
            //Porém posso deixar vazio então não tem limite
            //Next(50,100) primeiro número valor minimo, segundo valor máximo
        }

        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }


        // Método binario ~~> Retorna inteiro e a posição do elemento procurado
        
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("BinarySearh ~~> Nome do método");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}",procurado,pos);
        Console.WriteLine("-------------------------------------------");
        //"Array" ~~> o que eu estou trabalhando 
        //BinarySearch método
        //(vetor1,procurado) ~~> 1 a variavel que eu estou utilizando e segundo a que
        // eu estou procurando.
        //Se ele retornar -1 significa que a variavel procurada não está no array


        //Método Copy ~~> Copia de um vetor para o outro

        Console.Write("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length); 
        //Vetor_Origem, Vetor_Destino, Vetor_Elementos pra copiar
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }   
        Console.WriteLine("-------------------------------------------");


        //Metodo Copyto
        Console.WriteLine("CoptyTo");
        vetor1.CopyTo(vetor3,0); 
        //A partir do vetor e não do array.
        //Vetor_Destino, A partir de qual posição quer começar copiar 

        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //Metodo GetLongLenght(Dimensão) ~~> Me retorna o menor indice
        //Versão vetor
        Console.WriteLine("GetLongLenght");
        long qtdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdElementosVetor);
        Console.WriteLine("-------------------------------------------");

        //Versão matriz
        long menorIndiceVetor = matriz.GetLowerBound(0); // A primeira adimensão é zero ~~> versão vetor era só usar vetor1.GetLowerBound(0)
        long menorIndiceMatriz = matriz.GetLowerBound(1); //Por ser matriz [2,5] = 1 dimensão = 0 e a 2 dimensão = 1;
        Console.WriteLine("Menor indice vetor {0}",menorIndiceVetor);
        Console.WriteLine("Menor indice matriz {0}",menorIndiceMatriz);
        Console.WriteLine("-------------------------------------------");


        //Versão upepr
        Console.WriteLine("GetUpperBound");
        long maiorIndiceVetor = vetor1.GetUpperBound(0);
        long maiorIndiceMatriz = matriz.GetUpperBound(0); //Pedi da 1 parte do vetor
        Console.WriteLine("Maior indice vetor {0}",maiorIndiceVetor);
        Console.WriteLine("Maior indice matriz {0}",maiorIndiceMatriz);
        Console.WriteLine("-------------------------------------------");


        //Get Value ~~> Retorna o valor a partir de um indice

        Console.WriteLine("GetValue");
        int valorVetor = Convert.ToInt32(vetor1.GetValue(3));
        int valorMatriz = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor 1 {0}", valorVetor);
        Console.WriteLine("Valor da linha 1 coluna 3 {0}", valorMatriz);
        Console.WriteLine("-------------------------------------------");

        /*
            Tenho que converter para o que for mais adequado já que pode ser qualquer coisa
        */

        //IndexOf
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1,3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("-------------------------------------------");
        //IndeoxOf(array_apesquisar, valor que eu quero pesquisar)
        //IndexOf me retorna o primeiro indice do valor encontrado

        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do ultimo valor 3: {0}", indice2);
        Console.WriteLine("-------------------------------------------");
        //Mesma coisa que o indexof padrão, porém me entrega o último indice que tinha o valor encontrado
        //LastIndexOf(array_apesquisar, valor que eu quero pesquisar)
    
        //Reverse ~~> Inverte as ordem dos elementos
        Array.Reverse(vetor1);
        foreach(int vetor in vetor1){
            Console.WriteLine(vetor);
        }
        Console.WriteLine("-------------------------------------------");
        //SetValue ~~> Atribui um valor a um determinado indice
        Console.WriteLine("SetValue");
        vetor2.SetValue(99,0);
        for(int i = 0; i < vetor2.Length; i++){
            vetor2.SetValue(0,i);
            //setValue(valor, posição)
        }
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Vetor 2");
        foreach (int vetor in vetor2)
        {
            Console.WriteLine(vetor);
        }
        Console.WriteLine("-------------------------------------------");
        //Método sort ~~> Se usa quando quiser ordenar em ordem crescente

        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);

        Console.WriteLine("Vetor 1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Vetor 3");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
        //Dica, para fazer ordem decrescente usar .reverse
        Array.Reverse(vetor1);
        Console.WriteLine("Vetor decrescente 1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");
    }

}
