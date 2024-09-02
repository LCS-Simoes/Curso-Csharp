using System;
using System.Collections.Generic;



class Aula56
{
    static void Main(){

        LinkedList<string> nomes = new LinkedList<string>();

        nomes.AddFirst("Alanis");
        nomes.AddFirst("Lucas");
        nomes.AddFirst("Cleber");
        nomes.AddFirst("Gabriela");
        nomes.AddLast("Ana");
        
        
        //Adicionando alguém após ...
        LinkedListNode<string>no;
        no = nomes.FindLast("Cleber");
        nomes.AddAfter(no,"Jamily");

        //Adicionando alguém antes..
        no = nomes.FindLast("Lucas");
        nomes.AddBefore(no,"Isadora");
    

        foreach (string n  in nomes)
        {
            Console.WriteLine(n);
        }
    }
}


/*
    LinkedList ou Lista duplamente encadeada
    Cada elemento é um nó da lista que tem um link para um elemento posterior
    e anterior
*/