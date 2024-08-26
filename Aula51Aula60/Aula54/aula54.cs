using System;

//Como utilizar namespace, só adicionar dentro do namespace
//Posso ter classes com o mesmo nome porém em namespaces diferentes

namespace Calc1{
    class Area{
        public static float Quad(float bas, float altura){
            if(bas == 0 || altura == 0){
                 throw new Exception("Base ou altura não podem ser igual a 0");
            }
        return bas * altura;
        }
    }
}

namespace Calc2{
    class Area{
        public static float Quad(float bas, float altura){
            if(bas == 0 || altura == 0){
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
        return bas * altura;
        }
    }
}



class Aula54
{
    static void Main(){
        float area = 0;

        try{
            area = Calc1.Area.Quad(10f,0f);
            Console.WriteLine("Area do quadrado: {0}",area);

        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);

        } finally{
            Console.WriteLine("Fim do tratamento");
        }
    }
}

/*
    NameSpace
    Ele tem o intuito de controlar o escopo
    É um método de organização, eu posso classificar os elementos com ele
    Basicamente o namespace é um jeito de organizar o código
*/