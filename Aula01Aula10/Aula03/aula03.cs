using System;

class aula03{
    static async void Main()
    {
        byte n1 = 10; //pode armazenar entre 0 e 255
        int num = 0;
        char letra = 'c'; //coisas simples não palavras
        float valor = 5.03f ; //F no final para o padrão de float
        string nome = "Nome"; //Aspas duplas

        var aux = nome; 
        //Quando eu uso operador VAR é basicamente eu não especificar o tipo da variavel, então ela vai ser definida com o que ele receber posteriormente
        Console.WriteLine("Seu nome é" + aux);
    }
}   