using System;
using Internal;

delegate int Operacoes(int n1,int n2);
//Temos que utilizar a mesma quantidade de parametros que o que vamos usar
//Se não tem que criar um delegate proprio pra aquele método

class Matematica{

    public static int soma(int n1, int n2){
        return n1 + n2;
    }

    public static int multiplicar(int n1, int n2){
        return n1 * n2;
    }

}


class Aula50{
    static void Main(){
        int resultado;
        // Como utilizar:
        Operacoes op = new Operacoes(Matematica.soma);

        resultado = op(10,30);
        Console.WriteLine("Soma de resultado {0}",resultado);

        op = new Operacoes(Matematica.multiplicar);
        resultado = op(2,5);
        Console.WriteLine("Multiplicação de resultado {0}",resultado);
    }   
}

/*
    Delegates
    É um objeto que pode fazer referencia a um método ou vários métodos
    dentro da minha classe
*/