using System;
using Internal;

abstract class Veiculo{
    protected  int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado){
        this.ligado = ligado;
    } 
    abstract public void setVelAtual(int mult);

    public int getVelAtual(){
        return velAtual;
    }
}


class Carro : Veiculo {
    public Carro(){
        velMax = 120;
    }
    override public void setVelAtual(int mult){
        velAtual += 10 * mult;
        //Se eu disse que é 1 eu aumento a multiplicação
        //caso contrário eu estou diminuindo a aceleração
    }
}

class Aula39{
    static void Main(){
        Carro c1 = new Carro();

        c1.setVelAtual(1);

        Console.WriteLine(c1.getVelAtual());
    }

    
}