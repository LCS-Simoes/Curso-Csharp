using System;
using Internal;

class Base{
    public Base(){
        //Console.WriteLine("Construtor da clase Base");
    }
    //Coloquei o método como virtual
    virtual public void info(){}
}


class Derivada1 : Base {
    public Derivada1(){
        //Console.WriteLine("Construtor da classe Derivada1");
    }
    //Aonde eu for sobre escrever adicioanr override na frente
    override public void info(){
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2 : Derivada1{
    public Derivada2(){
        //Console.WriteLine("Construtor da classe Derivada2");
    }

    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}

class Aula38{
    static void Main(){
        Base Ref;
        Derivada1 d1 = new Derivada1();
        Derivada2 d2 = new Derivada2();
        Ref = d1;
        //Consigo exibir após atribuir a classe derivada 1 no ref
        //a info da derivada 1
        Ref.info();
    }
}

/*
    Métodos virtuais
    São métodos que tem o mesmo nome em classes diferentes, uma classe que herda a outra
    e que tem um método com o memso nome de que um método de sua classe base, porém este método
    vai executar uma ação diferente. A gente tem que definir esse método na sua classe base que esse método
    vai ser sobreescrito em outra classe
    //Parecido com o @Override em Java

    ~~> Sem colocar o método como virtual, ele me retorna um WARNING
    "Use a nova palavra-chave se a intenção for ocultar."

    Apartir disso, no caso nosso ele vai passar a imprmir DERIVADA1 e não BASE;
    Motivo:
    Porque ele tá chamando o Derivada 2 a partir do DERIVADA, e a classe "BASE"
    é do derivada1, porque ele foi sobreescrito naquela classe anterior


    Para separar AMBOS, tipo chamar info de derivada1 e de derivada2
    CHAMAR A CLASSE BASE NA MAIN e colocar Ref na frente, sempre com o R
    maisculo
*/