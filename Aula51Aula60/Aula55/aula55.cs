using System;
using System.Collections.Generic;
using System.Reflection;
using Internal;
//Biblioteca dicionario

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

        //Métodos dictionary 
        //veiculos.Clear();
        //veiculos.Remove(3); 


        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        int chave = 5;
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A Chave {0} foi encontrada",chave);
        }else {
            Console.WriteLine("A chave não foi encontrada");
        }


        veiculos[15] = "Bicicleta"; //Alterando o valor 


        string valor = "Bicicleta";

        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("O valor {0} foi encontrada",valor);
        }else{
            Console.WriteLine("O valor não foi encontrada");
        }

        //Impressões

        foreach (KeyValuePair<int, string> v  in veiculos)
        {
            Console.WriteLine(v.Key);
            //. Key imprime as chaves e .Value os valores
        }
    }

}


/*
    Dictionary
    É uma coleção de dados na qual você tem uma dupla (chave e valor)


    Métodos
    Count: é tipo o .lenght ele contabilza quantos "dados" tem dentro da coleção
    Clear: Limpa a coleção
    ContainsKey: Retorna se a chave existe na coleção ou não.
    ContainsValue: Retorna se o valor está ou não na coleção
    Remove: Passar o id da chave
    KeyValuePair: Libera o acesso de impressão ou de valor ou de chave.
*/