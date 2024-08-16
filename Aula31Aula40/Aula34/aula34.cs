using System;
using System.IO;
using System.Threading;
using Internal;


class Veiculo{
    //Classe BASE

    private int rodas;
    private int velMax;
    private bool ligado;

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
        if(ligado){
            return "Ligado";
        }else {
            return "Desligado";
        }
    }
}

class Carro : Veiculo{

    public string nome;
    public string cor;

    public Carro(string nome, string cor){
        desligar();
        setRodas(4);
        setVel(100);
        this.nome = nome;
        this.cor = cor;
    }
}


class Aula34
{
    static void Main(){
        Carro c1 = new Carro("Celta","Preto");
        c1.ligar();
        Console.WriteLine("Veiculo com nome {0} e cor {1}",c1.nome, c1.cor);
        Console.WriteLine("Veiculo se encontra {0}", c1.getLigado());
        Console.WriteLine("Velocidade máxima do veiculo de: {0}", c1.getVel());
        Console.WriteLine("Quantidade de rodas: {0}", c1.getRodas());
    }
}

/*
    Herança
    É um recurso da programação onde uma classe filha / derivada, herda membros
    de uma classe base/pai. 
    herdar: membros, propriedas e métodos de outra classes.
    (Membros ~> Variaveis)

    PARA HERDAR UMA CLASSE 
    Diferente de java que usamos .... extends ....
    aqui usamos o nome da classe : e a classe que vamos herdar
*/