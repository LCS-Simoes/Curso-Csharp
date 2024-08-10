using System;
using Internal;

class aula06
{
    static void Main(){
        double valorCompra = 10.98;
        double valorVenda;
        double lucro = 0.3;
        string produto = "Carne moída";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto......:{0,15}",produto);
        Console.WriteLine("Val.Compra......:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro......:{0,15:p}",lucro);
        Console.WriteLine("Val.Venda......:{0,15:c}",valorVenda);
    }
}

/*
    Console.WriteLine() Quebra a linha
    Console.Write() Segue direto
    "n1 = {0}, n2 = {1}, n3 = {3}", n1,n2,n3 Estou dizendo que {Dentro disso é o indice de posição}
    \n Enter ou quebra linha
    \t Tabulação Da tipo uma afastada no conteudo tipo a barra de espaço
    {0,15:c} 
    0 = índice
    15 = Tamanho do espaço que eu desejo adicionar
    :c = Formato monetário
    :p = Formato porcentagem
*/