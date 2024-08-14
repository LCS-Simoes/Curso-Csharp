using System;
using Internal;


class Aula27
{
    static void Main(){
        soma(10,5,5,25);
    }


    static void soma(params int[] numero){
        int soma = 0;
        
        if(numero.Length < 1) {
            Console.WriteLine("Vetor vazio");
        }else if(numero.Length < 2){
            Console.WriteLine("Valores  insuficientes, você só passou o número {0}", numero[0]);
        }else {
            foreach (int verificar in numero)
            {
                soma += verificar; // Tenho que usar a variavel que eu criei em foreach
            }

            Console.WriteLine("Soma total: {0}",soma);
        }
    }
}

/*
    Params serve para resolver oproblema de ficar ajustando os argumentos dentro de um método
    A partir disso ele sabe que eu posso entrar com 0 ou com vários valores.
*/