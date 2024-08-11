using System;
using Internal;

class aula14
{
    static void Main(){
        float nota1, nota2, media;
        Console.WriteLine("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        media = (nota1 + nota2) / 2;
        Console.WriteLine("Como é feito a média (Aprovado >=6 || Recuperação >= 3 < 6 || Reprovado < 3)");
        if(media >= 6){
            Console.WriteLine("Aprovado com média de: {0}", media);
            if(media >= 9){
                Console.WriteLine("Parabéns");
            }
        }else if(media >= 4 && media < 6) {
            Console.WriteLine("Recuperação com nota: {0}", media);
        }else {
            Console.WriteLine("Reprovado, média: {0}",media);
        }
    }
}