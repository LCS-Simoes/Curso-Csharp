using System;


class Aula52
{
    static void Main(){
        int numero1, numero2, resultado;
        resultado = numero1 = numero2 = 0; // todos recbe 0

        numero1 = 10;
        numero2 = 0;

        /*
            Se dividir por zero resulta em: 
            Exceção Sem Tratamento: System.DivideByZeroException: Tentativa de divisão por zero.
            Assim necessário tratar a exceção
        */
        
        try{
            //Bloco try é quem vai executar as operações
            resultado = numero1 / numero2;
            Console.WriteLine("{0} / {1} = {2}", numero1,numero2,resultado);
        }catch(Exception e){
            //Variavel "e" recebe a exceção
            //Bloco de tratação de erros
            Console.WriteLine("Erro: {0}",e.Message);
            //Com o .Message eu só exibo a mensagem de erro e não o código inteiro da exceção
        }
        //Com o tratamento do erro o programa continua em execução
    
    }
}

/*
    Exceções
    Nada mais é do que erros que acontecem durante a execução do programa
    Toda exceção é representada por uma classe, que é uma closse derivada da
    Exception, e dentro dela temos vários tipos de exceções
*/