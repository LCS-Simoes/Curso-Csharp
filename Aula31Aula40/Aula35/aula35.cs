using System;
using System.IO;
using System.Threading;
using Internal;


class Veiculo{
    //Classe BASE

    private int rodas;
    private int velMax;
    private bool ligado;

    public Veiculo(int rodas, int velMax, bool ligado){
        this.rodas = rodas;
        this.velMax = velMax;
        this.ligado = ligado;
    }

    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false; 
    }

    public void setRodas(int r){
        rodas = r;
    }

    public void setVel(int vel){
        velMax = vel;
    }

    public int getVel(){
        return velMax;
    }

    public int getRodas(){
        return rodas;
    }

    public string getLigado(){
        return (ligado ? "Ligado":"Desligado");
        //Uso de operador ternario acima.
    }
}

class Carro : Veiculo{

    public string nome;
    public string cor;

    public Carro(string nome, string cor) : base(2,100,false){
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate : Carro {
    public int municao;

    public CarroCombate() : base("Batmovel","Preto"){
        municao = 100;
    }
}

//Classe CarroCombate é uma classe derivada de Carro, porém tbm acaba sendo derivada
//da classe veiculo ja que ela é base de todas


class Aula35
{
    static void Main(){
        Carro c1 = new Carro("Celta","Preto");
        CarroCombate cc = new CarroCombate();
        c1.ligar();
        c1.setRodas(4);
        c1.setVel(80);
        cc.setRodas(4);
        cc.ligar();
        cc.setVel(400);

        Console.WriteLine("Veiculo com nome {0} e cor {1}",c1.nome, c1.cor);
        Console.WriteLine("Veiculo se encontra {0}", c1.getLigado());
        Console.WriteLine("Velocidade máxima do veiculo de: {0}", c1.getVel());
        Console.WriteLine("Quantidade de rodas: {0}", c1.getRodas());
        Console.WriteLine("----------------------------------");

        Console.WriteLine("Veiculo com nome {0} e cor {1}",cc.nome, cc.cor);
        Console.WriteLine("Veiculo se encontra {0}", cc.getLigado());
        Console.WriteLine("Velocidade máxima do veiculo de: {0}", cc.getVel());
        Console.WriteLine("Quantidade de rodas: {0}", cc.getRodas());
        Console.WriteLine("Munição se encontra em {0}%",cc.municao);

    }
}

/*
    Cadeia de herança e Construtor da classe base
    Para isso é só ir no construtor da classe filha colocar : base() e os 
    itens desejaveis do construtor pai
*/