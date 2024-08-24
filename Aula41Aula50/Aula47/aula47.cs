using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

    //A vantagem é que eu posso agr passar de dois a três valores.


}


class Aula47{
    
    static void Main(){
        Calc cal = new Calc();
        int resultado;
        double resultado2;
        //Para evitar ficar declarando váriaveis com tipos diferentes posso usar o VAR
        resultado = cal.soma(10,20);
        resultado2 = cal.soma(10.5,10.3,5.7,2.3,1.2);
        Console.WriteLine(resultado);
        Console.WriteLine(resultado2);
    }
}