using System;
using Internal;

class Aula25
{
    static void Main(){
        int numero = 10;
        dobrar1(ref numero);
        //dobrar2(numero);
        Console.WriteLine(numero);
    }
    static void dobrar1(ref int valor){
        //Mpetodo com referencia
        valor *= 2;
    }

    static void dobrar2(int valor){
        //Método sem referencia, ela mantem o número padrão
        valor *= 2;
    }
}
    
/*
    Se eu der Console.WriteLine(numero); inicialmente ele me retornara
    somente o memsmo número, devido a o endereço de memória INT VALOR ser diferente
    do numero, para isso tenho que usar referencia, ai ele não cria uma nova variavel 
    em local diferente de memória, é parecido com um ponteiro

    ~~ Obersavação ~~ 
    Utilizar ref antes do argumento da função e antes do parametro da função

*/