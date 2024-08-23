using System;
using Internal;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    //Pode ter um construtor em uma struct
    public Carro(string marca,string modelo,string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}",this.marca,this.modelo,this.cor);
    }
}


class Aula44{

    static void Main(){
        Carro c1; //Assim eu já estou usando a struct CARRO
        Carro c2 = new Carro("Toyota","Hilux","Prata"); //Chamando  o construtor da struct
        c1.marca = "Honda";
        c1.modelo = "HR-V";
        c1.cor = "Preto";

        c1.info();
        c2.info();
    }
}