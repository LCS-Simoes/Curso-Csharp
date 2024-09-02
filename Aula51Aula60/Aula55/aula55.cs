using System;
using System.Collections.Generic;
using System.Reflection; //Biblioteca dicionario

class Aula55
{
    static void Main(){
        //Chave <CHAVE, VALOR>
        Dictionary <int, string>  veiculos = new Dictionary<int, string>();

        //Adicionando elementos através do .Add
        veiculos.Add(10,"Carro");
        veiculos.Add(2,"Moto");
        veiculos.Add(3,"Avião");
        veiculos.Add(5,"Barco");
    }

}


/*
    Dictionary
    É uma coleção de dados na qual você tem uma dupla (chave e valor)

*/