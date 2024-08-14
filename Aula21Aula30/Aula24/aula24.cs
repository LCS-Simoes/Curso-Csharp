using System;
using Internal;


class Aula24
{   
    static void Main(){
        oi();
        int v1,v2,resultado;
        Console.WriteLine("Digite o primeiro valor");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        v2 = Convert.ToInt32(Console.ReadLine());
        resultado = soma(v1,v2);
        Console.WriteLine("A soma de {0} e {1} resultou em: {2}",v1,v2,resultado);
        //Como eu retorno e está fora do método tenho que atribuir o return  em uma variavel
        //Ai atribui a variavel resultado, no resultado do método soma.
    }

    // Como o metodo da main é static, os métodos tbm tem que ser
    static void oi(){
        Console.WriteLine("Hello world!");
    }

    static int soma(int n1, int n2){
        //n1 e n2 são dois parametros de entrada.
        int soma = n1 + n2;
        // se fosse void Console.WriteLine("A soma de {0} e {1} resultou em: {2}",n1,n2,soma);
        return soma;    
    }

    
    
}