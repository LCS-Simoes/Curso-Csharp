using System;
using Internal;

class Aula04{

    static int num = 10;
    static void Main(){
        int num2 = 0;
        Console.Write(num);
    }
}

/*
    Não é possível acessar váriaveis de outro método, pois ela é uma variavel
    LOCAL. Para contornar o problema é só utilizar a variavel na classe, assim
    se torna global.
    No caso a váriavel num fora da classe para o método Main, tem que ser static
    devido a dinamica entre o método.
*/