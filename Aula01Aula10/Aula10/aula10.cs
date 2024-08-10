using System;
using Internal;

class aula10
{
    enum diasSemanas{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){
        diasSemanas ds = diasSemanas.Sábado;
        Console.WriteLine(ds);
    }
}


/*
    enum é um enumerador dentro dele cada coisa tem uma posição no caso dias
    semanas vai de 0 - 6 
    A variavel só pode receber valor possiveis.
    Não posso utilizar diasSemanas ds = 3; 
    Na verdade eu teria que fazer um cast que basicamente seria
    diasSemanas ds = (diasSemanas)3;
    Assim ele me trás de acordo com o indice;
    Caso contrário de string para int seria
    int ds = (int)diasSemanas.Sábado;
    o (int) é o conversor
*/