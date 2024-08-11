using System;
using Internal;

class Aula16
{
    static void Main()
    {
        int opcao;
        
        inicio: 
        Console.Clear();
        Console.WriteLine("Guarulhos - SP a Orlando - USA");
        Console.WriteLine("Escolha a companhia aérea:");
        Console.WriteLine("[1] - Azul / [2] - Gol / [3] - Latam / [4] - American Airlines");
        
        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu a Azul");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a Gol");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a LATAM");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a American Airlines");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número.");
        }

        Console.WriteLine("Escolher novamente [S]/[N]");
        char escolha;
        escolha = char.Parse(Console.ReadLine());
        
        if(escolha == 's' || escolha == 'S'){
            goto inicio; //Passo goto e o nome do label, no caso o nosso é inicio
        }else {
            Console.Clear();
            Console.WriteLine("Fim da ação");
        }
    }
}

/*
    ~~ goto ~~ 
    Gera um desvio  no programa para um ponto determinado ou para um label determinado pelo programador
    É basicamente um do while do C
    Por escolha ser uma string e verificarmos um UNICO caracter é passivel do erro
    "Não é possível aplicar o operador '==' a operandos do tipo 'string' e 'char'"
    Para resolver isso é só fazer um cast de CHAR ou se persistir trocar string para char
*/ 