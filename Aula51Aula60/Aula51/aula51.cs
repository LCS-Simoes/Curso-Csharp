using System;


class Aula51{
    
    static void Main(string[] args){

        int resultado = 0;
        
        Console.WriteLine("Not Life");
        if(args.Length > 0){
            Console.WriteLine("Passou {0} argumentos",args.Length);
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine("Argumentos {0}: {1}",i,args[i]);
                resultado += Int32.Parse(args[i]); //Convertendo de string para inteiros
            }
            Console.WriteLine("Soma: {0}", resultado);
        }else{
            Console.WriteLine("Não teve argumentos");
        }
    }
}

/*
    Argumentos de entrada
    Passar na main e criar uma lista de argumentos / string[] args igual no javinha
    Posso passar agumentos dentro do proprio console quando inicio o programa 
    ex ./aula51 r 10 q 
    Assim tem 3 argumentos
*/