using System;
using Internal;

class Calc{
    
    public int soma(int n1, int n2){
        return n1 + n2;
    }

    //Sobrecarga -- Igual construtores
    public int soma(params int[] n){
        int soma = 0;
        for(int i = 0; i < n.Length; i++){
            soma += n[i];
        }
        return soma;
    }

    public double soma(params double[] n){
        double soma = 0;
        for(int i = 0; i < n.Length; i++){
            soma += n[i];
        }
        return soma;
    }

    public int fatorial(int numero){
        int resultado;
        if(numero <= 1){
            resultado = 1;
        }else {
            //Tenho que chamar a função passar o número e ir retirando 1
            //Até que chega em 1
            resultado = numero * fatorial(numero - 1);
            // Resultado = Numero vezes  Numero anterior - 1
        }
        return resultado;
    }


}



class Aula48
{
    static void Main(){
        Calc cal = new Calc();

        Console.WriteLine(cal.fatorial(5));
    }
}


/*
    Recursividade é uma função que chama ela mesmo, devido a isso
    devemos ter um controle de parada dentro dessa função para que em algum
    momento ela pare.
*/