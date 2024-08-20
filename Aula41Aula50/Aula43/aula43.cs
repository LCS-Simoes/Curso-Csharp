using System;

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro : Veiculo, Combate {
    //POSSO MAIS DE UMA INTERFASE
    public bool ligado;
    private int municao;
    
    public Carro(){
        setMunicao(100);
    }

    public void setMunicao(int qtd){
        this.municao = qtd;
    }

    public void ligar(){
        this.ligado = true;
    }

    public void desligar(){
        this.ligado = false;
    }

    public void info(){

    }

    public void disparar(){

    }
}



class Aula43{
    static void Main(){
        Carro c1 = new Carro();
    }
}

/*
    Interface elas servem só para implementar métodos ou os prototipos
    dos métodos, elas não usa as propriedades / os campos nas interfaces
    ~~~> Classe interface não aceita nem VARIAVEIS

    Se uma classe "herdar" uma interface, ela vai ter que adicionar os métodos 
    /implementar 
*/