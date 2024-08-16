using System;
using Internal;


public class Jogador
{
    //Nomes de classe iniciar com letra maiscula.

    public int energia = 100;
    public bool vivo = true;

    //Sempre definir o modificador da variavel
}   

class Aula28
{
    static void Main(){
        Jogador j1 = new Jogador(); //Instanciei um novo jogador ~~> New é quem reserva a memória
        Jogador j2 = new Jogador();

        j1.energia = 0;
        j2.energia = 50;    

        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
    }
}


