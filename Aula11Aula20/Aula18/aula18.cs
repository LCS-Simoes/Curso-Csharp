using System;
using Internal;

class aula18
{
    static void Main(){
        int [,] matriz = new int[3,3];

        int i,j;

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine("Digite os valores da matriz");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Clear();

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.Write(matriz[i,j]  + "\t");
                
            }

            Console.WriteLine(); // Essa linha faz ficar separado cada linha da matriz
        }
    }
}

/*
    Arrays bidimensioal
    int [,] a virgula significa que terá dois controles de tamanho;

    Pra declarar de forma direta é basicamente quase a mesma coisa de vetor
    int[,] num = new int [2,2] {{1,2} {3,4}}
 */