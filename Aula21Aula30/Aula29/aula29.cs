using System;
using Internal;


public class Jogador
{
    //Nomes de classe iniciar com letra maiscula.

    public int energia;
    public bool vivo;
    public string nome; 
    //Quero atribuir o valor de nome quando eu instanciar o objeto ~~> colocar no construtor do mesmo tipo
    //Sempre definir o modificador da variavel
    //Construtor
    public Jogador(string name){
        energia = 100;
        vivo = true;
        nome = name;
    }

    //Método destrutor ~~> tem que ter o nome da class e precisa do ~ antes to titulo para ser o destrutor
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi eliminado", nome);
    }
    
}   

class Aula29
{
    static void Main(){
        string cobaia;
        Console.WriteLine("Digite o nome do jogador 3");
        cobaia = Console.ReadLine();
        Jogador j1 = new Jogador("Lucas"); //Instanciei um novo jogador ~~> New é quem reserva a memória
        Jogador j2 = new Jogador("Alanis");
        Jogador j3 = new Jogador(cobaia);

        j2.energia = 50;    

        Console.WriteLine("Energia do jogador {0}: {1} ", j1.nome,j1.energia );
        Console.WriteLine("Energia do jogador {0}: {1}", j2.nome,j2.energia);
        Console.WriteLine("Nome do jogador 3 é {0}", j3.nome);
    }
}



/*
    Construtores
    Basicamente é um método que inicializa o objeto quando instanciado da classe, assim
    automaticamente o método construtor é chamado e o principal objetivo dele é declarar as váriaveis
    da classe.
    ~~> Método construtor tem que ter o mesmo nome da CLASSE
    
    Destrutores
    Ele é ao contrário do construtor, quando a classe for destruida ele vai ser usado.


*/