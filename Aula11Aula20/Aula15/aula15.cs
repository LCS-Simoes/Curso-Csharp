using System;

class Aula15
{
    static void Main()
    {
        Console.WriteLine("Guarulhos - SP a Orlando - USA");
        Console.WriteLine("Escolha a companhia aérea:");
        Console.WriteLine("[1] - Azul / [2] - Gol / [3] - Latam / [4] - American Airlines");
        
        int opcao;

        
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
    }
}

/*
TryParse: Converte uma string para um inteiro de forma segura, retornando um valor booleano que indica se a conversão foi bem-sucedida ou não.
out: Permite que um método modifique uma variável e passe o valor resultante de volta para o chamador.
*/