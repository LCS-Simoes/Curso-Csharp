using System;
using Internal;

class Aula21{
    static void Main(){
        
        //int num = 5;
        
        string senha = "123";
        string senhauser;
        int tentativas = 0;

        do{
            Console.WriteLine("Digite a senha");
            senhauser = Console.ReadLine();
            Console.Clear();
            if(senha != senhauser){
                Console.WriteLine("Senha invalida");
                Console.WriteLine("Você tem 3 tentivas e já utilizou {0} ", tentativas+1);
                tentativas ++;
            }else {
                Console.WriteLine("Senha correta");
                break;
            }

            
        }while(tentativas < 3);

        if (tentativas >= 3) {
                 Console.WriteLine("Número máximo de tentativas alcançado.");
        }

        
        /*while(num < 5){
            Console.WriteLine("Não vai funcionar");
        }
        
        do {
            Console.WriteLine("Vai funcionar uma vez");
        }while(num < 5);
        */

    }
}


/*
    Do while me garante que pelo menos uma vez vai ser executado,
    pois ele executa e depois ele testa.

*/