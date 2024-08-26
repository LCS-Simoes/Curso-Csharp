using System;

class Area{
    public static float Quad(float bas, float altura){
        if(bas == 0 || altura == 0){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas * altura;
    }
}


class Aula53
{
    static void Main(){
        
        float area = 0;

        try{
            area = Area.Quad(10f,0f);
            Console.WriteLine("Area do quadrado: {0}",area);

        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);

        } finally{
            Console.WriteLine("Fim do tratamento");
        }
    }
}


/*
    Exceções com Finally
    Finally: Ele vai ser disparado mesmo se não tiver tido uma exceção
*/