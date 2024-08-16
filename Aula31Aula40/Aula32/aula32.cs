using System;
using Internal;

class Calculos{
    public int valor1, valor2;


    public Calculos(int valor1, int valor2){
        this.valor1 = valor1;
        this.valor2 = valor2;
    }


    public int Somar(){
        return valor1 + valor2;
    }
}


class Aula32
{
    static void Main(){
        Calculos c1 = new Calculos(10,5);
        Console.WriteLine(c1.Somar());
        //Eu estou tendo o return, porém ele não escreve no console
        //Então utilizar o Console.WriteLine
    }
    
}

/*
    This serve para especificar os métodos que possuem os memsmo nomes.
*/