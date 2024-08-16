using System;
using Internal;

class Jogador{
    private int energia;
    private string nome;

    public Jogador(string nome){
        energia = 100;
        this.nome = nome;
    }

    public int getEnergia(){
        return energia;
    }

    public string getNome(){
        return nome;
    }

    public void setEnergia(int e){
        if(e < 0){
            if(energia+e < 0){
                energia = 0;
            }else {
                energia += e;
                // Colocar o sinal de + pois na soma se fosse -- ia resultar em + mas 
                //na regra de sinal como queremos retirar +- = -
            }
            
        }else if(e > 0){
            if(energia+e > 100){
                energia = 100;
            }else {
                energia += e;
            }
        }
    }
}


class Aula33
{
    static void Main(){
        Jogador j1 = new Jogador("Lucas");
        j1.setEnergia(-200);
    
    
        Console.WriteLine("Nome: {0}, Energia: {1}",j1.getNome(),j1.getEnergia());
    }
}


/*
    Public vs Private
    Publico eu tenho acesso em qualquer lugar não importa a classe, já private
    ela é unicamente exclusiva "acessada" pela aquela classe.
    Para isso, se eu for alterar algo que esteja privado é necessário eu usar um método
    para isso.

    ~~> Get Obeter
    ~~> Set Colocar
    
    Prestar atenção com sinais.
*/  