using System;
using Internal;

class Aula26
{
    static void Main(){
        int divid, divis,quo,res;
        divid = 10;
        divis = 3;
        quo = dividir(divid,divis,out res);
        Console.WriteLine("Resultado {0} e resto {1}",quo,res);
    }


    static int dividir(int dividendo,int divisor, out int resto){
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo%divisor; // % retorna o resto da divisão
        return quociente;
    }
}

/*
    ~~ Argumento out ~~
    O método out permite que você tenha a possibilidade de fazer
    o método retornar mais de um valor
    PARA RETORNAR 2 VARIAVEIS NÃO SE USA RETURN
    Você usa o return nomalmente para o que desejar retornar
    E NO PARAMETRO Você utiliza out (tipo) variavel, e também na chamada do
    método na main utilizar o out
    e ele já retorna posteriormente
*/