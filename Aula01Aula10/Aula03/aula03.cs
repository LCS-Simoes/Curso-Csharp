using System;

class aula03{
    static void Main()
    {
        /* byte n1 = 10; pode armazenar entre 0 e 255
        int num = 0;
        char letra = 'c'; coisas simples não palavras
        float valor = 5.03f ; F no final para o padrão de float
        string nome = "Nome"; Aspas duplas
        var aux = nome; 
        //Quando eu uso operador VAR é basicamente eu não especificar o tipo da variavel, então ela vai ser definida com o que ele receber posteriormente
        Console.WriteLine("Seu nome é" + aux);
        */

        int num1,num2,res;

        num1 = 10;
        num2 = 3;
        res = num1 * num2;

        Console.WriteLine("A multiplacação entre número 1 :  " + num1 + " + e número 2: " +num2 + "resultando em: " + res);    

        //Eu poderia retirar o res e fazer a multiplicação na propria mensagem no lugar de res seria: num1 * num2    
    }
}   