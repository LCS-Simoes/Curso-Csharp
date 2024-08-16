using System;
using System.Runtime.CompilerServices;
using Internal;

static public class Jogador
{
   
    static public int energia;
    static public bool vivo;
    static public string nome; 
    

    static public void iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info(){
        Console.WriteLine("Nome jogador:......{0}",nome);
        Console.WriteLine("Energia jogador:.. {0}",energia);
        Console.WriteLine("Status do jogador: {0}\n",vivo);

    }
    
} 

class Inimigos{
    static public bool alerta;
    public string nome;

    public Inimigos(string nomeIni){
        alerta = false;
        nome = nomeIni;
    }

    public void info(){
        Console.WriteLine("Inimigo {0}",nome);
        Console.WriteLine("Considere isso como um alerta {0}", alerta);
        Console.WriteLine("------------------------");
    }
}




class Aula30
{
    static void Main(){
        
        Jogador.iniciar("Lucas");
        Jogador.info();
        //Como não tem como acessar por instancia, basta eu acessar direto na classe
       
        Inimigos i1 = new Inimigos("Matheus");
        Inimigos i2 = new Inimigos("Felipão");
        Inimigos i3 = new Inimigos("Fabricio");


        Inimigos.alerta = true; // Acessar pela classe, quando for mudar algo
        //E isso por ser static muda para todo mundo.
        i1.info();
        i2.info();
        i3.info();
    }
}

/*
    Quando eu declarar uma classe static, eu não posso instanciar o objeto
    pois ela não permite então elas não podem ter construtores também
    Porque o objeto que é static ele usa uma posição fixa na memória, então não tem
    sentido eu alocar uma parte da memoria com um NEW
*/