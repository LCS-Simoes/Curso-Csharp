using System;
using System.Collections.Generic;
using Internal;

class Aula57
{
    static void Main(){
        List<string> produtos = new List<string>();
        string[] produtos2 = new string[10];

        produtos.Add("Arroz");
        produtos.Add("Feijão");
        produtos.Add("Carne-Moida");
        produtos.Add("Maracuja");
        //produtos.Clear();

        //Verificações
        if(produtos.Contains("Arroz")){
            Console.WriteLine("Esta na lista");
        }else {
            Console.WriteLine("Não encontrado");
        }

        //Copyto
        produtos.CopyTo(produtos2,2); //(Onde eu quero, posição)

        foreach(string p in produtos2){
            Console.WriteLine("Produto: {0}", p);
        }

        string prod = "Feijão";
        int posicao = 0;
        posicao = produtos.IndexOf(prod); //Estou pesquisando em produtos  e vou guardar a posição
        Console.WriteLine("Produto esta na posição {0}", posicao);


    }
}

/*
    List<> 
    .Range: Adiciona uma série de elementos, pode copiar da outra lista 
    também
    .Contains: Procura na lista o elemento e retorna true or false
*/