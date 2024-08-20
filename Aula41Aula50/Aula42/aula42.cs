using System;

class Carro{
    private int[] velMax = new int[5]{80,120,160,220,300};

    public int this[int i]{
        //Tem que ser um this para mencionar um inteiro de um indexador nesse caso
        get{
            return velMax[i];
        }
        set{
            if(value < 0){
                velMax[i] = 0;
            }else if (value > 220){
                velMax[i] = 220;
            }else {
                velMax[i] = value;
            }
        }
    }

    public Carro(){
    }
}

class Aula42
{
    static void Main(){
        Carro c1 = new Carro();

        c1[4] = 100;
        //Acesso agora através do indexador da posição
        Console.WriteLine("Velocidade: {0}", c1[4]);
    }

}

/*
    Indexador é um membro de uma classe que vai permitir aos objetos
    dessa classe serem indexados como se fossem Arrays
*/