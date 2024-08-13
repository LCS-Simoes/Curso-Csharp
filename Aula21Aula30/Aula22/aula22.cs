using System;
using Internal;

class Aula22
{
    static void Main(){
        int[] numeros = new int[3]{11,22,33};
        
        /*
        int i; 
        Dica se o i for ser usado só dentro do for, mais fácil utilizar dentro do for
        economiza mais espaço da memória
        
        for(i = 0; i < num.Length; i++) {
            Console.WriteLine(num[i]);
        }

        */

        foreach(int num in numeros){
            Console.WriteLine(num);
        }

    }
}

/*
    FOREACH
    Ele serve para interar e ler elementos de uma coleção, ele não atribui valores
    a uma coleção e sim le os elementos de uma coleção.

    "foreach(int numero in num)" int numero é porque a gente precisa de uma variavel
    para receber "IN" de num, lembrando a "variavel" tem que ser do mesmo tipo do recebimento
*/