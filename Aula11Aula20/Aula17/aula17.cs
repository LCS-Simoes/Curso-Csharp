using System;
using Internal;

class Aula17
{
    static void Main(){
        int[] numeros = new int [5];
        int i;

        /*
            ~~ Atribuindo diretamente ~~
            float[] valores = new float[3]{22,19,33};
            Ou
            float[] valores = {22,19,33}; --> Atribuo diretamente
            Assim ele vai usar diretamente o uso de argumentos que a gente tá usando
            como quantidade para tamanho do array
        */

        for(i = 0; i < 5; i++){
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for(i = 0; i < 5; i++){
            Console.WriteLine(numeros[i]);
        }
    }
}

/*
    int [] Estou dizendo que estou criando um array
    numeros é o nome da variavel do array
    = new int [5] estou declarando que aquele array tem 5 posições
*/