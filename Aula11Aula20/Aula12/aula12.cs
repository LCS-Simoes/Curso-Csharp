using System;
using Internal;

class aula12
{
    static void Main(){
        float nota1, nota2, media;
        Console.WriteLine("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        media = (nota1 + nota2) / 2;

        if(media >= 6){
            Console.WriteLine("Aprovado com média de: {0}", media);
        }else {
            Console.WriteLine("Reprovado");
        }
    }
}