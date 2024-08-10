using System;
using Internal;

class aula08
{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;
        Console.Write("Resultado: " + soma);
        
    }
}


/*
    Console.ReadLine() Basicamente o scanf de cs
    Tudo que é lido do teclado é considerado string então para formatar para int é necessário
    utilizar ex: int.Parse(Console.ReadLine()); Assim ele converte já também.
    Ou utilizar v1 = Convert.ToInt32(Console.ReadLine());
*/