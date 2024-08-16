using System;
using Internal;

public class Jogador
{
   
    public int energia;
    public bool vivo;
    public string nome; 
    

    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }


    public Jogador(string name){
        energia = 100;
        vivo = true;
        nome = name;
    }

    public Jogador(string name, int e){
        energia = e;
        vivo = true;
        nome = name;
    }

    public Jogador(string name, int e, bool v){
        energia = e;
        vivo = v;
        nome = name;
    }

    public void info(){
        Console.WriteLine("Nome jogador:......{0}",nome);
        Console.WriteLine("Energia jogador:.. {0}",energia);
        Console.WriteLine("Status do jogador: {0}\n",vivo);

    }
    
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi eliminado", nome);
    }
    
}   

class Aula30
{
    static void Main(){
        
        
        Jogador j1 = new Jogador(); 
        Jogador j2 = new Jogador("Alanis");
        Jogador j3 = new Jogador("Lucas", 100);
        Jogador j4 = new Jogador("Depressão",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}