using System;
using Internal;

class aula20
{
    static void Main(){
        
        int numeros = 0; //Variavel de controle
        while (numeros < 2500)
        {
            Console.WriteLine("Número {0}", numeros+1);
            numeros++; //Incremento da variavel de controle
        }
    }
}


/*
    Utilizar FOR para quando eu sei quantas vezes eu quero repetir
    já o while quando eu não sei.
*/