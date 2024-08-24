using System;
using System.Globalization;
using Internal;

class Galinha{

    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.minhaGalinha = minhaGalinha;
        this.numOvo = numOvo;
        Console.WriteLine("A galinha {0} botou um ovo de número {1}!",this.minhaGalinha,this.numOvo);
    }
}



class Aula46
{
    static void Main(){
        Galinha g1 = new Galinha("Frederica");
        Galinha g2 = new Galinha("Ferdinanda");
        Galinha g3 = new Galinha("Ariana");


        g1.botar();
        g2.botar();
        g1.botar();
    }
}

/*
    Métodos que retornam um objeto
    Para fazer um método que retorna um OBJETO basta seguir
    Visibilidade - nome da classe - nome do método
    Dentro passar 
    return new Ovo(); --> Nesse casso ele cria um novo ovo

*/