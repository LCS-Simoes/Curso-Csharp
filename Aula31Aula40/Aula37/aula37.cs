using System;
using Internal;

class Base{
    public Base(){
        Console.WriteLine("Construtor da clase Base");
    }
}


class Derivada1 : Base {
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
}

class Derivada2 : Derivada1{
    public Derivada2(){
         Console.WriteLine("Construtor da classe Derivada2");
    }
}


class Aula37{
    static void Main(){
        Derivada2 d2 = new Derivada2();
    }
}

/*
    Herança
    A herança começa sempre pela classe BASE, as suas derivadas bem de acordor
    com a sequencia que você herdou.

*/