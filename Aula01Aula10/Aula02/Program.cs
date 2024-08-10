using System;

namespace Aula02
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Lembrar de usar ./ no exe porque por algum motivo não está funcionando");
            if (args.GetLenght(0)) ;
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}