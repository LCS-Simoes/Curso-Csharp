using System;
using System.Collections.Generic;
using Internal;


class Aula58
{
    static void Main(){
        List<string> produtos = new List<string>();
        string[] produtos2 = new string[10];

        //Add
        produtos.Add("Arroz");
        produtos.Add("Feijão");
        produtos.Add("Carne-Moida");
        produtos.Add("Maracuja");
        produtos.Add("Maracuja");

        /*Remove
        produtos.Remove("Maracuja");
        produtos.RemoveAt(0); //Remove na posição
        */

        //Reverse ~~> inverte a lista
        produtos.Reverse();

        //Insert
        produtos.Insert(2,"Melancia");

        //Sort ~~> Ordena a lista
        produtos.Sort();

        //Verificações
        if(produtos.Contains("Arroz")){
            Console.WriteLine("Esta na lista");
        }else {
            Console.WriteLine("Não encontrado");
        }

        //Copyto
        produtos.CopyTo(produtos2,2); //(Onde eu quero, posição)

        foreach(string p in produtos){
            Console.WriteLine("Produto: {0}", p);
        }

        //IndexOf
        string prod = "Feijão";
        int posicao = 0;
        posicao = produtos.IndexOf(prod); //Estou pesquisando em produtos  e vou guardar a posição
        Console.WriteLine("Produto esta na posição {0}", posicao);


        //LastIndexOf ~~> O último com o memsmo valor
        posicao = produtos.LastIndexOf("Maracuja");
        Console.WriteLine("Posicao encotrada {0}", posicao);

        //Count 
        int tamanho = produtos.Count;
        Console.WriteLine("Lista de tamanho {0}",tamanho);

        //Capacity
        int capacidade = produtos.Capacity;
        Console.WriteLine("Capacidade de até: {0}",capacidade);

        //Determinando uma capacidade para lista
        produtos.Capacity = 20;
    }
}