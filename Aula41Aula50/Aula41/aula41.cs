using System;
using Internal;

class Carro {
    private int velMax;


    public int vm{
        //Isto é uma PROPRIEDADE e não um METODO por isso não tem ()
        //Get ~~> Leitura
        //Set ~~> Escrita
        get{
            return velMax;
        }
        set{
            if(value < 0){
                velMax = 0;
            }else if (value > 220){
                velMax = 220;
            }else {
                velMax = value;
            }
        }
    }

    public Carro(){
        this.velMax = 120;
    }
}



class Aula41{
    static void Main(){
        Carro c1 = new Carro();
        c1.vm = 200; //Estou usando o set nesse momento.
        Console.WriteLine("Velocidade: {0}", c1.vm);
    }
}