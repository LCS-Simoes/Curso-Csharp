using System;
using System.Collections.Generic;
using Internal;


class Aula59
{
    static void Main(){
        //Queue Sempre manipulo o 1 elemento da lista

        string [] vs = {"Carro", "Moto", "Navio","Aviao"};
        Queue<string> veiculos = new Queue<string>();

        
        //Enqueue ~~> método de adicionar no final
        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v = "Aviao";
        //Procurando o elemento na lista
        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo " + v + " Encontrado");
        }else {
            Console.WriteLine("Veiculo nao encontrado na fila");
        }
        
        //Quantidade de argumentos na fila
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);

        //Limpando a fila
        //veiculos.Clear();

        //Dequeue ~~> Retorna o elemento e elimina o elemento do inicio da fila
        Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);

        //Pick ~~> Retorna o primeiro elemento porém não remove o elemento
        Console.WriteLine("Primeiro veiculo " + veiculos.Peek());


        foreach (string f in veiculos)
        {
            Console.WriteLine("Fila: {0}",f);
        }


        //Remoção correta
        while(veiculos.Count > 0 ){
            Console.WriteLine("Removendo " + veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);



        /*
        ForEach de remoção do primeiro elemento.
            
        foreach (string f in veiculos)
        {
            f = veiculos.Dequeue();
            Console.WriteLine("Veiculo removido"  + f );
        }

        */
    }
}