using System;
using Internal;

class aula23
{
    static void Main(){
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
        Console.WriteLine("Qutndiade de elementos {0}",qtdElementosVetor);
        Console.WriteLine("-------------------------------------------");

        //Versão matriz
        long maiorIndice = vetor1.GetLowerBound(0); // Como é vetor a dimensão é zero
        long menorIndice = matriz.GetLowerBound(1); //Por ser matriz [2,5] = 1 dimensão = 0 e a 2 dimensão = 1;
        Console.WriteLine("Qutndiade de elementos {0}",qtdElementosVetor);
        Console.WriteLine("-------------------------------------------");
    }
}
