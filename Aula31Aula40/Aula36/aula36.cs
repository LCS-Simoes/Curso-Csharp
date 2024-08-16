using System;
using Internal;

class Veiculo{
    //Base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public int getvelMax(){
        return velMax;
    }
}

class Carro : Veiculo {
    //Derivada
    public string nome;

    public Carro(string nome, int vMax) : base(vMax){
        //O Valor que eu passar em vMax nesse casso também vai ser atribuido
        //no construtor base.
        this.nome = nome;
        ligado = true;
    }

    public string getLigado(){
        return (ligado?"Ligado":"Desligado");
    }
}


class Aula36
{
    static void Main(){
        Carro c1 = new Carro("Veloster",200);

        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Velocidade máxima: {0}",c1.getvelMax());
        Console.WriteLine("Caror se encontra: {0}",c1.getLigado());
    }  
}

/*
    ~~ Diferença entre private e protected
    O private ele restringe o acesso do membro somente a classe
    ele só pode ser acessado por métodos daquela classe.
    No caso se eu for usar o membro em outra classe, essa classe derivada
    não vai ter acesso.
    O protected ele permite o acesso aos membros pelas classes derivadas.
    DETALHE: SÓ POSSO SER ACESSADO PROTECTED PELA CLASSE HERDADA, ENTÃO A MAIN NÃO É
    POSSIVEL
*/