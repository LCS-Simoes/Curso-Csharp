using System;
using System.Globalization;
using Internal;

class Matematica{

    public static double pi = 3.14;

    public static int dobro(int numero){
        return numero * 2;
    }
}


class Aula49
{
    static void Main(){
        double vpi = Matematica.pi;
        int num = 10;

        Console.WriteLine(Matematica.dobro(num));
        Console.WriteLine(vpi);
    }
}

/*
    Static em variaveis e métodos
    Com isso não precisamos declarar um objeto da classe porque os métodos e variaveis
    estaticos são acessiveis;
*/